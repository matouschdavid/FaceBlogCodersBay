using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBlog.Lib
{
    public class BlogRepository
    {
        List<Blog> blogs = new List<Blog>()
            {
                new Blog("First Blog ever", "Coolest text ever", "Me"),
                new Blog("Boring", "Real boring", "you")
            };

        public List<Blog> GetBlogs()
        {
            return blogs;
        }

        public Blog GetBlogByTitle(string title)
        {
            return blogs.FirstOrDefault(b => b.Title == title);
        }

        public Blog AddBlog(string title, string text, string author)
        {
            var b = new Blog(title, text, author);
            blogs.Add(b);
            return b;
        }
    }
}
