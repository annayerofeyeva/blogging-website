using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    public class Post
    {
        public int postId { get; set;  }
        public string postAuthor { get; set; }
        public DateTime postAddedAt { get; set; }
        public string postContent { get; set; }

    }
}