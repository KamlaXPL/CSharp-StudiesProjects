using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TestExercise3
{
    /*Polcenie:
    Napisz metodę statyczną, która jako argument przyjmuje tablicę typu string[] oraz ścieżkę do katalogu.
    Z założenia przekazywana jako argument tablica będzie zawierała różne rozszerzenia plików (np. ".txt", ".pdf", ".mp3").
    Zadaniem tworzonej metody jest obliczenie, ile plików w podanym katalogu ma rozszerzenia takie, jak w przekazanej tablicy
    (możesz obliczyć albo liczbę plików dla każdego rozszerzenia z osobna, albo łączną dla wszystkich przekazanych rozszerzeń -
    oba podejścia będą ocenione tak samo). Wynik ma być zapisany w tym katalogu, w pliku o nazwie "raport.txt".
    Wywołaj działanie utworzonej metody dla dowolnych argumentów. */
    public class Program 
    {
        
        private static void Main()
        {
            string[] files = {".txt", ".mp3", ".mp4"};
            Console.WriteLine(GetExtensionsFromDirectory(files, @"C:\Users\pablo\RiderProjects\StudiesProjects\Test1Exercise3"));
        }

        private static int GetExtensionsFromDirectory(string[] files, string directory)
        {
            const string path = @"C:\Users\pablo\RiderProjects\StudiesProjects\Test1Exercise3\raport.txt";
            var size = Directory.GetFiles(directory).Count(path => files.Contains(Path.GetExtension(path)));
            try
            {
                using (var fileStream = File.Create(path))
                {
                    var save = new UTF8Encoding(true).GetBytes($"{DateTime.Now} - Wynik: {size}");
                    fileStream.Write(save, 0, save.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return size;
        }
    }
}