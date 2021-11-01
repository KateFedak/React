using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
