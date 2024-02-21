using System;
using System.Collections.Generic;

class Library
{
    private List<Book> books = new List<Book>();
    private int nextBookId = 1; // Initialize the ID for the first book

    public void AddBook(Book book)
    {
        book.Id = nextBookId++; // Assign the next available ID to the book
        books.Add(book);
    }

    public void RemoveBook(int bookId)
    {
        Book bookToRemove = books.Find(book => book.Id == bookId);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void ListAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author.Name}, Year: {book.Year}, Price: {book.Price:C}");
            }
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Remove Book by ID");
        Console.WriteLine("3. List All Books");
        Console.WriteLine("4. Exit");
    }

    public void HandleUserChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                AddBook();
                break;
            case 2:
                RemoveBook();
                break;
            case 3:
                ListAllBooks();
                break;
            case 4:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string authorName = Console.ReadLine();

        Console.Write("Enter author biography: ");
        string authorBiography = Console.ReadLine();

        // Provide a list of predefined categories
        Console.WriteLine("Select a category:");
        Console.WriteLine("1. Fiction");
        Console.WriteLine("2. Non-Fiction");
        Console.WriteLine("3. Mystery");
        Console.WriteLine("4. Science Fiction");
        Console.WriteLine("5. Romance");
        Console.Write("Enter category number: ");
        int categoryChoice = Convert.ToInt32(Console.ReadLine());

        string categoryName = "";
        switch (categoryChoice)
        {
            case 1:
                categoryName = "Fiction";
                break;
            case 2:
                categoryName = "Non-Fiction";
                break;
            case 3:
                categoryName = "Mystery";
                break;
            case 4:
                categoryName = "Science Fiction";
                break;
            case 5:
                categoryName = "Romance";
                break;
            default:
                Console.WriteLine("Invalid category choice. Defaulting to 'Ficiton'.");
                categoryName = "Ficition";
                break;
        }

        Console.Write("Enter category description: ");
        string categoryDescription = Console.ReadLine();

        Console.Write("Enter publication year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Author author = new Author(authorName, authorBiography);
        Category category = new Category(categoryName, categoryDescription);
        Book book = new Book(title, author, category, year, price);

        AddBook(book);

        Console.WriteLine("Book added successfully!");
    }

    private void RemoveBook()
    {
        Console.Write("Enter the ID of the book to remove: ");
        int idToRemove = Convert.ToInt32(Console.ReadLine());

        RemoveBook(idToRemove);
    }
}
