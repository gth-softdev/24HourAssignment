using _24Hour.Data;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Hour.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public User Author
        {
            get
            {

            }
        }
        public Post CommentPost
        {
            get
            {

            }
        }
    }
}
