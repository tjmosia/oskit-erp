﻿using Microsoft.EntityFrameworkCore;

using OskitBlazor.Core.EFCore;
using OskitBlazor.Data;
using OskitBlazor.Models.Entity.SystemSpace;

namespace OskitBlazor.Areas.SystemSetups.Services.SubStores
{
    public class SystemCompanyNumberStore : DbStoreBase
    {
        public SystemCompanyNumberStore (AppDbContext? context, ILogger? logger)
            : base(context, logger) { }

        public async Task<SystemCompanyNumber?> CurrentAsync ()
            => await context!.SystemCompanyNumber.FirstOrDefaultAsync();

        public async Task<SystemCompanyNumber> CreateAsync (SystemCompanyNumber setup)
        {
            var result = await context!.SystemCompanyNumber.AddAsync(setup);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<SystemCompanyNumber> UpdateAsync (SystemCompanyNumber setup)
        {
            var result = context!.SystemCompanyNumber.Update(setup);
            await context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
