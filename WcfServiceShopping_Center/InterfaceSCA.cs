using ClassLibraryDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceShopping_Center
{
        [ServiceContract]

    public interface InterfaceSCA
    {

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticleList")]
        IEnumerable<Article> GetArticleList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetArticle/{id}")]
        Article GetArticle(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/Article/Add/{name}/{price}/{imagen}")]
        Article Add(string name, string price, string imagen);


        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetDetalleVentaList")]
        IEnumerable<DetailSaleTransaccion> GetDetalleVentaList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddDetalleVentaList/{IdArticles}/{Quantity}/{IdSale}")]
        DetailSaleTransaccion AddDetalleVentaList(string IdArticles, string Quantity, string IdSale);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/AddVentaList/{Date}/{Total}")]
        SaleTransaccion AddVentaList(string Date, string Total);
     
       


    }
}
