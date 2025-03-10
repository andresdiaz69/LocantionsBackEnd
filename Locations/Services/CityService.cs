namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Persistence.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository _cityRepository)
        {
            this._cityRepository = _cityRepository;
        }

        public async Task<Result<List<City>>> GetCitiesByCountryId(int IdCountry)
        {
            try
            {
                var cities = await _cityRepository.GetCitiesByCountryId(IdCountry);

                if (cities == null)
                    return Result<List<City>>.Failure("No cities found");

                return Result<List<City>>.Success(cities);
            }
            catch (Exception ex)
            {
                return Result<List<City>>.Failure($"Error getting cities: {ex.Message} ");
            }
        }
    }
}
