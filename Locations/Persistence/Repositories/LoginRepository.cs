namespace Locations.Persistence.Repositories
{
    using Locations.Domain.IRepository;
    using Locations.Domain.Models;
    using Locations.Persistence.Context;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class LoginRepository : ILoginRepository
    {
        public readonly ApplicationDbContext _context;

        public LoginRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<User> ValidateUser(User user)
        {
            var userF = await this._context.Users.Where(
               x => x.UserName == user.UserName
               && x.Password == user.Password).FirstOrDefaultAsync();

            return userF;
        }
    }
}
