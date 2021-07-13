using BasicallyStudySystem.actions.managers;
using BasicallyStudySystem.groupclass;
using BasicallyStudySystem.student;

namespace BasicallyStudySystem
{
    public class Program
    {
        private static void Main()
        {
            StudentManager.AddStudent(new StudentModel("JOHN", 15, 5.0, null));
            ClassManager.AddClass(new ClassModel("1D", 10, 3.4));
            
            new ActionManager().Execute();
        }
    }
}