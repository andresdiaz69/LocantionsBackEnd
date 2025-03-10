namespace Locations.Services
{
    using Locations.Domain.Entities.Generic;
    using Locations.Domain.IRepository;
    using Locations.Domain.IServices;
    using Locations.Domain.Models;
    using System;
    using System.Threading.Tasks;

    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            this._loginRepository = loginRepository;
        }

        public async Task<Result<User>> ValidateUser(User user)
        {
            try
            {
                var validateUser = await _loginRepository.ValidateUser(user);

                if (validateUser == null)
                    return Result<User>.Failure("No teachers found");

                return Result<User>.Success(validateUser);
            }
            catch (Exception ex)
            {
                return Result<User>.Failure($"Error getting user: {ex.Message} ");
            }
        }
    }
}
