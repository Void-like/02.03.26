using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ConcreteCreators
{
   public abstract class DocumentFactory
    {
        public abstract IExportDocument CreateExportDocument();
    }
}
