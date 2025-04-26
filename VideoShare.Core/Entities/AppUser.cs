using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoShare.Core.Entities
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public Channel Channel { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Subscribe> Subscriptions { get; set; }
        public ICollection<LikeDislike> LikeDislikes { get; set; }
    }
}
