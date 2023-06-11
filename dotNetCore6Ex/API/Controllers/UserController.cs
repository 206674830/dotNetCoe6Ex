using dotNetCore6Ex.BL;
using dotNetCore6Ex.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace dotNetCore6Ex.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        public UserController(IUserBL userBL)
        {
            this.userBL = userBL;
        }
        [HttpGet("getUsers")]
        public async Task<ActionResult<List<User>>> getUsers(){
            return await userBL.getUsers();
        }

        [HttpPost("saveUser")]
        public async Task<ActionResult<bool>> saveUser([FromBody] User user)
        {
            return await userBL.saveUser(user);
        }

        [HttpPost("putUser")]
        public async Task<ActionResult<bool>> putUser([FromBody] User user)
        {
            return await userBL.putUser(user);
        }

        [HttpPost("deleteUser")]
        public async Task<ActionResult<bool>> deleteUser([FromBody]User user)
        {
            return await userBL.deleteUser(user);
        }

    }
}
