using System;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionAddClassManager : IActions
    {
        private string _name;
        private byte _minimumAge;
        private double _minimumAverage;
        
        public void Execute()
        {
            Console.WriteLine("Napisz jak ma sie nazywac klasa:");
            _name = Console.ReadLine();
            if (ClassManager.GetClassByName(_name!) != null)
            {
                Console.WriteLine("Podana klasa o tej nazwie juz istnieje!");
                Rejection();
                return;
            }

            if (StudentManager.GetStudentByName(_name) != null)
            {
                Console.WriteLine("Nie mozesz nazwac tak klasy, poniewaz jeden z uczniow ma tak na imie!");
                Rejection();
                return;
            }
            {
                
            }
            do
            {
                Console.WriteLine("Napisz minimalny wiek: ");

                try
                {
                    _minimumAge = byte.Parse(Console.ReadLine()!);
                    if (_minimumAge < 6 | _minimumAge > 25)
                    {
                        Console.WriteLine("Wiek jest za maly lub za duzy!");
                        _minimumAge = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("To nie jest format byte! Przykad: 10");
                }

            } while (_minimumAge < 6 | _minimumAge > 25);

            do
            {
                Console.WriteLine("Napisz minimalna srednia ocen:");
                try
                {
                    _minimumAverage = double.Parse(Console.ReadLine()!);
                    if (_minimumAverage < 1 | _minimumAverage > 6)
                    {
                        Console.WriteLine("Srednia jest za mala lub zbyt duza!");
                        _minimumAverage = 0;
                    }
                }
                catch 
                {
                    Console.WriteLine("To nie jest format double! Przyklad: 5,3");
                }    
            } while (_minimumAverage < 1 | _minimumAverage > 6);
            
            Apply();
        }

        public void Apply()
        {
            Console.WriteLine($"Pomyslnie stworzono klase o nazwie {_name}!");
            ClassManager.AddClass(new ClassModel(_name, _minimumAge, _minimumAverage));
            Rejection();
        }

        public void Rejection()
        {
            Console.WriteLine("Czy chcesz jeszcze raz sprobowac? True/False:");
            bool choice;
            try
            { 
                choice = bool.Parse(Console.ReadLine()!);
            }
            catch
            {
                choice = false;
            }

            if (choice)
            {
                Execute();
            }
            else
            {
                new ActionManager().Rejection();
            }
        }
    }
}