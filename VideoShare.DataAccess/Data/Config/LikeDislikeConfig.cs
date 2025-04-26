using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoShare.Core.Entities;

namespace VideoShare.DataAccess.Data.Config
{
    public class LikeDislikeConfig: IEntityTypeConfiguration<LikeDislike>
    {
        public void Configure(EntityTypeBuilder<LikeDislike> builder)
        {
            builder.HasKey(ld => new { ld.AppUserId, ld.VideoId });
            builder.HasOne(ld => ld.AppUser).WithMany(u => u.LikeDislikes).HasForeignKey(ld => ld.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(ld => ld.Video).WithMany(v => v.LikeDislikes).HasForeignKey(ld => ld.VideoId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
