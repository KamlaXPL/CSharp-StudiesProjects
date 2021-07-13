using System;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionRemoveManager : IActions
    {
        private StudentModel _studentModel;
        private ClassModel _classModel;
        
        public void Execute()
        {
            Console.WriteLine("Podaj imie ucznia lub klase, ktora chcesz usunac: ");
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
                Console.WriteLine($"Pomyslnie usunieto ucznia o imieniu: {_studentModel.Name}");
                StudentManager.RemoveStudent(_studentModel);
            }
            else
            {
                Console.WriteLine($"Pomyslnie usunieto klase o nazwie: {_classModel.NameClass}");
                ClassManager.RemoveClass(_classModel);
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