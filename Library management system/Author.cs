// Author.cs
using System;

class Author
{
    public string Name { get; private set; }
    public string Biography { get; private set; }

    public Author(string name, string biography)
    {
        Name = name;
        Biography = biography;
    }
}
