using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        public string Username { get; set; }


        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="You must specify password from 4to 8 characteristics")]
        public string Password { get; set; }

    }
}