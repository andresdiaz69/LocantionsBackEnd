namespace Locations.Persistence.Repositories
{
    using Locations.Domain.IRepository;
    using Locations.Domain.Models;
    using Locations.Persistence.Context;
    using System.Threading.Tasks;

    public class UserLocationScheduleRepository : IUserLocationScheduleRepository
    {
        private readonly ApplicationDbContext _context;

        public UserLocationScheduleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUserLocationSchedule(UserLocationSchedule userLocationSchedule)
        {
            _context.Add(userLocationSchedule);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserLocationSchedule(UserLocationSchedule userLocationSchedule)
        {
            _context.Update(userLocationSchedule);
            await _context.SaveChangesAsync();
        }
    }
}
