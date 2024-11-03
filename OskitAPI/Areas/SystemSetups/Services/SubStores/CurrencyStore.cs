﻿using Microsoft.EntityFrameworkCore;

using OskitAPI.Core.EFCore;
using OskitAPI.Data;
using OskitAPI.Models.Entity.SystemSpace;

namespace OskitAPI.Areas.SystemSetups.Services.SubStores
{
    public class CurrencyStore : DbStoreBase
    {
        public CurrencyStore (AppDbContext? context, ILogger? logger)
            : base(context, logger) { }

        /// <exception cref="DbUpdateException"/>
        public async Task<Currency> CreateAsync (Currency currency)
        {
            var result = await context!.Currency.AddAsync(currency);
            await context.SaveChangesAsync();

            return result.Entity;
        }

        /// <exception cref="DbUpdateException"/>
        public async Task<Currency> UpdateAsync (Currency currency)
        {
            var result = context!.Currency.Update(currency);
            await context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<Currency?> FindByCodeAsync (string code)
            => await context!.Currency.FindAsync(code);

        public async Task<Currency?> FindByNameAsync (string name)
            => await context!.Currency
                .Where(p => string.Equals(p.Name, name, StringComparison.CurrentCultureIgnoreCase))
                .FirstOrDefaultAsync();

        public async Task DeleteAsync (params Currency[] currencies)
        {
            context!.Currency.RemoveRange(currencies);
            await context.SaveChangesAsync();
        }

        public async Task<IList<Currency>> FindAllAsync ()
            => await context!.Currency.ToListAsync();
    }
}