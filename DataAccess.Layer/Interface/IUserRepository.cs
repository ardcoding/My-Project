using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDB.Entity;

namespace DataAccess.Layer.Interface
{
    public interface IUserRepository
    {
        Task<List<Userr>> GetUsers();
    }
}
