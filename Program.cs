namespace Snakespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int breite = 110;  // Spielfeldbreite (innen)
            int höhe = 25;  // Spielfeldhöhe (innen)

            string feld = Spielfeld(breite, höhe);
            Console.WriteLine(feld);
            Console.ReadKey();
        }

        static string Spielfeld(int breite, int höhe)
        {
            string obenFeld = new string('-', breite + 2);
            string mitteFeld = "|" + new string(' ', breite) + "|";

            // Zusammensetzen des Spielfeldes
            string feld = obenFeld + "\n";
            for (int i = 0; i < höhe; i++)
            {
                feld += mitteFeld + "\n";
            }
            feld += obenFeld;

            return feld;

            //Wie bewegt sich die schlange
        }
    }
}
        
