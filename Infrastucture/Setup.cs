using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastucture
{
    public class Setup
    {
        public const string ConnectionString =
            "User ID=postgres;Password=password1;Host=localhost;Port=5432;Database=IdeasDb;Pooling=true;";
        
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = ConnectionString;
            services.AddDbContext<CommentContext>(
                opts => opts.UseNpgsql(connectionString)
            );
        }

    }
}