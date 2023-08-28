using BusinessServices.Layer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserDB.Entity;
using static Response.GenericClass;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness _userBusiness;

        public UserController(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }
        [HttpGet]
        public async Task<List<Userr>> GetUsers()
        {
            var user = await _userBusiness.GetUsers();
            if(user === null)
            {
                return Ok(Response<Userr>.Success(user));
            }
            else
            {

            }
        }
    }
}
