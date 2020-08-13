using System.ComponentModel.DataAnnotations;

namespace UserApi.Models
{
    public class UserModel
    {
        [Key]
        public int? UserId { get; set; }

        public string UserName { get; set; }

        public string UserLastName { get; set; }

        public int UserAge { get; set; }
    }
}
