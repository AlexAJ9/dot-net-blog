using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogNetApp.Models
{
    public enum Tag
    {
        Social,Tech,Music,Lifstyle,Random
    }
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public Tag? Tag { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }

    }
}