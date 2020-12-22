using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Adm
{
    public class AccessRight
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
       // [Required(ErrorMessage = "RequiredFld")]
       // [StringLength(500, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string LongName  { get; set; }

        
        [Display(Name = "Parent_AccessRight")]
        //[Required(ErrorMessage = "RequiredFld")]
       // [StringLength(64, ErrorMessage = "StringLength", MinimumLength = 1)]
        public string Parent_AccessRightId  { get; set; }

        //-------------------------------
        
        [Display(Name = "AccessRightType")]
        public int? AccessRightTypeId  { get; set; }
        [Display(Name = "AccessRightType")]
        public AccessRightType AccessRightType  { get; set; }

        public ICollection<RoleAccessRight> RoleAccessRight { get; set; }


    }
}