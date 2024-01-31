// Category.cs
using System;

sealed class Category
{
    public string CategoryName { get; private set; }
    public string Description { get; private set; }

    public Category(string categoryName, string description)
    {
        CategoryName = categoryName;
        Description = description;
    }
}
