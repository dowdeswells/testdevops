using Microsoft.EntityFrameworkCore;

namespace Infrastucture
{
    public class CommentContext : DbContext
    {
        public CommentContext(DbContextOptions<CommentContext> options)
            : base(options)
        { }

        public DbSet<Idea> Ideas { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}