using System.ComponentModel.DataAnnotations;

namespace UserAPI.Model
{
    public class ViewUserModel
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
