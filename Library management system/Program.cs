using System;

class Program
{
    static Library library = new Library();

    static void Main()
    {
        while (true)
        {
            library.DisplayMenu();

            Console.Write("Choose an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            library.HandleUserChoice(choice);
        }
    }
}
