using System;
using System.IO;
using System.Text;

namespace Exercise5
{
    /*Polecenie:
    Napisz program będący symulatorem obliczania wyników referendum, zgodnie z wytycznymi:
    Program zawiera metodę statyczną, zadaniem metody jest "ogłoszenie" wyników referendum poprzez wyświetlenie informacji:
    która opcja wygrała ("za" czy "przeciw") i jaki jest procentowy podział głosów (np. 42% "za", 58% "przeciw").
    Oprócz wyświetlenia wyników metoda ma je zapisać do pliku tekstowego o nazwie "protokol.txt",
    który znajdzie się w dowolnej lokalizacji (ścieżkę możesz podać wprost w kodzie programu).
    Z poziomu metody Main wywołaj działanie utworzonej metody dla przykładowej tablicy.*/
    
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine(GetReferendum(100, 20));
        }

        private static string GetReferendum(int per, int against)
        {
            var total = per + against;
            var percentagePer = (int) Math.Round((double) (100 * per) / total);
            var percentageAgainst = (int)Math.Round((double)(100 * against) / total);

            var win = per > against ? "ZA" : per == against ? "REMIS" : "PRZECIW";

            var message = $"Referendum wygrywa opcja: {win}! Za: {per} ({percentagePer}%), Przeciw: {against} ({percentageAgainst}%)";
            
            //creating file and save
            const string path = @"C:\Users\pablo\RiderProjects\StudiesProjects\Exercise5\Referendum.txt";
            try
            {
                using (var fileStream = File.Create(path))
                {
                    var save = new UTF8Encoding(true).GetBytes($"{DateTime.Now} - {message}");
                    fileStream.Write(save, 0, save.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            return message;
        }
    }
}