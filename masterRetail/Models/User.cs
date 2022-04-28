using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace masterRetail.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [StringLength(150)]
        public string Name { get; set; } = "";

        [Required]
        [StringLength(10)]
        public string Gender { get; set; } = "";

        [Required]
        [DisplayName("Age in Years")]
        public int Age { get; set; }

        public virtual List<UserData> UserDatas { get; set; } = new List<UserData>();

        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "Please choose the Profile Photo")]
        [Display(Name = "Profile Photo")]
        [NotMapped]
        public IFormFile ProfilePhoto { get; set; }
    }
}
