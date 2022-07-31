using Forum.Core;
using Forum.Core.Repository.Topics;
using Forum.Entities.Models.ForumItems;
using Microsoft.AspNetCore.Mvc;
using Ninject;

namespace Forum.Api.Controllers
{
    [ApiController]
    [Route("api/topics")]
    public class TopicsController : Controller
    {
        private readonly ITopicRepository _topicRepository;
        public TopicsController()
        {
            _topicRepository = Bootstrapper.Kernel.Get<ITopicRepository>();
        }

        [HttpPost]
        public ActionResult<Topic> Post(Topic topic)
        {
            var top = _topicRepository.AddTopic(topic);
            return Ok(top);
        }
    }
}
