using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Core
{
    public class GlobalVariable
    {
    public int Id  { get; set; }


    [Display(Name = "Code")]
    public int Code  { get; set; }

    [Display(Name = "KeyWord")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(32, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string KeyWord  { get; set; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 2)]
    public string Name  { get; set; }


    [Display(Name = "DeafultVal")]
    [Required(ErrorMessage = "RequiredFld")]
    [StringLength(512, ErrorMessage = "StringLength", MinimumLength = 1)]
    public string DefaultVal  { get; set; }



    [Display(Name = "Description")]
    //[Required(ErrorMessage = "RequiredFld")]
    [StringLength(900, ErrorMessage = "StringLength", MinimumLength = 2)]
     public string Description  { get; set; }


     
    [Display(Name = "SysDataType")]
    public int? SysDataTypeId  { get; set; }
    [Display(Name = "SysDataType")]
    public SysDataType SysDataType  { get; set; }




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