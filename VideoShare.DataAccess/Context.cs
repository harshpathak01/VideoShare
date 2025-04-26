using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VideoShare.Core.Entities;
using VideoShare.DataAccess.Data.Config;

namespace VideoShare.DataAccess
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Channel> Channels { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //$ builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutionAssembly());
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new SubscribeConfig());
            builder.ApplyConfiguration(new LikeDislikeConfig());
        }
    }
}
