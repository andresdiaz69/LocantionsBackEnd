namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface ICityRepository
    {
        Task<List<City>> GetCitiesByCountryId(int IdCountry);
    }
}
