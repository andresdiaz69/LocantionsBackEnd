namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface ICountryRepository
    {
        Task<List<Country>> GetCountries();
    }
}
