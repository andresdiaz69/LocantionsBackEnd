using Locations.Domain.Models;

namespace Locations.Domain.IRepository
{
    public interface IUserLocationSchedule
    {
        Task SaveUserLocationSchedule(UserLocationSchedule userLocationSchedule);
        Task UpdateUserLocationSchedule(UserLocationSchedule userLocationSchedule);
    }
}
