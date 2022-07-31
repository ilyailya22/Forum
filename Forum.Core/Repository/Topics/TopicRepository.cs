using Forum.Entities.Db;
using Forum.Entities.Models.ForumItems;

namespace Forum.Core.Repository.Topics
{
    public class TopicRepository : ITopicRepository
    {
        private readonly IDatabaseService _databaseService;

        public TopicRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Topic AddTopic(Topic topic)
        {
            var created = _databaseService.AddTopic(topic);

            return created;
        }

        
    }
}
