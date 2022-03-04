using BusinessLogicLayer.Absctract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admin;

        public AdminManager(IAdminDal admin)
        {
            _admin = admin;
        }

        public Admin GetById(string username, string password)
        {
            return _admin.Get(x => x.AdminUserName == username && x.AdminPassword == password);
        }
    }
}
