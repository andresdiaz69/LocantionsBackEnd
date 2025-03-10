using Locations.Domain.Entities.Generic;
using Locations.Domain.Models;

namespace Locations.Domain.IServices
{
    public interface IUserService
    {
        Task<Result> SaveUser(User user);

        Task<Result> ValidateUser(User user);

        Task<Result> UpdateUser(User user);
    }
}
