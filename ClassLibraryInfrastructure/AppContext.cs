

using ClassLibraryDominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryInfrastructure
{
    

   public partial class AppContext :DbContext, IUnitOfWork , IRepositorio
    {
       public AppContext()
          :base("DefaultConnection")
       {

       }
       
       public IDbSet<Article> Article { get; set; }
       public IDbSet<DetailSaleTransaccion> DetailSale { get; set; }
       public IDbSet<SaleTransaccion> Sale { get; set; }



       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           var cn = this.Database.Connection.ConnectionString;
           base.OnModelCreating(modelBuilder);
       }
       
    }
}


