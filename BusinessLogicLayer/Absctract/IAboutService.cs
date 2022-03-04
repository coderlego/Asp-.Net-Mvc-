using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Absctract
{
    public interface IAboutService
    {
        List<About> GetList();// tüm liste döner
        List<About> GetListByAboutId(int id);// id ile bir çok liste döner
        void AboutAdd(About about);
        About GetById(int id);//tek bir sonuc id göre döner
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
