using System;

namespace TestExercise1
{
    /*Polecenie:
    Napisz metodę statyczną, która jako argument przyjmuje dowolną tablicę postrzępioną i wyświetla co drugi wiersz z tej tablicy.*/
    public class Program
    {
        private static void Main()
        {
            int[][] table =
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9},
                new[] {10, 11, 12},
                new[] {13, 14, 15},
                new[] {16, 17, 18},
                new[] {19, 20, 21}
            };
            Method(table);
        }
        
        private static void Method(int[][] table)
        {
            for (var x = 0; x < table.Length; x++)
            {
                for (var y = 0; y < table[x].Length; x++)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(table[x][y]);
                    }
                }
            }
        }
    }
}