using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int PrevNum = 0;
    string NowMess = "";

    while(true)
    {
      Console.Write("Enter Something: ");
      string UserInput = Console.ReadLine();

      if (UserInput.ToLower() == "exit")
      {
        Console.WriteLine("Closing Program. Goodbye.");
        break;
      }

      if (int.TryParse(UserInput, out int number))
      {
        PrevNum += number;
        Console.WriteLine($"Adding {UserInput} to {PrevNum - number} = {PrevNum}");
      }
      else
      {
        NowMess += UserInput;
        Console.WriteLine($"Current Message is: {NowMess}");
      }
    }
  }
}