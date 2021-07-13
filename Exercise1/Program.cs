using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    /*Polecenie:
    Napisz program, który 100-krotnie powtarza losowanie liczby całkowitej z zakresu 1-700,
    a następnie wyświetla najmniejszą spośród wylosowanych liczb oraz informację o tym, ile spośród wylosowanych liczb było większych niż 200.*/
    
    public class Program
    {
        private static void Main()
        {
            var random = new Random();
            List<int> numbers = new();

            for (var i = 0; i < 100; i++)
            { 
                numbers.Add(random.Next(1, 700));
            }
            
            Console.WriteLine($"Najmniejsza liczba to: {numbers.Min()}");
            Console.WriteLine($"Liczb wiekszych od 200 bylo: {numbers.Count(i => i > 200)}");
        }
    }
}