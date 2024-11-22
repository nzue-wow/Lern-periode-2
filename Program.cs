using System;
using System.Collections.Generic;
using System.Threading;

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
        static int neueRichtungX = 1; 
        static int neueRichtungY = 0;
        static bool spielLäuft = true;
        static Random random = new Random();
        static (int x, int y) apfel;

        static void Main(string[] args)
        {
            do
            {
                NeuesSpiel();
            } while (MöchtestDuNochmalsSpielen());

            Console.WriteLine("Danke fürs Spielen!");
        }

        static void NeuesSpiel()
        {
            Console.Clear();
            Console.CursorVisible = false;

            // Spielfeld initialisieren und Startwerte setzen
            InitialisiereFeld();
            startPosition();
            NeuerApfel();

            Thread inputThread = new Thread(LeseEingabe);
            inputThread.Start();

            spielLäuft = true;
            while (spielLäuft)
            {
                feldzeichen();
                AktualisiereRichtung();
                schlangeBewegen();
                Thread.Sleep(10);
            }

            inputThread.Join();
        }

        static void NeuerApfel()
        {
            int x, y;
            do
            {
                x = random.Next(1, breite - 1);
                y = random.Next(1, höhe - 1);
            } while (Feld[x, y] != ' '); // sicherstellen das Platz frei ist

            apfel = (x, y);
            Feld[x, y] = 'O';
        }

        static bool MöchtestDuNochmalsSpielen()
        {
            Console.Clear();
            Console.WriteLine("Game Over! Möchtest du nochmals spielen? (y/n)");
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Y) return true;
                if (key == ConsoleKey.N) return false;
            }
        }

        static void LeseEingabe()
        {
            while (spielLäuft)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(intercept: true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            if (richtungY != 1) { neueRichtungX = 0; neueRichtungY = -1; }
                            break;

                        case ConsoleKey.DownArrow:
                            if (richtungY != -1) { neueRichtungX = 0; neueRichtungY = 1; }
                            break;

                        case ConsoleKey.LeftArrow:
                            if (richtungX != 1) { neueRichtungX = -1; neueRichtungY = 0; }
                            break;

                        case ConsoleKey.RightArrow:
                            if (richtungX != -1) { neueRichtungX = 1; neueRichtungY = 0; }
                            break;
                    }
                }
            }
        }

        static void AktualisiereRichtung()
        {
            richtungX = neueRichtungX;
            richtungY = neueRichtungY;
        }

        static void InitialisiereFeld()
        {
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
            snake.Clear();
            int startX = breite / 2;
            int startY = höhe / 2;
            snake.Add((startX, startY));
            Feld[startX, startY] = '>';
        }

        static void feldzeichen()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < höhe; y++)
            {
                for (int x = 0; x < breite; x++)
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

            // Fährt Schlange in die Wand onder isch selbst?
            if (neuX <= 0 || neuX >= breite - 1 || neuY <= 0 || neuY >= höhe - 1 || snake.Contains((neuX, neuY)))
            {
                spielLäuft = false;
                return;
            }

            // Neuer Kopf
            snake.Insert(0, (neuX, neuY));

            if (neuX == apfel.x && neuY == apfel.y)
            {
                
                NeuerApfel(); // Neuen Apfel
            }
            else
            {
                // Schlange gleichlang behalten
                var schwanz = snake[snake.Count - 1];
                Feld[schwanz.x, schwanz.y] = ' ';
                snake.RemoveAt(snake.Count - 1);
            }

            // Zeichne die Schlange
            foreach (var segment in snake)
            {
                Feld[segment.x, segment.y] = '-';
            }

            
            Feld[neuX, neuY] = KopfSymbol();
        }

        static char KopfSymbol()
        {
            if (richtungX == 1) return '>'; // rechts
            if (richtungX == -1) return '<'; // links
            if (richtungY == -1) return '^'; // oben
            if (richtungY == 1) return 'v'; // unten
            return '>';
        }
    }
}

