using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_website_Asp.Net.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";
        public DateTime created { get; set; } = DateTime.Now;
    }
}
