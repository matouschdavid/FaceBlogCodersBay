using FaceBlog.Lib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FaceBlogCodersBay.RestAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpPost]
        public void AddBlog([FromBody] Blog blog)
        {
            BlogRepository.Instance.AddBlog(blog);
        }

        [HttpDelete("{title}")]
        public void DeleteBlog(string title)
        {
            BlogRepository.Instance.DeleteBlog(title);
        }

        [HttpPut("{title}")]
        public void UpdateBlog(string title, [FromBody] Blog blog)
        {
            BlogRepository.Instance.UpdateBlog(title, blog);
        }

        [HttpGet("{title}")]
        public Blog GetBlogByTitle(string title)
        {
            return BlogRepository.Instance.GetBlogByTitle(title);
        }

        [HttpGet]
        public List<Blog> GetBlogs()
        {
            return BlogRepository.Instance.GetBlogs();
        }
    }
}
