namespace FaceBlog.Lib
{
    //Klasse Blog erstellen mit Properties
    public record Blog(string Title, string Text, string Author)
    {
        private DateTime timestamp;
        public DateTime TimeStamp
        {
            get
            {
                return timestamp;
            }
            init
            {
                timestamp = DateTime.Now;
            }
        }
    }
}