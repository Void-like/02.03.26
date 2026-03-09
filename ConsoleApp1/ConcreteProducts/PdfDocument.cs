using ConsoleApp1.Model;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
namespace ConsoleApp1.ConcreteProducts;

public class PdfDocumentPdfDocument: IExportDocument
{
    public void Save(string path, List<Student> data)
    {
        //иНаЧе ОчЕрЕдНаЯ Ошибочка
        QuestPDF.Settings.License = LicenseType.Community;
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