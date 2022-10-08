using FaceBlog.Lib;

namespace FaceBlog.ConsoleApp;

public class Programm
{
    public static void Main(string[] argv)
    {
        //create a blog repository
        var blogRepository = new BlogRepository();

        //print blogs
        foreach (var blog in blogRepository.GetBlogs())
        {
            PrintBlog(blog);
        }

        //create a blog
        Console.Write("Gib einen Title ein: ");
        string title = Console.ReadLine();
        Console.Write("Gib einen Text ein: ");
        string text = Console.ReadLine();
        Console.Write("Gib deinen Namen ein: ");
        string author = Console.ReadLine();
        var newBLog = blogRepository.AddBlog(title, text, author);
        PrintBlog(newBLog);
    }


    static void PrintBlog(Blog blog)
    {
        Console.WriteLine(blog.Title);
        Console.WriteLine(blog.Text);
        Console.WriteLine($"by {blog.Author}");
        Console.WriteLine(blog.TimeStamp.ToShortDateString());
    }
}