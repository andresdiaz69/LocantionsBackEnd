namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Persistence.Repositories;
    using System.Threading.Tasks;

    public class UserLocationScheduleService : IUserLocationScheduleService
    {
        private readonly IUserLocationScheduleRepository _repository;

        public UserLocationScheduleService(IUserLocationScheduleRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result> SaveUserLocationSchedule(UserLocationSchedule userLocationSchedule)
        {
            try
            {
                await _repository.SaveUserLocationSchedule(userLocationSchedule);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error creating user lcoation + {ex.Message}");
            }
        }

        public async Task<Result> UpdateUserLocationSchedule(UserLocationSchedule userLocationSchedule)
        {
            try
            {
                await _repository.UpdateUserLocationSchedule(userLocationSchedule);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error updating user lcoation + {ex.Message}");
            }
        }
    }
}
