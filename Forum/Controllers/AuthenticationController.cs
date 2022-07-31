using Forum.Api.Session;
using Forum.Core;
using Forum.Core.Repository.User;
using Forum.Entities.Models.Auth;
using Forum.Entities.Models.User;
using Microsoft.AspNetCore.Mvc;
using Ninject;
using System.IdentityModel.Tokens.Jwt;

namespace Forum.Api.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationController()
        {
            _userRepository = Bootstrapper.Kernel.Get<IUserRepository>();
        }

        [HttpPost]
        public ActionResult<string> Post(UserLoginModel user)
        {
            var isAuthenticated = _userRepository.CheckUserForAuth(user);
            if (!isAuthenticated)
            {
                return BadRequest("Incorrect name or password");
            }

            var jwt = new JwtSecurityToken(
                issuer: AuthOptions.ISSUER,
                audience: AuthOptions.AUDIENCE,
                notBefore: DateTime.Now,
                expires: DateTime.Now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)));

            var userInfo = _userRepository.GetUserByEmail(user.Email);

            SessionHandler.AddSession(userInfo.Id, jwt.EncodedPayload);

            return Ok(new AuthResult { Token = jwt.EncodedPayload });
        }
    }
}
