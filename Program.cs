namespace nephi2;

class Program
{
    static char guessCharacter;
    static string secretWord = "Zootopia";
    static char[] incorrect = new char[26];
    static char[] playerKnows = new char[26];

    static void Main(string[] args)
    {
        Console.WriteLine("I've chosen a secret word.  Guess it letter by letter!");
        DisplayScreen();

        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'e'
        GradeGuess();
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'f'
        GradeGuess();
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'g'
        GradeGuess();
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'i'
        GradeGuess();
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();
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
            for(int j = 0; j < incorrect.Length; j++)
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
        for (int x = 0; x < 7; x++)
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

        //Line5


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
