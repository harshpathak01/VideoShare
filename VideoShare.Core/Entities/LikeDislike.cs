using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShare.Core.Entities
{
    public class LikeDislike
    {
        public int AppUserId { get; set; }
        public int VideoId { get; set; }
        public bool Liked { get; set; } = true; // true for like, false for dislike

        // Navigation Properties
        public AppUser AppUser { get; set; }
        public Video Video { get; set; }

    }
}
