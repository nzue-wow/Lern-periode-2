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
        static void Main(string[] args)
        {
            InitialisiereFeld();
            startPosition();

            feldzeichen();

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
            for(int y = 0;y < höhe; y++)
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
        }
    }
}

