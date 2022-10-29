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
            var viewUser = new List<ViewUserModel>();
            var user = db.Users.Find(id);

            if (user != null)
            {
                var tempUser = new ViewUserModel();

                tempUser.Id = user.Id;
                tempUser.Name = user.FirstName + " " + user.LastName;
                tempUser.Phone = user.Phone;

                viewUser.Add(tempUser);

                return Ok(viewUser);
            }

            else return BadRequest("Invalid ID");
        }
    }
}
