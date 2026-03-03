using ConsoleApp1.Model;
using DocumentFormat.OpenXml.Bibliography;
using QuestPDF.Fluent;
namespace ConsoleApp1.ConcreteProducts;

public class TxtDocument:IExportDocument
{
    public void Save(string path, List<Student> data)
    {
        using (StreamWriter sw = new StreamWriter(path)) 
        {
            foreach (Student student in data) 
            { 
           sw.WriteLine($"Имя {student.Name} Оценка {student.Grade}");
            
            
            }
   
        
        }
    }
}