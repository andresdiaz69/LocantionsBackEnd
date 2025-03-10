namespace Locations.Utils
{
    using Locations.Domain.Models;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    public class JwtConfiigurator
    {
        public static string GetToken(User userInfo, IConfiguration config)
        {
            string SecretKey = config["Jwt:SecretKey"] ?? string.Empty;
            string Issuer = config["Jwt:Issuer"] ?? string.Empty;
            string Audience = config["Jwt:Audience"] ?? string.Empty;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim("UserId", userInfo.Id.ToString())
                //new Claim("ROle", userInfo.Id.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static long GetTokenUserId(ClaimsIdentity identity)
        {
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;

                foreach (var claim in claims)
                {
                    if (claim.Type == "UserId")
                    {
                        return long.Parse(claim.Value);
                    }
                }
            }

            return 0;
        }
    }
}
