using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Woorj.Data.Adm
{
 public class ApplicationRole: IdentityRole
 {



    [Display(Name = "Code")]
    public int Code  { get; set; }


    [Display(Name = "Description")]
  //  [Required(ErrorMessage = "RequiredFld")]
    [StringLength(512, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string Description  { get; set; }



    [Display(Name = "CreatedDate")]
    [Required(ErrorMessage = "RequiredFldSmpl")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate  { get; set; }

    public ICollection<RoleAccessRight> RoleAccessRight { get; set; }
  
  // public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }


 }

}
