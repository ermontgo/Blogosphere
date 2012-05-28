using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blogosphere.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Posts { get; set; }
    }
}