using System;

class Book
{
    public int Id { get; set; }
    public string Title { get; private set; }
    public Author Author { get; private set; }
    public Category Category { get; private set; }
    public int Year { get; private set; }
    public double Price { get; private set; }

    public Book(string title, Author author, Category category, int year, double price)
    {
        Title = title;
        Author = author;
        Category = category;
        Year = year;
        Price = price;
    }
}
