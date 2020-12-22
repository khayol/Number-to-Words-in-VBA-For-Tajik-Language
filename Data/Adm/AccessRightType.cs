using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Adm
{
    public class AccessRightType
    {
        
         [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string Name  { get; set; }

        
        [Display(Name = "LongName")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(500, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string LongName  { get; set; }

          //----------------------------------------
        public List<AccessRight> AccessRight { get; set; }
    }
}