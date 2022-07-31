using Forum.Core;
using Forum.Core.Repository.User;
using Forum.Entities.Models.User;
using Microsoft.AspNetCore.Mvc;
using Ninject;

namespace Forum.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UsersController()
        {
            _userRepository = Bootstrapper.Kernel.Get<IUserRepository>();
        }

        [HttpPost]
        public ActionResult<UserInfo> Post(UserInfo userInfo)
        {
            var user = _userRepository.CreateUser(userInfo);
            return Ok(user);
        }
    }
}
