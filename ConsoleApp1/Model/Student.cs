namespace ConsoleApp1.Model;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }   
    public int Grade { get; set; }
}
public class StudentData
{
    public string Group { get; set; }
    public string Semester { get; set; }
    public List<Student> Students { get; set; }
}