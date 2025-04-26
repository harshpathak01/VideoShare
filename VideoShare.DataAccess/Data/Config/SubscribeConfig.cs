using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShare.Core.Entities;

namespace VideoShare.DataAccess.Data.Config
{
    public class SubscribeConfig : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.HasKey(s => new { s.AppUserId, s.ChannelId });
            builder.HasOne(s => s.AppUser).WithMany(c => c.Subscriptions).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Channel).WithMany(c => c.Subscribers).HasForeignKey(s => s.ChannelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
