﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialGoal.Model.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Focus> Foci { get; set; }

        public virtual ICollection<GroupInvitation> GroupInvitations { get; set; }

        public virtual ICollection<GroupRequest> GroupRequests { get; set; }

        public Group()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
