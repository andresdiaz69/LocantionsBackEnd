namespace Locations.Domain.IServices
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.Models;

    public interface ICityService
    {
        Task<Result<List<City>>> GetCitiesByCountryId(int IdCountry);
    }
}
