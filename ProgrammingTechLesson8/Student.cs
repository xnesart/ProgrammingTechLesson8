namespace ProgrammingTechLesson8
{
    public class Student
    {
        public string Name;
        public string Surname;
        public int Course;
        public int PhysicsScore;
        public int MathScore;
        public int ComputerScienceScore;
        public int ScoreSum;


        public Student( string name, string surname, int course, int physicsScore, int mathScore, int computerScienceScore)
        {
            Name = name;
            Surname = surname;
            Course = course;
            PhysicsScore = physicsScore;
            MathScore = mathScore;
            ComputerScienceScore = computerScienceScore;
            ScoreSum = PhysicsScore + MathScore + ComputerScienceScore;
        }
    }
}