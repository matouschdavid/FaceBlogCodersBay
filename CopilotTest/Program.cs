// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//create a blogrepository
var blogRepo = new BlogRepository();

//get all blogs
foreach (Blog blog in blogRepo.GetBlogs())
{
    PrintBlog(blog);
}

//create a new blog via user input and print it
Blog newBlog = WriteBlog(blogRepo);
PrintBlog(newBlog);

//WriteBlog
static Blog WriteBlog(BlogRepository blogRepo)
{
    Console.Write("Gib einen Titel ein: ");
    string title = Console.ReadLine();
    Console.Write("Gib einen Text ein: ");
    string text = Console.ReadLine();
    Console.Write("Gib deinen Namen ein: ");
    string author = Console.ReadLine();
    //Usereingabe in neues Blogobjekt speichern
    return blogRepo.AddBlog(title, text, author);
}

//PrintBlog
static void PrintBlog(Blog blog)
{
    Console.WriteLine(blog.Title);
    Console.WriteLine(blog.Text);
    Console.WriteLine($"by {blog.Author}");
    Console.WriteLine(blog.TimeStamp.ToShortDateString());
    Console.WriteLine();
}

//create a blog class with a title, text, author and timestamp
public class Blog
{
    public string Title { get; set; }
    public string Text { get; set; }
    public string Author { get; set; }
    public DateTime TimeStamp { get; set; }
}

//create a blog repository class with a list of blogs
public class BlogRepository
{
    private List<Blog> _blogs = new List<Blog>();

    public List<Blog> GetBlogs()
    {
        return _blogs;
    }

    public Blog AddBlog(string title, string text, string author)
    {
        Blog blog = new Blog();
        blog.Title = title;
        blog.Text = text;
        blog.Author = author;
        blog.TimeStamp = DateTime.Now;
        _blogs.Add(blog);
        return blog;
    }

    //create constructor that initialses the list with some blogs
    public BlogRepository()
    {
        AddBlog("Mein erster Blogeintrag", "Dies ist mein erster Blogeintrag", "Max Mustermann");
        AddBlog("Mein zweiter Blogeintrag", "Dies ist mein zweiter Blogeintrag", "Max Mustermann");
        AddBlog("Mein dritter Blogeintrag", "Dies ist mein dritter Blogeintrag", "Max Mustermann");
    }
}