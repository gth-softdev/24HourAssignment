using _24Hour.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class Like
    {
        public Post LikedPostId { get; set; }
        public User LikingUser { get; set; }
    }
}
