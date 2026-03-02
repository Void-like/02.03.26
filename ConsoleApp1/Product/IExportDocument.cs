using ConsoleApp1.Model;

namespace ConsoleApp1;

public interface IExportDocument
{
    public void Save(string path, List<Student> data);

}