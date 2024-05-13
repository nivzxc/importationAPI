using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Importation.Model
{
    public class UserAccount
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserLoginID { get; set; }
               
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
