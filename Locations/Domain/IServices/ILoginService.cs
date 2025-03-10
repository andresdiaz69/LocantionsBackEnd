namespace Locations.Domain.IServices
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.Models;

    public interface ILoginService
    {
        Task<Result<User>> ValidateUser(User user);
    }
}
