using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GighubV2.Models;

namespace GighubV2.Controllers
{
    public class Follow
    {
        public ApplicationUser Follower { get; set; }

        public string FollowerId { get; set; }

        public ApplicationUser Followee { get; set; }

        public string FolloweeId { get; set; }

    }
}