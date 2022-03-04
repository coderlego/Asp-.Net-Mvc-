using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Absctract
{
    public interface IContentService
    {
        List<Content> GetList();// tüm liste döner
        List<Content> GetListByHeadingId(int id);// id ile bir çok liste döner
        void ContentAdd(Content content);
        Content GetById(int id);//tek bir sonuc id göre döner
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
