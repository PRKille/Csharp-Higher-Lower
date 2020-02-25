using System;

public class Game
{
  public int UpperLimit;
  public int LowerLimit;
  public bool KeepPlaying;

  public Game(int upperLimit, int lowerLimit, bool keepPlaying)
  {
    UpperLimit = upperLimit;
    LowerLimit = lowerLimit;
    KeepPlaying = keepPlaying;
  }

  public void changeUpper(int newLimit)
  {
    UpperLimit = newLimit;
  }

  public void changeLower(int newLimit)
  {
    LowerLimit = newLimit+1;
  }
}

public class Program
{
  static void Main()
  {
    Game newGame = new Game(101, 1, true);
    int randomGuess = RandomNum(newGame.LowerLimit, newGame.UpperLimit);
    Console.WriteLine("Choose a number that I'll try and guess!");
    Console.WriteLine("Respond higher/lower/correct, press return when ready!");
    Console.ReadLine();
    while (newGame.KeepPlaying && newGame.LowerLimit < newGame.UpperLimit)
    {
      Console.WriteLine(randomGuess);
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "correct")
      {
        newGame.KeepPlaying = false;
      }
      else if (userResponse.ToLower() == "lower")
      {
        newGame.changeUpper(randomGuess);
        randomGuess = RandomNum(newGame.LowerLimit, newGame.UpperLimit);
      }
      else if (userResponse.ToLower() == "higher")
      {
        newGame.changeLower(randomGuess);
        randomGuess = RandomNum(newGame.LowerLimit, newGame.UpperLimit);
      }
    }
    if (newGame.LowerLimit >= newGame.UpperLimit)
    {
      Console.WriteLine("Stop Lying!");
    }
    Console.WriteLine("Do you want to play again? y/n");
    string playAgain = Console.ReadLine().ToLower();
    if (playAgain == "y")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Thank you for playing!");
    }
  }

  static int RandomNum(int lowerLimit, int upperLimit)
  {
    Random rnd = new Random();
    int index = rnd.Next(lowerLimit, upperLimit);
    return index;
  }
}