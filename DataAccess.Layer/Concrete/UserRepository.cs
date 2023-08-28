using DataAccess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDB.Entity;

namespace DataAccess.Layer.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDBContext _dbcontext;

        public UserRepository(UserDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<List<Userr>> GetUsers()
        {
            return await _dbcontext.Users.ToListAsync();
        }
    }
}
