using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ISAD251Assignment.Models
{
    public class ManageUser
    {
        [Required] 
        public string Id { get; set; }

        [Required] 
        [StringLength(256, ErrorMessage = "{0} Must be at least {2} characters。", MinimumLength = 1)] 
        [Display(Name = "Nickname")] 
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}