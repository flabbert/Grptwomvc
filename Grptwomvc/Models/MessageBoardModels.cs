using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grptwomvc.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
    }
    public class Post
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }

    }
    
}
