namespace Locations.Domain.IServices
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.Models;

    public interface IUserLocationScheduleService
    {
        Task<Result> SaveUserLocationSchedule(UserLocationSchedule userLocationSchedule);
        Task<Result> UpdateUserLocationSchedule(UserLocationSchedule userLocationSchedule);
    }
}
