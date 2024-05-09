using System.ComponentModel.DataAnnotations;

namespace Importation.Model
{
    public class UserInformation
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(15)]
        public string MobileNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        public UserAccount UserLoginID { get; set; }
    }
}
