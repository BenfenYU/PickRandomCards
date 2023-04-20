// See https://aka.ms/new-console-template for more information
using PickRandomCards;

Console.WriteLine("Hello, World!");

while (true)
{
    Console.Write("Enter the number of cards to pick: ");
    string line = Console.ReadLine();

    if (int.TryParse(line, out int numberOfCards))
    {
        foreach (string s in CardPicker.PickSomeCards(numberOfCards))
        {
            Console.WriteLine(s);
        }
    }
    else
    {
        Console.WriteLine("invalid input!");
    }
}
