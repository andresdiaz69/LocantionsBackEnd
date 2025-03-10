namespace Locations.Domain.IServices
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.Models;

    public interface ICompanyLocationService
    {
        Task<Result> SaveCompanyLocation(CompanyLocation companyLocation);

        Task<Result<List<CompanyLocation>>> GetAllCompanyLocations();

        Task<Result> UpdateCompanyLocation(CompanyLocation companyLocation);

        Task<Result<CompanyLocation>> GetCompanyLocationById(long IdCompanyLocation);
    }
}
