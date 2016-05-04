using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDominio
{
   public interface IRepositorySaleTransaccion
    {
        SaleTransaccion AddVentaList(string Date, string Total);
    }
}
