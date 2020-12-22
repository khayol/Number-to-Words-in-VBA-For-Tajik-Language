using System;
using System.ComponentModel.DataAnnotations;
using Woorj.Data.Dir;

namespace Woorj.Data.Adm
{
    public class Localization
 {

    public int Id  { get; set; }


    [Display(Name = "Code")]
    public int Code  { get; set; }


    [Display(Name = "KeyWord")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string KeyWord  { get; set; }

    [Display(Name = "EntityName")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string EntityName  { get; set; }



    [Display(Name = "Translation")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(512, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string Translation  { get; set; }




    [Display(Name = "CreatedDate")]
    [Required(ErrorMessage = "RequiredFldSmpl")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate  { get; set; }
    



    [Display(Name = "Language")]
    public int? LanguageId  { get; set; }
    [Display(Name = "Language")]
    public Language Language  { get; set; }






 }
}