using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ConcreteProducts;
namespace ConsoleApp1.ConcreteCreators
{
    public class PdfFactory: DocumentFactory
    {
        public override  IExportDocument CreateExportDocument()
        {
            return new PdfDocumentPdfDocument();
        }
    }
}
