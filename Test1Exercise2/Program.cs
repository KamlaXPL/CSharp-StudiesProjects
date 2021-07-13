using System;
using System.IO;
using System.Linq;

namespace TestExercise2
{
    /*Polecenie:
    Napisz program, który wczytuje zawartość pliku dane.txt (zamieszczony na Classroom) i wyświetla informację o tym,
    ile w tym pliku jest znaków, które nie są ani małymi ani dużymi literami alfabetu łacińskiego
    (małe litery mają reprezentacje dziesiętne w tablicy ASCII z zakresu 97-122, zaś duże - z zakresu 65-90).*/
    
    public class Program
    {
        private static void Main()
        {
            const string path = @"C:\Users\pablo\RiderProjects\StudiesProjects\Test1Exercise2\dane.txt";
            Console.WriteLine(File.ReadAllText(path).Length - File.ReadAllText(path).Count(c => (c >= 97 & c <= 122) | (c >= 65 & c <= 90)));
        }
    }
}