using System;

namespace Exercise2
{
    /*Polecenie:
    Napisz program, który pobiera od użytkownika łańcuch znaków,
    a następnie wyświetla go w taki sposób, że pierwsza połowa łańcucha znaków jest zapisana dużymi literami, a druga – małymi (np. MANDArynka).*/
    
    public class Program
    {
        private static void Main()
        {
            string word;
            do
            {
                Console.WriteLine("Napisz wyraz powyzej 2 znakow:");
                word = Console.ReadLine();
            } while (word!.Length < 2);
            
            Console.WriteLine($"Otrzymana wiadomosc: {word![..(word.Length / 2)].ToUpper()}{word![(word.Length / 2)..].ToLower()}");
        }
    }
}