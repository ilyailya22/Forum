using Forum.Entities.Models.ForumItems;

namespace Forum.Core.Repository.Topics
{
    public interface ITopicRepository
    {
        public Topic AddTopic(Topic topic);

    }
}
