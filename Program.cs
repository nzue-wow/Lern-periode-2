using System.Xml.Linq;

namespace Snakespiel
{
    internal class Program
    {
        static int breite = 110;
        static int höhe = 25;
        static char[,] Feld = new char[breite, höhe];
        static List<(int x, int y)> snake = new List<(int x, int y)>();
        static int richtungX = 1;
        static int richtungY = 0;
        static bool spielLäuft = true;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            InitialisiereFeld();
            startPosition();

            while (spielLäuft)
            {
                feldzeichen();
                schlangeBewegen();
                TastenKontrolle();
            }
           

        }

        static void InitialisiereFeld()
        {
            // Füllen des Spielfeldes mit Rändern und leerem Innenbereich
            for (int y = 0; y < höhe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    if (y == 0 || y == höhe - 1)
                        Feld[x, y] = '-';
                    else if (x == 0 || x == breite - 1)
                        Feld[x, y] = '|';
                    else
                        Feld[x, y] = ' ';
                }
            }
           
        }



        static void startPosition()
        {
            //Start position der schlange
            int startX = breite / 2;
            int startY = höhe / 2;
            snake.Add((startX, startY));
            Feld[startX, startY] = '>';
        }

        static void feldzeichen()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0;y < höhe; y++)
            {
                for(int x = 0;x < breite; x++)
                {
                    Console.Write(Feld[x, y]);
                }
                Console.WriteLine();
            }
        }

        static void schlangeBewegen()
        {
            int neuX = snake[0].x + richtungX;
            int neuY = snake[0].y + richtungY;

            if (neuX <= 0 || neuX >= breite - 1 || neuY <= 0 || neuY >= höhe - 1)
            {
                spielLäuft = false;
                Console.Clear();
                Console.WriteLine("Game Over");
                return;
            }

            // Neuer Kopf
            Feld[snake[0].x, snake[0].y] = '-';
            snake.Insert(0, (neuX, neuY));
            Feld[neuX, neuY] = KopfSymbol();

            // Schwanz entfernen für eine gleiche länge der Schlange
            var schwanz = snake[snake.Count - 1];
            Feld[schwanz.x, schwanz.y] = ' ';
            snake.RemoveAt(snake.Count - 1);
        }

        static void TastenKontrolle()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(intercept: true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (richtungY == 0) { richtungX = 0; richtungY = -1; }
                        break;

                    case ConsoleKey.DownArrow:
                        if (richtungY == 0) { richtungX = 0; richtungY = 1; }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (richtungY == 0) { richtungX = -1; richtungY = 0; }
                        break;

                    case ConsoleKey.RightArrow:
                        if (richtungY == 0) { richtungX = 1; richtungY = 0; }
                        break;
                }
            }
        }

        static char KopfSymbol()
        {
            if (richtungX == 1) return '>'; // rechts
            if (richtungX == -1) return '<'; // links
            if (richtungY == -1) return '^'; // oben
            if (richtungY == 1) return 'v'; //unten
            return '>';
        }
    }
}

