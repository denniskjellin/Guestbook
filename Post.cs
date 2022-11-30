using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guestbook
{
    public class Post
    {
        // set Author and set Content.
        // Get and return author/content.
        private string author;
        public string Author
        {
            set { this.author = value; }
            get { return this.author; }
        }
        private string content;
        public string Content
        {
            set { this.content = value; }
            get { return this.content; }
        }

    }
}
