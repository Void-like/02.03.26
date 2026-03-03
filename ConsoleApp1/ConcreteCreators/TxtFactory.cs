using ConsoleApp1.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConcreteCreators
{
    public class TxtFactory : DocumentFactory
    {
        public override IExportDocument CreateExportDocument()
        {
            return new TxtDocument();
        }
    }
}
