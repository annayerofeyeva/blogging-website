using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blogg.Models
{
    public class PostContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}