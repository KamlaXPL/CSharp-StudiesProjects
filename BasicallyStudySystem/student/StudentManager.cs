using System;
using System.Collections.Generic;
using System.Linq;
using BasicallyStudySystem.groupclass;

namespace BasicallyStudySystem.student
{
    public class StudentManager
    {
        private static readonly List<StudentModel> StudentModels = new();
        
        public static void AddStudent(StudentModel studentModel)
        {
            StudentModels.Add(studentModel);
        }

        public static void RemoveStudent(StudentModel studentModel)
        {
            StudentModels.Remove(studentModel);
        }

        public static int GetStudentsSize()
        {
            return StudentModels.Count;
        }

#nullable enable
        public static StudentModel? GetStudentByName(string name)
        {
            return StudentModels?.SingleOrDefault(student => student.Name.Equals(name));
        }
        public static bool CanJoinToClass(StudentModel studentModel, ClassModel classModel)
        {
            return studentModel.Age >= classModel.MinimumAge & studentModel.Average >= classModel.MinimumAverage;
        }
    }
}