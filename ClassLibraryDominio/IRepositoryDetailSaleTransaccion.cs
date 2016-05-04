using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDominio
{
   public interface IRepositoryDetailSaleTransaccion
    {
        IEnumerable<DetailSaleTransaccion> GetDetalleVentaList();
        DetailSaleTransaccion AddDetalleVentaList(string IdArticles, string Quantity, string IdSale);

    }
}
