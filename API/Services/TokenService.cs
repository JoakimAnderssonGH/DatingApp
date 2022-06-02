using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace API.Services
{
    public class TokenService : ITokenService
    {
        // En nyckel för att signera och verifiera
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration config)
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));
        }
        public string CreateToken(AppUser user)
        {
            // Lägger till claims
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
            };

            // Skapar credentials
            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);
            
            // Beskriver hur token ska se ut
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds
            };

            // Skapar en tokenHandler
            var tokenHandler = new JwtSecurityTokenHandler();

            // Skapar en token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Returnerar den skrivna token
            return tokenHandler.WriteToken(token);
        }
    }
}