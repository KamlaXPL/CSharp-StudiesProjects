using System;
using System.Linq;

namespace Exercise3
{
    /*Polecenie:
    Napisz metodę PozycjaZnaku(), będącą alternatywą do metody IndexOf(), zakładając,
    że jako argumenty do tej metody mogą być przekazane jedynie: przeszukiwany łańcuch znaków i pojedynczy znak - char.

    Przykład:
    PozycjaZnaku("programowanie",'o') zwróci wartość 2
    PozycjaZnaku("programowanie",'x') zwróci wartość 0*/
    
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Napisz wyraz: ");
            var word = Console.ReadLine();
            Console.WriteLine("Napisz szukany znak: ");
            var character = char.Parse(Console.ReadLine()!);
            Console.WriteLine($"W wyrazie znajduje sie: {PozycjaZnaku(word, character)} znakow {word}!");
        }

        private static int PozycjaZnaku(string word, char character)
        {
            return word.Count(c => c == character);
        }
    }
}