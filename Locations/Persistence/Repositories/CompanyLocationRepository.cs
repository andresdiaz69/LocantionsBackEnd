namespace Locations.Persistence.Repositories
{
    using Locations.Domain.IRepository;
    using Locations.Domain.Models;
    using Locations.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CompanyLocationRepository : ICompanyLocationRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyLocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompanyLocation>> GetAllCompanyLocations()
        {
            return await _context.CompanyLocations.ToListAsync();
        }

        public async Task<CompanyLocation> GetCompanyLocationById(long IdCompanyLocation)
        {
            return await _context.CompanyLocations
                .Where(x => x.Id == IdCompanyLocation).FirstOrDefaultAsync();
        }

        public async Task SaveCompanyLocation(CompanyLocation companyLocation)
        {
            _context.Add(companyLocation);

            await this._context.SaveChangesAsync();
        }

        public async Task UpdateCompanyLocation(CompanyLocation companyLocation)
        {
            _context.Update(companyLocation);

            await this._context.SaveChangesAsync();
        }
    }
}
