using Microsoft.AspNetCore.Mvc;
using UserAPI.DB;
using UserAPI.Model;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext db;

        public UserController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpPost]
        public IActionResult AddUserInfo(UserInfo userInfo)
        {
            if(userInfo != null)
            {
                var user = db.Users.Add(userInfo);
                db.SaveChanges();
            }

            return Ok(userInfo);
        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetUserById(long id)
        {
            return Ok(db.Users.Find(id));
        }
    }
}
