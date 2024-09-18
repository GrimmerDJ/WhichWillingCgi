using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your message:");

        string message = Console.ReadLine();

        int messageLength = message.Length;

        if (messageLength <= 140)
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected");
        }

        Console.WriteLine("Message length: " + messageLength + " characters.");
    }
}