namespace YaelFrankAPILibrary.Entities
{
    public class BookBase
    {

        static private int count = 0;
        public int BookId { get; set; }
        public string Name { get; set; }
        public int NumberOfPages { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}