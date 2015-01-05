using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blogg.Models
{
    [Table("Posts")]
    public class Post
    {
        public int postId { get; set;  }
        public string postAuthor { get; set; }
        public int postAddedAt { get; set; }
        public string postContent { get; set; }

    }
}