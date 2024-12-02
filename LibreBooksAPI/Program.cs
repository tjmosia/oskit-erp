using LibreBooks.Areas.Inventory.Services;
using LibreBooks.Areas.SystemSetups.Services;
using LibreBooks.Areas.SystemSetups.Services.SubStores;
using LibreBooks.Core.EFCore;
using LibreBooks.Data;
using LibreBooks.Extensions.Identity;
using LibreBooks.Models.Entity.IdentitySpace;

using LibreBooksAPI.Areas.SystemSetups.Services.SubStores;

using Microsoft.AspNetCore.Http.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var Config = builder.Configuration;

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(Config.GetConnectionString("MoskitContext")));
builder.Services.AddDistributedMemoryCache();

builder.Services.AddIdentityCore<User>
    (options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 8;
        options.Password.RequiredUniqueChars = 6;
        options.Password.RequireLowercase = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireNonAlphanumeric = true;
        options.SignIn.RequireConfirmedEmail = true;
        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
        options.Lockout.MaxFailedAccessAttempts = 5;
        options.Lockout.AllowedForNewUsers = false;
        options.User.RequireUniqueEmail = true;
    })
    .AddRoles<Role>()
    .AddUserManager<UserManagerExt>()
    .AddSignInManager<SignInManagerExt>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddErrorDescriber<IdentityErrorDescriberExt>()
    .AddDefaultTokenProviders();

JwtBearerProvider.Configure(builder);

builder.Services.AddSingleton<IdentityErrorDescriberExt>();
builder.Services.AddSingleton<DbErrorDescriber>();
builder.Services.AddScoped<SystemStore>();
builder.Services.AddScoped<ISystemManager, SystemManager>();
builder.Services.AddScoped<ItemStore>();
builder.Services.AddScoped<IItemManager, ItemManager>();
builder.Services.AddScoped<CountryStore>();
builder.Services.AddScoped<CurrencyStore>();
builder.Services.AddScoped<DateFormatStore>();
builder.Services.AddScoped<PaymentMethodStore>();
builder.Services.AddScoped<PaymentTermStore>();
builder.Services.AddScoped<ShippingTermStore>();
builder.Services.AddScoped<ShippingMethodStore>();
builder.Services.AddScoped<TaxTypeStore>();
builder.Services.AddScoped<SystemCompanyNumberStore>();
builder.Services.AddScoped<BusinessSectorStore>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("DevOrigin", options =>
    {
        options.WithOrigins("http://localhost:5173", "https://localhost:5262")
            .AllowCredentials()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Services.AddControllers()
    .AddNewtonsoftJson();

builder.Services.Configure<JsonOptions>(opts =>
    opts.SerializerOptions.IncludeFields = true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("DevOrigin");
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseHttpsRedirection();
//app.Use(async (context, next) =>
//{
//    context.Request.Cookies.TryGetValue(JwtTokenKeys.AccessToken, out var token);
//    if (token != null)
//        context.Request.Headers.Authorization = $"Bearer {token}";
//    await next.Invoke();
//});
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();