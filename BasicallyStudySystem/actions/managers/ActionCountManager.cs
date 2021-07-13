using System;
using System.Threading;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem.actions.managers
{
    public class ActionCountManager : IActions
    {
        public void Execute()
        {
            Console.WriteLine($"Wszystkich uczniow: {StudentManager.GetStudentsSize()}");
            Console.WriteLine($"Wszystkich klas: {ClassManager.GetClassesSize()}");
            Apply();
        }

        public void Apply()
        {
            Thread.Sleep(1000);
            new ActionManager().Execute();
        }

        public void Rejection()
        {
            throw new NotImplementedException();
        }
    }
}