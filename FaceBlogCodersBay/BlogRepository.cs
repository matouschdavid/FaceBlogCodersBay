using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceBlog.Lib
{
    public class BlogRepository
    {
        //private instance

        //public getInstance

        private static BlogRepository? instance;

        public static BlogRepository Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new BlogRepository();
                }

                return instance;
            }
        }

        //private constructor
        private BlogRepository() { }

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

        public void DeleteBlog(string title)
        {
            //Get copy of list
            //var copyOfBlogs = blogs;
            //foreach (var blog in blogs)
            //{
            //    if (blog.Title == title)
            //    {
            //        copyOfBlogs.Remove(blog);
            //    }
            //}
            //blogs = copyOfBlogs;

            blogs.RemoveAll(b => b.Title == title);
        }

        public void AddBlog(Blog blog)
        {
            blogs.Add(blog);
        }

        public void UpdateBlog(string title, Blog blog)
        {
            //Löschen das Objekt
            DeleteBlog(title);
            //Erstellen Objekt neu
            AddBlog(blog);
        }
    }
}
