namespace nephi2;

class Program
{
    static string secretWord = "Nephi";
    static char[] incorrect = new char[26];
    static char[] playerKnows = new char[26];

    static void Main(string[] args)
    {
        Console.WriteLine("I've chosen a secret word.  Guess it letter by letter!");
        DisplayScreen();

        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'e'
        playerKnows[1] = 'e';
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'f'
        incorrect[0] = 'f';
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'g'
        incorrect[1] = 'g';
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();

        //Player guessed 'i'
        playerKnows[4] = 'i';
        DisplayScreen();
        Console.WriteLine("Hit Enter to continue");
        Console.ReadLine();
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
