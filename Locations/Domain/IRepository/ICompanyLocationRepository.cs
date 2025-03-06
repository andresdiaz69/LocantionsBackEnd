namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface ICompanyLocationRepository
    {
        Task SaveCompanyLocation(CompanyLocation companyLocation);

        Task<List<CompanyLocation>> GetAllCompanyLocations();

        Task UpdateCompanyLocation(CompanyLocation companyLocation);

        Task<CompanyLocation> GetCompanyLocationById(long IdCompanyLocation);
    }
}
