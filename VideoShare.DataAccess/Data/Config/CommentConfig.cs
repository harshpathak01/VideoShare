using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShare.Core.Entities;

namespace VideoShare.DataAccess.Data.Config
{
    public class CommentConfig: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => new {c.AppUserId, c.VideoId});
            builder.HasOne(c => c.Video).WithMany(v => v.Comments).HasForeignKey(c => c.VideoId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(c => c.AppUser).WithMany(u => u.Comments).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
