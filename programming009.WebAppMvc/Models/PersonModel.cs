using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace programming009.WebAppMvc.Models
{
    public class PersonModel
    {
        //data annotation
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }


        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "The password should be minimum 6 characters")]
        [MaxLength(12, ErrorMessage = "The password should be maximum 12 characters")]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }


        [Range(0,5, ErrorMessage = "The rating should be in 1-5 range")]
        public int Rating { get; set; }
    }
}