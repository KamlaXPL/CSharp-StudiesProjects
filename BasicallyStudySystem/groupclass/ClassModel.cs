namespace BasicallyStudySystem.groupclass
{
    public class ClassModel
    {
        public ClassModel(string nameClass, byte minimumAge, double minimumAverage)
        {
            NameClass = nameClass;
            MinimumAge = minimumAge;
            MinimumAverage = minimumAverage;
        }
        public string NameClass { get; }
        public byte MinimumAge { get; }
        public double MinimumAverage { get; }
        
    }
}