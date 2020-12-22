using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Woorj.Data.Dir;

namespace Woorj.Data.Adm
{
 public class ApplicationUser: IdentityUser
 {


    [Display(Name = "Code")]
    public int Code  { get; set; }


    [Display(Name = "FirstName")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(32, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string FirstName  { get; set; }



    [Display(Name = "SecondName")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(32, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string SecondName  { get; set; }



    [Display(Name = "LastName")]
   // [Required(ErrorMessage = "RequiredFld")]
    [StringLength(32, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string LastName  { get; set; }


    [Display(Name = "FullName")]
    public string FullName
    {
    get
    {
        return SecondName + " " + FirstName+ " " + LastName;
    }
    }


                 
    [Display(Name = "Language")]
    public int? LanguageId  { get; set; }
    
    [Display(Name = "Language")]
    public Language Language { get; set; }


    [Display(Name = "CreatedDate")]
    [Required(ErrorMessage = "RequiredFldSmpl")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate  { get; set; }




   





 }
       // public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
}
