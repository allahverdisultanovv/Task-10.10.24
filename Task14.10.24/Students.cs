namespace Task14._10._24
{
    public class Students
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool IsGraduated;
    }
    public Students(string name, string surname, string group, int point)
    {
        student.Name = name;
        student.Surname = surname;
        student.Point = point;
        student.Group = group;
        if (student.Point > 65)
        {
            student.IsGraduated = true;

        }
        else
        {
            student.IsGraduated = false;
        }
    }
}
