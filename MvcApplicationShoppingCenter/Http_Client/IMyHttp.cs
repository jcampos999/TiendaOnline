using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplicationShoppingCenter.Http_Client
{
    interface IMyHttp : IDisposable
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
    }
}



