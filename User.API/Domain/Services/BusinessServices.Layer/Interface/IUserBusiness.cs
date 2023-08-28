using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDB.Entity;

namespace BusinessServices.Layer.Interface
{
    public interface IUserBusiness
    {
        Task<List<Userr>> GetUsers();
    }
}
