using System;

class Program
{
    static string GetUserInput(string word)
    {
        string message = $"Please enter a {word}:";
        Console.WriteLine(message);
        string text = Console.ReadLine();
        return text;
    }

    static void Main()
    {
        // we can set word to "name," "value," or any other word, and the message will be adjusted accordingly.
        Console.Write("Enter an argument word: ");
        string chosenWord = Console.ReadLine();

        string enteredText = GetUserInput(chosenWord);
        Console.WriteLine($"You entered: {enteredText}");
    }
}
