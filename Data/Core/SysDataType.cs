using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Core
{

    public class SysDataType
 {

    public int Id  { get; set; }



    [Display(Name = "Code")]
    public int Code  { get; set; }



    [Display(Name = "Name")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(32, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string Name  { get; set; }


    [Display(Name = "LongName")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string LongName  { get; set; }


    [Display(Name = "SizeBits")]
    [Required(ErrorMessage = "RequiredFld")]
    public int SizeBits  { get; set; }


    [Display(Name = "RangeValues")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(512, ErrorMessage = "StringLength", MinimumLength = 3)]
    public string RangeValues  { get; set; }


    [Display(Name = "TypeList")]
    public int? TypeListId  { get; set; }
    [Display(Name = "TypeList")]
    public TypeList TypeList  { get; set; }


    [Display(Name = "Status")]
    public int? StatusId  { get; set; }
    [Display(Name = "Status")]
    public Status Status  { get; set; }





 }

}