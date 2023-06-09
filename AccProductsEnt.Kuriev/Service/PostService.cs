using AccProductsEnt.Kuriev.Data;
using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public class PostService : IPostServive
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddPost(Post newPost)
        {
            _context.Posts.Add(newPost);
            _context.SaveChanges();
        }
    }
}
