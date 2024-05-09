using System.ComponentModel.DataAnnotations;

namespace Importation.Model
{
    public class UserAccount
    {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserLoginID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        [Required]
        [MaxLength(1)]
        public int Admin { get; set; }

        [Required]
        [MaxLength(1)]
        public int Officer { get; set; }

        [Required]
        [MaxLength(1)]
        public int LoginStatus { get; set; }

        [Required]        
        public DateTime RecordDate { get; set; }

        [Required]
        public DateTime RecordTime { get; set; }

        [Required]
        public DateTime LastModified { get; set; }

        [Required]
        [MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}
