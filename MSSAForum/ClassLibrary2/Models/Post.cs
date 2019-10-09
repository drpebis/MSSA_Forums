using System;
using System.Collections.Generic;
using System.Text;

namespace MSSAForum.Data.Models
{
    public class Post
    {
        //data relating to posts
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        //forum
        public virtual ApplicationUser User { get; set; }
        public virtual Forum forum { get; set; }

        //Replies to posts
        public virtual IEnumerable<PostReply> Replies { get; set; }
    }
}
