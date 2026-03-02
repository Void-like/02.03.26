using QuestPDF.Fluent;
using ClosedXML;
using ConsoleApp1.Model;
using ClosedXML.Excel;

namespace ConsoleApp1.ConcreteProducts;

public class XlsxDocument: IExportDocument
{
    public void Save(string path, List<Student> data)
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Отчёт");
            int row = 1;

            foreach (var student in data)
            {
                worksheet.Cell(row, 1).Value = student.Name;
                worksheet.Cell(row, 2).Value = student.Grade;
                row++;
            }

            workbook.SaveAs(path);
        }
    }
}
