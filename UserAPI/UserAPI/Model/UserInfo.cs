using System.ComponentModel.DataAnnotations;

namespace UserAPI.Model
{
    public class UserInfo
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
