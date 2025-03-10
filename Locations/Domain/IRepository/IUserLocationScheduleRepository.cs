using Locations.Domain.Models;

namespace Locations.Domain.IRepository
{
    public interface IUserLocationScheduleRepository
    {
        Task SaveUserLocationSchedule(UserLocationSchedule userLocationSchedule);
        Task UpdateUserLocationSchedule(UserLocationSchedule userLocationSchedule);
    }
}
