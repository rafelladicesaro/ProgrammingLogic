class Book
{
    private string title;
    private string author;

    public Book()   // Default Constrcutor
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    public Book (string t)  // Parameterized Constructor
    {
        title = t;
        author = "Unknown Author";
    }
    public Book (string t, string auth)  // Overloaded Parameterized Constructor
    {
        title = t;
        author = auth;
    }

    //Book methods
    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Create a Class with a Default Constructor
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  // Output: Unknown Title

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());  // Output: C# Fundamentals

        // Problem 2:  Add a Parameterized Constructor
        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle()); // Output: Advanced C#

        // Problem 3: Constructor Overloading
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());    //Output: Title: Advanced C#
        Console.WriteLine("Author: " + book3.GetAuthor());  //Output: Author: John Doe

        // Problem 4: Update Fields Using Setter Methods
        Book book4 = new Book("Old Title", "Old Author");
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");

        Console.WriteLine("Title: " + book4.GetTitle());    // Output: Title: Mastering C#
        Console.WriteLine("Author: " + book4.GetAuthor());  // Output: Author: Jane Smith
    }
}