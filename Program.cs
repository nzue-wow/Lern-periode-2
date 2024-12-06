namespace Advent_code1
{
    using System;
    using System.Linq;

    class HistorianHysteria
    {
        public static int CalculateTotalDistance(int[] leftList, int[] rightList)
        {
            /*
           
                leftList (int[]): The list of location IDs from the left group.
                rightList (int[]): The list of location IDs from the right group.

            */

            // Sortieren der Listen
            var leftSorted = leftList.OrderBy(x => x).ToArray();
            var rightSorted = rightList.OrderBy(x => x).ToArray();

            // Berechne gesamt distanz
            int totalDistance = 0;
            for (int i = 0; i < leftSorted.Length; i++)
            {
                totalDistance += Math.Abs(leftSorted[i] - rightSorted[i]);
            }

            return totalDistance;
        }

        public static void Main(string[] args)
        {
            int[] leftList = { 3, 4, 2, 1, 3, 3 };
            int[] rightList = { 4, 3, 5, 3, 9, 3 };
            
            int result = CalculateTotalDistance(leftList, rightList);
            Console.WriteLine($"Total distance: {result}");
        }
    }

}
    

