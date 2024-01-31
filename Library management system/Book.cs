// Book.cs
using System;

class Book
{
    private string title;
    private Author author;
    private Category category;
    private int year;
    private double price;

    public string Title
    {
        get { return title; }
        private set { title = value; }
    }

    public Author Author
    {
        get { return author; }
        private set { author = value; }
    }

    public Category Category
    {
        get { return category; }
        private set { category = value; }
    }

    public int Year
    {
        get { return year; }
        private set { year = value; }
    }

    public double Price
    {
        get { return price; }
        private set { price = value; }
    }

    public Book(string title, Author author, Category category, int year, double price)
    {
        Title = title;
        Author = author;
        Category = category;
        Year = year;
        Price = price;
    }
}
