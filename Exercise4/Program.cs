using System;

namespace Exercise4
{
    /*Polecenie:
    Utwórz w programie metodę statyczną FragmentTekstu, która jako parametry przyjmuje dwie liczby całkowite (a,b)
    oraz napis (nap) i zwraca łańcuch znaków, będący podłańcuchem od nap[a] do nap[b]. Zakładamy dla uproszczenia, że a<b i że nap.Length>b.
    Z poziomu metody Main wywołaj następującą instrukcję:

    Console.WriteLine(FragmentTekstu(0,3,"Program"))

    Powinien wyświetlić się napis "pro".*/


    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(FragmentTekstu(0, 3, "Program"));
        }

        private static string FragmentTekstu(int a, int b, string nap)
        {
            return nap.Substring(a, b).ToLower();
        }
    }
}