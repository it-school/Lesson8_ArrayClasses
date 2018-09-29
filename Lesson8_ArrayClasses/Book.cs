namespace Lesson8_ArrayClasses
{
    class Book
    {
        string title;
        string[] authors;
        string publisher;
        uint pages;

        public Book()
        {
            this.title = "Unknown";
            this.authors = new string[] {"Unknown"};
            this.publisher = "Publisher";
            Pages = 100;
        }

        public Book(string title, string[] authors, string publisher, uint pages)
        {
            this.title = title;
            this.authors = authors;
            this.publisher = publisher;
            Pages = pages;
        }

        public string Title { get => title; set => title = value; }
        public string[] Authors { get => authors; set => authors = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public uint Pages { get => pages; set => pages = (value > 2000 ? 2000 : value); }

        public override string ToString()
        {
            string authors = "";
            foreach (string item in Authors)
                authors += item + '\n';

            return  $"Book:\nTitle:{this.title}\nAuthors:{authors}\nPublisher:" +
                    $"{this.publisher}\nPages:{this.pages}";
        }
    }
}
