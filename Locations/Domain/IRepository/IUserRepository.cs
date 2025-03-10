namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface IUserRepository
    {
        Task SaveUser(User user);

        Task<bool> ValidateUser(User user);

        Task UpdateUser(User user);
    }
}
