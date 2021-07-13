using System;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionSearchManager : IActions
    {
        private StudentModel _studentModel;
        private ClassModel _classModel;
        
        public void Execute()
        {
            Console.WriteLine("Podaj imie ucznia lub nazwe klasy: "); 
            var nameObject = Console.ReadLine(); 
            _studentModel = StudentManager.GetStudentByName(nameObject!);
            _classModel = ClassManager.GetClassByName(nameObject);
            if (_studentModel != null | _classModel != null)
            {
                Apply();
            }
            else
            {
                Console.WriteLine("Nieodnaleziono zadnego ucznia ani klasy o podanej wartosci!");
                Rejection();
            }
        }

        public void Apply()
        {
            if (_studentModel != null)
            {
                Console.WriteLine($"Imie: {_studentModel.Name}");
                Console.WriteLine($"Wiek: {_studentModel.Age}");
                Console.WriteLine($"Srednia ocen: {_studentModel.Average}");
                Console.WriteLine("Informacje o klasie ucznia:");
                if (_studentModel.ClassModel == null)
                {
                    Console.WriteLine(" Brak informacji o klasie.");
                }
                else
                { 
                    _classModel = _studentModel.ClassModel;
                    Console.WriteLine($" Nazwa: {_classModel.NameClass}");
                    Console.WriteLine($" Minimalny wiek: {_classModel.MinimumAge}");
                    Console.WriteLine($" Minimalna srednia: {_classModel.MinimumAverage}");
                }
            }
            else
            {
                Console.WriteLine($"Nazwa: {_classModel.NameClass}");
                Console.WriteLine($"Minimalny wiek: {_classModel.MinimumAge}");
                Console.WriteLine($"Minimalna srednia: {_classModel.MinimumAverage}");
            }
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