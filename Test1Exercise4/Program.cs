using System;

namespace TestExercise4
{
    /*Polcenie:
    Poniżej utworzono zmienną tekstową, która zawiera rozdzielone przecinkiem nazwy kolejnych stacji na trasie pewnego pociągu.
    Napisz metodę statyczną, która przyjmuje trzy argumenty:
    - zmienną tekstową z rozkładem jazdy (o konstrukcji podobnej do poniższej - na potrzeby testów wykorzystaj zmienną, która jest utworzona poniżej)
    - nazwę stacji A (string)
    - nazwę stacji B (string).

    Zadaniem metody ma być wyświetlenie w kolejnych liniach na konsolii wszystkich nazw stacji między stacją A a stacją B (bez nazw stacji A i B).
    Dla uproszczenia załóż, że argumenty zostaną przekazane do metody w takiej kolejności,
    że stacja A w rozkładzie znajduje się przed stacją B oraz że obie stacje rzeczywiście znajdują się w rozkładzie.*/
    
    public class Program
    {
        private static void Main()
        {
            const string timetable = "Racibórz,Racibórz Markowice,Nędza,Kuźnia Raciborska,Dziergowice,Bierawa,Kędzierzyn-Koźle Azoty,Sławięcice,Kędzierzyn-Koźle,Raszowa,Zdzieszowice,Jasiona,Gogolin,Przywory Opolskie,Opole Grotowice,Opole Groszowice,Opole Główne,Opole Zachodnie,Chróścina Opolska,Dąbrowa Niemodlińska,Przecza,Lewin Brzeski,Łosiów,Brzeg,Lipki,Oława,Lizawice,Zębice Wrocławskie,Święta Katarzyna,Wrocław Brochów,Wrocław Główny";
            Console.WriteLine("Podaj stacje poczatkowa:");
            var startingStation = Console.ReadLine();
            Console.WriteLine("Podaj stacje koncowa:");
            var finalStation = Console.ReadLine();
            Console.WriteLine($"Stacje, ktore bedziesz mijal: {GetBetweenStations(timetable, startingStation, finalStation)}");
        }

        private static string GetBetweenStations(string timetable, string startingStation, string finalStation)
        {
            var startStation = timetable.IndexOf(startingStation) + startingStation.Length;
            var endStation = timetable.IndexOf(finalStation, startStation);
            
            return timetable.Substring(startStation + 1, endStation - startStation - 2);
        }
    }
}