using ClassLibraryDominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryInfrastructure
{
    public interface IRepositorio : IUnitOfWork
    {
        IDbSet<Article> Article { get; set; }
        IDbSet<DetailSaleTransaccion> DetailSale { get; set; }
        IDbSet<SaleTransaccion> Sale { get; set; }
    }
}

