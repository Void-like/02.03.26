using ConsoleApp1.Model;
using QuestPDF.Fluent;
namespace ConsoleApp1.ConcreteProducts;

public class TxtDocument:IExportDocument
{
    public void Save(string path, List<Student> data)
    {
        throw new NotImplementedException();
    }
}