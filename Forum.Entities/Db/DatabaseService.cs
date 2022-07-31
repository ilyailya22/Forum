using Forum.Entities.Models.ForumItems;
using Forum.Entities.Models.User;

namespace Forum.Entities.Db
{
    public class DatabaseService : IDatabaseService
    {
        public UserInfo AddUser(UserInfo userInfo)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Users.Add(userInfo);
                db.SaveChanges();

                return userInfo;
            }
        }

        public UserInfo GetUserById(Guid userId)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var userInfo = db.Users.FirstOrDefault(u => u.Id == userId);

                return userInfo;
            }
        }

        public UserInfo GetUserByEmail(string email)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var userInfo = db.Users.FirstOrDefault(u => u.Email == email);

                return userInfo;
            }
        }

        public Post AddPost(Post post)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();

                return post;
            }
        }

        public Topic AddTopic(Topic topic)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Topics.Add(topic);
                db.SaveChanges();

                return topic;
            }
        }

        public Post EditPost(Post post)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Posts.Update(post);
                db.SaveChanges();
                return post;
            }
        }
    }
}
