using Forum.Entities.Models.ForumItems;
using Forum.Entities.Models.User;

namespace Forum.Entities.Db
{
    public interface IDatabaseService
    {
        UserInfo AddUser(UserInfo userInfo);

        UserInfo GetUserById(Guid userId);

        UserInfo GetUserByEmail(string email);

        public Post AddPost(Post post);

        public Topic AddTopic(Topic topic);

        public Post EditPost(Post post);

    }
}
