namespace Locations.Persistence.Repositories
{
    using Locations.Domain.IRepository;
    using Locations.Domain.Models;
    using Locations.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;
        
        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetCitiesByCountryId(int IdCountry)
        {
            var users = await _context.Cities.Where(x => x.IdCountry == IdCountry).ToListAsync();

            return users;
        }
    }
}
