namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Persistence.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<Result<List<Country>>> GetAllCountries()
        {
            try
            {
                var countries = await _countryRepository.GetCountries();

                if (countries == null)
                    return Result<List<Country>>.Failure("No countries found");

                return Result<List<Country>>.Success(countries);

            }
            catch (Exception ex)
            {
                return Result<List<Country>>.Failure($"Error getting countries: {ex.Message} ");
            }
        }
    }
}
