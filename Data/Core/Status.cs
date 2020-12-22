using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Core
{

    public class Status
 {

    public int Id  { get; set; }


    [Display(Name = "Code")]
    public int Code  { get; set; }


    [Display(Name = "Name")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(36, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string Name  { get; set; }



    [Display(Name = "LongName")]
   // [Required(ErrorMessage = "RequiredFld")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string LongName  { get; set; }



    [Display(Name = "TypeList")]
    public int? TypeListId  { get; set; }
    [Display(Name = "TypeList")]
    public TypeList TypeList  { get; set; }





 }

}