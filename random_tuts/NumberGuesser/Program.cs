using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {

      getAppInfo();
      string inputName = greetUser();



      while (true) { 

        int guess = 0;

        Random random = new Random();
        int correctNumber = random.Next(1, 10);

        Console.WriteLine("Guess a number 1-10");

        while (guess != correctNumber)
        {
          string input = Console.ReadLine();

          if (!int.TryParse(input, out guess))
          {
            printColorMessage(ConsoleColor.Red, "-- You must enter a number --");
            continue;
          }


          guess = Int32.Parse(input);

          if (guess != correctNumber)
          {
            printColorMessage(ConsoleColor.Red, "Wrong number please try again...");
          }

        }

        printColorMessage(ConsoleColor.Yellow, "Well played");

        Console.WriteLine("Play again? [Y or N]");
        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
          continue;
        }
        else if (answer == "N")
        {
          return;
        }

      }

    }


    public static void getAppInfo()
    {
      string appName = "Number Guesser";
      string appVersion = "1.0.0";
      string appAuthor = "Brad Traversy";

      string infoString = $"{appName}: Version {appVersion} by {appAuthor}";

      printColorMessage(ConsoleColor.Green, infoString);
    }

    public static string greetUser()
    {
      Console.WriteLine("What is your name?");
      string inputName = Console.ReadLine();
      Console.WriteLine("Hello {0}, let's play a game...", inputName);
      return inputName;
    }

    public static void printColorMessage(ConsoleColor color, string message)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(message);
      Console.ResetColor();
    }

  }
}
