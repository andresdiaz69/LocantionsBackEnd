namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface IUserRepository
    {
        Task SaveUser(User user);

        Task<bool> ValidateUser(User user);

        Task<User> ValidatePassword(long idUser, string oldPassword);

        Task UpdateUser(User user);
    }
}
