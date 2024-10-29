
public class Latihan2
{
    public static void main()
    {
        IBookShelf obj = new BookShelfImplement();
        obj.insertNewbook(new Book("Malin Kundang", "Sherly mendoza"));
        obj.insertNewbook(new Book("Naga Bonar", "Kakashi"));

        obj.pushDataBook(new Book("Buto ijo", "Hiruzen"));

        Console.WriteLine("Menampilkan data buku saat ini");
        obj.print();

        Console.Write("Data buku yang diambil ");
        Console.WriteLine("Judul buku " + obj.peekDataBook().Title + " " + "Author " + obj.peekDataBook().Author);
        
        obj.popDataBook();

        obj.print();
    }
}

class Book
{
    public string Title{get; set;}
    public string Author{get; set;}
    public Book(string title, string author)
    {
        this.Title = title;
        this.Author = author;
    }
    public Book()
    {

    }
}

interface IBookShelf
{
    Book dataBook{get; set;}
    void insertNewbook(Book book);
    void pushDataBook(Book book);
    void popDataBook();
    Book peekDataBook();
    void print();
}

class BookShelfImplement : IBookShelf
{
    public BookShelfImplement head;
    public BookShelfImplement top;
    public Book dataBook{get; set;}
    public BookShelfImplement()
    {
        this.head = null;
        this.top  = null;
        this.dataBook = new Book();
    }

    public void insertNewbook(Book book)
    {
        BookShelfImplement newData = new BookShelfImplement();
        newData.dataBook = book;

        if (this.head == null)
        {
            newData.top = null;
            this.head = newData;
            return;
        }

        newData.top = this.head;
        this.head = newData;
    }

    public void pushDataBook(Book book)
    {
        BookShelfImplement newData = new BookShelfImplement();
        newData.dataBook = book;

        BookShelfImplement temp = this.head;

        while (temp.top != null)
        {
            temp = temp.top;
        }

        newData.top = null;
        temp.top = newData;
    }
    public void popDataBook()
    {
        BookShelfImplement temp = this.head;

        while (temp.top.top != null)
        {
            temp = temp.top;
        }
        temp.top = null;

    }
    public Book peekDataBook()
    {
        BookShelfImplement temp = this.head;

        while (temp.top != null)
        {
            temp = temp.top;
        }

        Book isBook = temp.dataBook;

        return isBook;
    }
    public void print()
    {
        BookShelfImplement temp = this.head;

        while (temp != null)
        {
            Console.WriteLine("Judul buku " + temp.dataBook.Title + "\n" + "Penulis " + temp.dataBook.Author);
            temp = temp.top;
        }
    }
}