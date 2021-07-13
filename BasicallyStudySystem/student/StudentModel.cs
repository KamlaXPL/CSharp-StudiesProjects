using BasicallyStudySystem.groupclass;

namespace BasicallyStudySystem.student
{
    public class StudentModel
    {
        public StudentModel(string name, byte age, double average, ClassModel classModel)
        {
            Name = name;
            Age = age;
            Average = average;
            ClassModel = classModel;
        }
        
        public string Name { get; }
        public byte Age { get; }
        public double Average { get; }
        public ClassModel ClassModel { get; set; }
    }
}