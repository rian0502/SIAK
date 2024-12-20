﻿using DHR.Helper;
using DHR.ViewModels;
using DHR.Models;
using DHR.ViewModels.Company;
using Microsoft.EntityFrameworkCore;

namespace DHR.Providers
{
    public class CompanyService(AppDbContext context)
    {
        private readonly AppDbContext _context = context;
        private readonly string _storeProcedure = "sp_Company";

        // FindAll
        public async Task<IEnumerable<CompanyModel>> FindAll()
        {
            var results = await _context.Companies
                .Include(c => c.Location)
                .ToListAsync();
            return results;
        }

        // FindById
        public async Task<CompanyModel> FindById(int id)
        {
            var results = await _context.Companies
                .FromSqlInterpolated($"EXEC {_storeProcedure} @Action = 'FindById', @Id = {id}")
                .ToListAsync();
            return results.FirstOrDefault();
        }

        // Insert
        public async Task<int> Insert(CreateCompanyViewModel company, string userId, DateTime time)
        {
            //check if code already exist
            var check = await _context.Companies
                .FirstOrDefaultAsync(x => x.CompanyCode == company.CompanyCode);
            if (check != null)
            {
                return 3;
            }

            var result = await _context.Database.ExecuteSqlAsync($@"
                    EXEC {_storeProcedure} 
                    @Action = 'Insert',
                    @Code = {company.CompanyCode},
                    @Name = {company.CompanyName},
                    @LocationID = {company.LocationId},
                    @CreatedBy = {userId},
                    @CreatedAt = {time},
                    @UpdatedBy = {userId},
                    @UpdatedAt = {time}
            ");
            return result;
        }

        // Update
        public async Task<int> Update(EditCompanyViewModel company, string userId, DateTime time)
        {
            var result = await _context.Database.ExecuteSqlAsync($@"
                    EXEC {_storeProcedure} 
                    @Action = 'Update', 
                    @Id = {company.CompanyId}, 
                    @Code = {company.CompanyCode}, 
                    @Name = {company.CompanyName}, 
                    @LocationID = {company.LocationId},
                    @UpdatedBy = {userId},
                    @UpdatedAt = {time}
            ");
            return result;
        }
    }
}