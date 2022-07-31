using Forum.Api.Session;
using Forum.Core;
using Forum.Core.Repository.Posts;
using Forum.Entities.Models.ForumItems;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Ninject;

namespace Forum.Api.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : Controller
    {
        private readonly IPostRepository _postRepository;
        public PostsController()
        {
            _postRepository = Bootstrapper.Kernel.Get<IPostRepository>();
        }

        [HttpPost]
        public ActionResult<Post> Post(Post post)
        {
            var token = HttpContext.Request.Headers[HeaderNames.Authorization];
            var userId = SessionHandler.GetUserIdByToken(token);

            if (userId != null)
            {
                if (userId == post.UserId)
                {
                    var pst = _postRepository.AddPost(post);
                    return Ok(pst);
                }
                else
                {
                    return BadRequest();
                }

            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpPut]
        public ActionResult<Post> Put(Post post)
        {
            var token = HttpContext.Request.Headers[HeaderNames.Authorization];
            var userId = SessionHandler.GetUserIdByToken(token);

            if (userId != null)
            {
                if (userId == post.UserId)
                {
                    var pst = _postRepository.EditPost(post);
                    return Ok(pst);
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
