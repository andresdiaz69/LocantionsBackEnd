namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using Locations.Persistence.Repositories;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Result> SaveUser(User user)
        {
            try
            {
                await _userRepository.SaveUser(user);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error creating user + {ex.Message}");
            }
        }

        public async Task<Result> UpdateUser(User user)
        {
            try
            {
                await _userRepository.UpdateUser(user);
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error updating user + {ex.Message}");
            }
        }

        public async Task<Result> ValidateUser(User user)
        {
            try
            {
                var validateUser = await _userRepository.ValidateUser(user);

                if (!validateUser)
                    return Result.Failure("User not valid");

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"Error validating user + {ex.Message}");
            }
        }
    }
}
