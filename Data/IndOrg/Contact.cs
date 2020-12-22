using System;
using System.ComponentModel.DataAnnotations;
namespace Woorj.Data.IndOrg
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }


        [Display(Name = "FirstNameEN")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string Name { get; set; }


        [Display(Name = "Description")]
      //  [Required(ErrorMessage = "RequiredFld")]
     //  [StringLength(256, ErrorMessage = "StringLength")]
        public string Description { get; set; }   

    
        [Display(Name = "CreatedDate")]
        // [Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate  { get; set; }
        //===============================================
        
        [Display(Name = "Individual")]
        public int? IndividualId  { get; set; }
        [Display(Name = "Individual")]
        public Individual Individual  { get; set; }

        
        
        /*

        [Display(Name = "TypeList")]
        public int? TypeListId  { get; set; }
        [Display(Name = "TypeList")]
        public TypeList TypeList  { get; set; }


        [Display(Name = "Status")]
        public int? StatusId  { get; set; }
        [Display(Name = "Status")]
        public Status Status  { get; set; }
       */
    }
}