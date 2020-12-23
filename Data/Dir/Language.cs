using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Woorj.Data.Core;
using Woorj.Data.IndOrg;

namespace Woorj.Data.Dir
{

   // [Table("Language", Schema="dbo")]
    public class Language
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }

        [Display(Name = "Alpha2")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(2, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string Alpha2 { get; set; }


        [Display(Name = "Alpha3")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(3, ErrorMessage = "StringLength", MinimumLength = 3)]
        public string Alpha3 { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string Name { get; set; }



        [Display(Name = "NativeName")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(256, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string NativeName { get; set; }


        [Display(Name = "CreatedDate")]
        [Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate  { get; set; }

       //=========================================
       [Display(Name = "Status")]
        public int? StatusId  { get; set; }
        [Display(Name = "Status")]
        public Status Status  { get; set; }
    }
}