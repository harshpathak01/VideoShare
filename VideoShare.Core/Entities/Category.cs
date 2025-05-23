﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VideoShare.Core.Entities
{
    public class Category: BaseEntity
    {
        [Required]
        public string Name { get; set; }

        // Navigation Properties
        public ICollection<Video> Videos { get; set; }
    }
}
