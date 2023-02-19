namespace TicTacToe
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      printBoard();
      playGame();
    }

    static string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    static void printBoard()
    {
      Console.WriteLine("---------TIC TAC TOE---------");
      Console.WriteLine();
      Console.WriteLine("    {0}    |    {1}    |    {2}", pos[1], pos[2], pos[3]);
      Console.WriteLine("-----------------------------");
      Console.WriteLine("    {0}    |    {1}    |    {2}", pos[4], pos[5], pos[6]);
      Console.WriteLine("-----------------------------");
      Console.WriteLine("    {0}    |    {1}    |    {2}", pos[7], pos[8], pos[9]);
      Console.WriteLine();
    }

    static int turn = 1;
    static bool isPlaying = true;

    static void playGame()
    {
      int choice;
      while (isPlaying == true)
      {
        if (turn == 1)
        {
          Console.WriteLine("Choose your position Player #1");
        }
        else
        {
          Console.WriteLine("Choose your position Player #2");
        }

        choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= 10)
        {
          if (pos[choice] != "X" && pos[choice] != "O")
          {
            if (turn == 1)
            {
              pos[choice] = "X";
              turn = 2;
            }
            else
            {
              pos[choice] = "O";
              turn = 1;
            }
            Console.Clear();
            printBoard();
            checkWinner();
          }
          else
          {
            Console.Clear();
            printBoard();
          }
        }
        else
        {
          Console.Clear();
          printBoard();
        }
      }
    }

    static int checkPlays()
    {
      if (pos[1] == pos[2] && pos[2] == pos[3])
      {
        return 1;
      }
      else if (pos[4] == pos[5] && pos[5] == pos[6])
      {
        return 1;
      }
      else if (pos[6] == pos[7] && pos[7] == pos[8])
      {
        return 1;
      }
      else if (pos[1] == pos[4] && pos[4] == pos[7])
      {
        return 1;
      }
      else if (pos[2] == pos[5] && pos[5] == pos[8])
      {
        return 1;
      }
      else if (pos[3] == pos[6] && pos[6] == pos[9])
      {
        return 1;
      }
      else if (pos[1] == pos[5] && pos[5] == pos[9])
      {
        return 1;
      }
      else if (pos[3] == pos[5] && pos[5] == pos[7])
      {
        return 1;
      }
      else if (pos[1] != "1" && pos[2] != "2" && pos[3] != "3" && pos[4] != "4" && pos[5] != "5" && pos[6] != "6" && pos[7] != "7" && pos[8] != "8" && pos[9] != "9")
      {
        return 2;
      }
      else
      {
        return 0;
      }
    }

    static void checkWinner()
    {
      int win;
      win = checkPlays();
      if (win == 1 && turn == 2)
      {
        Console.WriteLine("Winner Player #1");
        isPlaying = false;
      }
      else if (win == 1 && turn == 1)
      {
        Console.WriteLine("Winner Player #2");
        isPlaying = false;
      }
      else if (win == 2)
      {
        Console.WriteLine("Draw");
        isPlaying = false;
      }
    }
  }
}
