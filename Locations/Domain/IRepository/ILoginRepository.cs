namespace Locations.Domain.IRepository
{
    using Locations.Domain.Models;

    public interface ILoginRepository
    {
        Task<User> ValidateUser(User user);
    }
}
