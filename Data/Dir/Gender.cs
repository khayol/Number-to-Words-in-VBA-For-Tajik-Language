using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Woorj.Data.Dir
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }

       // [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }

        [Display(Name = "Name")]
       // [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string Name  { get; set; } 
    }
}