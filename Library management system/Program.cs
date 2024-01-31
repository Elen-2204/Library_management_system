
using System;
using System.Collections.Generic;

class Program
{
    static List<Book> library = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List All Books");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

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
    }

    static void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string authorName = Console.ReadLine();

        Console.Write("Enter author biography: ");
        string authorBiography = Console.ReadLine();

        Console.Write("Enter category name: ");
        string categoryName = Console.ReadLine();

        Console.Write("Enter category description: ");
        string categoryDescription = Console.ReadLine();

        Console.Write("Enter publication year: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());

        Author author = new Author(authorName, authorBiography);
        Category category = new Category(categoryName, categoryDescription);
        Book book = new Book(title, author, category, year, price);

        library.Add(book);

        Console.WriteLine("Book added successfully!");
    }

    static void RemoveBook()
    {
        Console.Write("Enter the title of the book to remove: ");
        string titleToRemove = Console.ReadLine();

        Book bookToRemove = library.Find(book => book.Title.Equals(titleToRemove, StringComparison.OrdinalIgnoreCase));

        if (bookToRemove != null)
        {
            library.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void ListAllBooks()
    {
        if (library.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in library)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}, Year: {book.Year}, Price: {book.Price:C}");
            }
        }
    }
}
