using Forum.Core.Repository.Posts;
using Forum.Core.Repository.Topics;
using Forum.Core.Repository.User;
using Forum.Entities.Db;
using Ninject;

namespace Forum.Core
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {
            Kernel = new StandardKernel();
            InitializeDependencies();
        }

        public static IKernel Kernel { get; private set; }

        private void InitializeDependencies()
        {
            Kernel.Bind<IDatabaseService>().To<DatabaseService>();
            Kernel.Bind<ITopicRepository>().To<TopicRepository>();
            Kernel.Bind<IUserRepository>().To<UserRepository>();
            Kernel.Bind<IPostRepository>().To<PostRepository>();
        }
    }
}
