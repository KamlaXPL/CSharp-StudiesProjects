using System.Collections.Generic;
using System.Linq;

namespace BasicallyStudySystem.groupclass
{
    public class ClassManager
    {
        private static readonly List<ClassModel> ClassModels = new();
        
        public static void AddClass(ClassModel classModel)
        {
            ClassModels.Add(classModel);
        }

        public static void RemoveClass(ClassModel classModel)
        {
            ClassModels.Remove(classModel);
        }
        
        public static int GetClassesSize()
        {
            return ClassModels.Count;
        }
        
#nullable enable
        public static ClassModel? GetClassByName(string name)
        {
            return ClassModels?.SingleOrDefault(model => model.NameClass.Equals(name));
        }
    }
}