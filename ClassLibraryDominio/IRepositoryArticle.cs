using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDominio
{
   public interface IRepositoryArticle
    {
       IEnumerable<Article> GetArticleList();
       Article GetArticle(string id);
       Article Add(string name, string price, string imagen);
    }
}
