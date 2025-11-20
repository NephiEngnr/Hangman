namespace nephi2;

class Program
{
    static char guessCharacter;
    static string secretWord = "microwave";
    static char[] incorrect = new char[26];
    static char[] playerKnows = new char[secretWord.Length];

    static void Main(string[] args)
    {
        while (true)
        {
        DisplayScreen();
        UserInteraction();
        GradeGuess();
            if (IsGameWon() == true)
            {
                DisplayScreen();
                Console.WriteLine("Congrats! You won!");
                break;
            }
            if (IsGameLost())
            {
                DisplayScreen();
                Console.WriteLine("Sorry, you lost.");
                Console.Write($"Answer was : ");
                setGreen();
                Console.WriteLine(secretWord);
                resetColor();
                break;
            }
        }
    }
    static bool IsGameWon()
    {

        string pkString = new string(playerKnows);
        if (secretWord == pkString)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool IsGameLost()
    {
        for (int y = 0; y < 8; y++)
        {
            if (incorrect[y] == 0) return false;
        }
        return true;
    }
    static void UserInteraction()
    {
        Console.WriteLine("Enter a letter");
        guessCharacter = Console.ReadKey().KeyChar;
    }
    static void GradeGuess()
    {
        bool nothingMatches = true;
        int i = 0;
        foreach (char x in secretWord)
        {
            if (x == guessCharacter)
            {
                playerKnows[i] = guessCharacter;
                nothingMatches = false;
            }
            i++;
        }
        if (nothingMatches)
        {
            for(int j = 0; j <= incorrect.Length; j++)
            {
                if(incorrect[j] == 0)
                {
                    incorrect[j] = guessCharacter;
                    break;
                }
            }
        }
    }

    static void DisplayScreen()
    {
        Console.Clear();
        //Line1
        Console.WriteLine("-----------------------------------------------------------------");
        //Line2
        Console.WriteLine("Guess My Secret!");
        //Line3
        //foreach (char x in secretWord)
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (playerKnows[i] == 0)
            {
                Console.Write('_');
            }
            else
            {
                setGreen();
                Console.Write(playerKnows[i]);
                resetColor();
            }
        }
        Console.WriteLine();
        //Line4
        for (int x = 0; x <= 7; x++)
        {
            if (incorrect[x] == 0)
            {
                Console.Write('_');
            }
            else
            {
                setRed();
                Console.Write(incorrect[x]);
                resetColor();
            }
        }
        Console.WriteLine();
    }
    static void setRed()
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    static void resetColor()
    {
        Console.ResetColor();
    }
    static void setGreen()
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
}
