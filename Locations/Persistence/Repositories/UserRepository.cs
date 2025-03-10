namespace Locations.Persistence.Repositories
{
    using Locations.Domain.IRepository;
    using Locations.Domain.Models;
    using Locations.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SaveUser(User user)
        {
            this._context.Add(user);
            await this._context.SaveChangesAsync();
        }

        public async Task UpdateUser(User user)
        {
            this._context.Update(user);
            await this._context.SaveChangesAsync();
        }

        public async Task<bool> ValidateUser(User user)
        {
            var validateExistence = await _context.Users.AnyAsync(x => x.UserName == user.UserName);

            return validateExistence;
        }
    }
}
