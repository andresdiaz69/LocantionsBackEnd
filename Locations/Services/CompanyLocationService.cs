namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Persistence.Repositories;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CompanyLocationService : ICompanyLocationService
    {
        private readonly ICompanyLocationRepository _companyLocationRepository;

        public CompanyLocationService(ICompanyLocationRepository companyLocationRepository)
        {
            _companyLocationRepository = companyLocationRepository;
        }

        public async Task<Result<List<CompanyLocation>>> GetAllCompanyLocations()
        {
            try
            {
                var companyLocationList = await _companyLocationRepository.GetAllCompanyLocations();

                if (companyLocationList == null)
                    return Result<List<CompanyLocation>>.Failure("No CompanyLocation found");

                return Result<List<CompanyLocation>>.Success(companyLocationList);
            }
            catch (Exception ex)
            {
                return Result<List<CompanyLocation>>.Failure($"Error getting CompanyLocation: {ex.Message} ");
            }
        }

        public async Task<Result<CompanyLocation>> GetCompanyLocationById(long IdCompanyLocation)
        {
            try
            {
                var companyLocation = await _companyLocationRepository.GetCompanyLocationById(IdCompanyLocation);

                if (companyLocation == null)
                    return Result<CompanyLocation>.Failure("No CompanyLocation found");

                return Result<CompanyLocation>.Success(companyLocation);
            }
            catch (Exception ex)
            {
                return Result<CompanyLocation>.Failure($"Error getting CompanyLocation: {ex.Message} ");
            }
        }

        public async Task<Result> SaveCompanyLocation(CompanyLocation companyLocation)
        {
            try
            {
                await _companyLocationRepository.SaveCompanyLocation(companyLocation);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error creating company Location + {ex.Message}");
            }
        }

        public async Task<Result> UpdateCompanyLocation(CompanyLocation companyLocation)
        {
            try
            {
                await _companyLocationRepository.UpdateCompanyLocation(companyLocation);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error updating company Location + {ex.Message}");
            }
        }
    }
}
