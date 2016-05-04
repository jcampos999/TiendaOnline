using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDominio
{
   public class DetailSaleTransaccion
    {
        public int Id { get; set; }
        public int IdArticles { get; set; }
        public int Quantity { get; set; }
        public int IdSale { get; set; }
        public decimal SubTotal { get; set; }
        


    }
}
