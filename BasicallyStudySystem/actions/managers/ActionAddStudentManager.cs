using System;
using System.Threading;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionAddManager : IActions
    {
        private string _name;
        private byte _age;
        private double _average;
        private ClassModel _classModel;
        public void Execute()
        {
            Console.WriteLine("Napisz jak ma na imie uczen:");
            _name = Console.ReadLine();
            if (ClassManager.GetClassByName(_name!) != null)
            {
                Console.WriteLine("Nie mozesz tak nazwac ucznia, poniewaz taka nazwe ma jedna z klas!");
                Rejection();
                return;
            }
            do
            {
                Console.WriteLine("Napisz wiek ucznia: ");

                try
                {
                    _age = byte.Parse(Console.ReadLine()!);
                    if (_age < 6 | _age > 25)
                    {
                        Console.WriteLine("Wiek jest za maly lub za duzy!");
                        _age = 0;
                    }
                }
                catch
                {
                    Console.WriteLine("To nie jest format byte! Przykad: 10");
                }

            } while (_age < 6 | _age > 25);

            do
            {
                Console.WriteLine("Napisz srednia ocen ucznia:");
                try
                {
                    _average = double.Parse(Console.ReadLine()!);
                    if (_average < 1 | _average > 6)
                    {
                        Console.WriteLine("Srednia jest za mala lub zbyt duza!");
                        _average = 0;
                    }
                }
                catch 
                {
                    Console.WriteLine("To nie jest format double! Przyklad: 5,3");
                }    
            } while (_average < 1 | _average > 6);
            
            do
            {
                Console.WriteLine("Napisz nazwe klasy do jakiej uczen chce uczesczac: ");
                _classModel = ClassManager.GetClassByName(Console.ReadLine()!);
                if (_classModel == null)
                {
                    Console.WriteLine("Nie ma takiej klasy!");
                }
            } while (_classModel == null);
            
            StudentManager.AddStudent(new StudentModel(_name, _age, _average, null));
            var studentModel = StudentManager.GetStudentByName(_name!);
            if (StudentManager.CanJoinToClass(studentModel!, _classModel))
            {
                Apply();
            }
            else
            {
                Rejection();
            }
        }

        public void Apply()
        {
            var studentModel = StudentManager.GetStudentByName(_name);
            studentModel!.ClassModel = _classModel;
            Console.WriteLine($"Brawo! Uczen {_name} dostal sie do klasy {_classModel.NameClass}! ");
        }

        public void Rejection()
        {
            Console.WriteLine($"Niestety, ale uczen {_name} nie spelnia warunkow, aby dostac sie do klasy {_classModel.NameClass}!");
            Console.WriteLine($"Aby dostac sie do klasy, uczen musi posiadac minimum {_classModel.MinimumAge} lat oraz srednia powyzej {_classModel.MinimumAverage}!");
            
            new ActionManager().Rejection();
        }
    }
}