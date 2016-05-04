using ClassLibraryDominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplicationShoppingCenter.Http_Client
{
    public class ArchivoCarga
    {
        readonly IMyHttp _httpClient;
        private string Base_Url = "http://localhost:3762/ServiceSCA.svc/";
        public ArchivoCarga()
        {

            _httpClient = new MyHttp();
            cargaArticulos();

        }

        public async void cargaArticulos() {


            var task = await _httpClient.GetAsync(Base_Url + "Article/Add/Uva/4");
            var jsonString = await task.Content.ReadAsStringAsync();
            var model = JsonModelMethod(jsonString);




             task = await _httpClient.GetAsync(Base_Url + "Article/Add/Pera/4");
             jsonString = await task.Content.ReadAsStringAsync();
             model = JsonModelMethod(jsonString);






             task = await _httpClient.GetAsync(Base_Url + "AddVentaList/30-12-2011/8");
             jsonString = await task.Content.ReadAsStringAsync();
             model = JsonModelMethod(jsonString);

         

            task = await _httpClient.GetAsync(Base_Url + "AddDetalleVentaList/2/1/1");
             jsonString = await task.Content.ReadAsStringAsync();
             model = JsonModelMethod(jsonString);

         
             task = await _httpClient.GetAsync(Base_Url + "AddDetalleVentaList/3/1/1");
             jsonString = await task.Content.ReadAsStringAsync();
             model = JsonModelMethod(jsonString);



        }

        private static List<Article> JsonModelMethod(string jsonString)
        {
            var model = JsonConvert.DeserializeObject<List<Article>>(jsonString);
            return model;
        }

    }
}