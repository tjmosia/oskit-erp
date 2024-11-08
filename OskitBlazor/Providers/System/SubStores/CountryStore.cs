﻿using Microsoft.EntityFrameworkCore;

using OskitBlazor.Core.EFCore;
using OskitBlazor.Data;
using OskitBlazor.Models.Entity.SystemSpace;

namespace OskitBlazor.Areas.SystemSetups.Services.SubStores
{
    public class CountryStore : DbStoreBase
    {
        public CountryStore (AppDbContext? context, ILogger? logger)
            : base(context, logger) { }

        /// <exception cref="DbUpdateException"/>
        public async Task<Country> CreateAsync (Country country)
        {
            var result = await context!.Country.AddAsync(country);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        /// <exception cref="DbUpdateException"/>
        public async Task<Country> UpdateAsync (Country country)
        {
            var result = context!.Country.Update(country);
            await context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Country?> FindByCodeAsync (string code)
            => await context!.Country.FindAsync(code);

        public async Task<Country?> FindByNameAsync (string name)
            => await context!.Country
                .Where(p => string.Equals(p.Name, name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefaultAsync();

        public async Task DeleteAsync (params Country[] countries)
        {
            context!.Country.RemoveRange(countries);
            await context.SaveChangesAsync();
        }

        public async Task<IList<Country>> FindAllAsync ()
            => await context!.Country.ToListAsync();

    }
}
