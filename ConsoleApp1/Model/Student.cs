using System.Text.Json.Serialization;

namespace ConsoleApp1.Model;

public class Student
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("grade")]
    public int Grade { get; set; }
}
public class StudentData
{
    [JsonPropertyName("group")]
    public string Group { get; set; }
    [JsonPropertyName("semester")]
    public string Semester { get; set; }
    [JsonPropertyName("students")]
    public List<Student> Students { get; set; }
}