using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoShare.Core.Entities
{
    public class Subscribe
    {
        public int AppUserId { get; set; }
        public int ChannelId { get; set; }

        // Navigation Properties
        public AppUser AppUser { get; set; }
        public Channel Channel { get; set; }
    }
}
