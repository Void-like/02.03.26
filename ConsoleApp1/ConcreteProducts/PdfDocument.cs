using ConsoleApp1.Model;
using QuestPDF.Fluent;

namespace ConsoleApp1.ConcreteProducts;

public class PdfDocumentPdfDocument: IExportDocument
{
    public void Save(string path, List<Student> data)
    {
        Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Content().Column(column =>
                    {
                        foreach (var student in data)
                        {
                            column.Item().Text($"{student.Name} - {student.Grade}");
                        }
                    });
                });
            })
            .GeneratePdf(path);
    }
}