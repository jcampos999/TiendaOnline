using ClassLibraryDominio;
using ClassLibraryInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceShopping_Center
{
   
    public class ServiceSCA : InterfaceSCA
    {
         readonly IRepositorio _repositorioCliente ;
       

    //    public ServiceShoppingCenter (IRepositorio repositorioCliente)
    //{ 
    //        _repositorioCliente = repositorioCliente ;
    //}


         public ServiceSCA()
        {
            _repositorioCliente = new AppContext ();
        }


        public IEnumerable<Article> GetArticleList()
        {
            return _repositorioCliente.Article ;

        }

        public Article GetArticle(string id)
        {

            int idA = int.Parse( id) ;

            var Article = _repositorioCliente.Article.Where(c => c.Id == idA).FirstOrDefault();
            if (null != Article)
                return Article;

            return new Article();

        }



        public Article Add(string name, string price, string imagen)
        {
            Article article = new Article();
            article.Name = name;
            article.Price = decimal.Parse ( price);
            article.Imagen = imagen;
            var articles = _repositorioCliente.Article.Add(article);
            _repositorioCliente.SaveChanges();
            return articles ;
        }



        public void Dispose()
        {
            _repositorioCliente.Dispose();

        }


          public IEnumerable<DetailSaleTransaccion> GetDetalleVentaList()
        {
            return _repositorioCliente.DetailSale ;

        }


          public DetailSaleTransaccion AddDetalleVentaList(string IdArticles, string Quantity, string IdSale)
          {
           
              DetailSaleTransaccion detailSaleTransaction = new DetailSaleTransaccion() { IdArticles = int.Parse(IdArticles), Quantity = int.Parse(Quantity), IdSale = int.Parse(IdSale)  };
              var detailST = _repositorioCliente.DetailSale.Add(detailSaleTransaction);
             
              _repositorioCliente.SaveChanges();
              return detailST;
          }


          public SaleTransaccion AddVentaList(string Date, string Total)

    {
        SaleTransaccion SaleTransaction = new SaleTransaccion() { Date = Convert.ToDateTime(Date), Total = decimal.Parse(Total) };
        var sT = _repositorioCliente.Sale .Add(SaleTransaction);

        _repositorioCliente.SaveChanges();
        return sT;

    }
       

       
    }
}
