using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastucture
{
    public class CommentContextFactory: IDesignTimeDbContextFactory<CommentContext>
    {
        public CommentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommentContext>();
            optionsBuilder.UseNpgsql(Setup.ConnectionString);

            return new CommentContext(optionsBuilder.Options);
        }
    }
}