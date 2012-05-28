using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blogosphere.Models
{
    public class Blog
    {
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Post { get; set; }
        public string Title { get; set; }
        [Key]
        public string ShortName { get; set; }
    }
}