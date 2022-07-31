using Forum.Entities.Db;
using Forum.Entities.Models.ForumItems;

namespace Forum.Core.Repository.Posts
{
    public class PostRepository : IPostRepository
    {
        private readonly IDatabaseService _databaseService;

        public PostRepository(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Post AddPost(Post post)
        {
            var created = _databaseService.AddPost(post);

            return created;
        }

        public Post EditPost(Post post)
        {
            var edited = _databaseService.EditPost(post);

            return edited;
        }
    }
}
