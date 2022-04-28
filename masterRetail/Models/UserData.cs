using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace masterRetail.Models
{
    public class UserData
    {
        public UserData()
        {
        }

        [Key]
        public int DataId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; private set; } //very important 

        public string Email { get; set; } = "";
        [Required]
        public string PhoneNumber { get; set; } = "";
        [Required]
        public string AddressLine1 { get; set; } = "";
        public string AddressLine2 { get; set; } = "";


    }
}