using Locations.Domain.Entities.Generic;
using Locations.Domain.Models;

namespace Locations.Domain.IServices
{
    public interface ICountryService
    {
        Task<Result<List<Country>>> GetAllCountries();
    }
}
