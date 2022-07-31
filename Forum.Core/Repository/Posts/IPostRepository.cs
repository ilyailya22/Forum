using Forum.Entities.Models.ForumItems;

namespace Forum.Core.Repository.Posts
{
    public interface IPostRepository
    {
        public Post AddPost(Post post);

        public Post EditPost(Post post);

    }
}
