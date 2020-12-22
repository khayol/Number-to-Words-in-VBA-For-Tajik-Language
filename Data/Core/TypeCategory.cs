using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Core
{
public class TypeCategory
 {

    public int Id  { get; set; }


    [Display(Name = "Code")]
    public int Code  { get; set; }



    [Display(Name = "Name")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(128, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string Name  { get; set; }


    [Display(Name = "LongName")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string LongName  { get; set; }



 }

}