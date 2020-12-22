using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Woorj.Data.Dir;
using Woorj.Services;

namespace Woorj.Data.IndOrg
{
    public class Individual
    {
      
       public Individual()
        {      
          Contact = new HashSet<Contact>();         
        }
        
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }


        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength FirstName", MinimumLength = 2)]
        public string FirstName  { get; set; }

        
        [Display(Name = "SecondName")]
        [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string SecondName  { get; set; }



        [Display(Name = "LastName")]
        [StringLength(128, ErrorMessage = "StringLength", MinimumLength = 2)]
        public string LastName  { get; set; }


        [Display(Name = "FullName")]
        public string FullName
        {
        get
        {
            return SecondName + " " + FirstName+ " " + LastName;
        }
        }

        [Display(Name = "FirstNameEN")]
       // [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength FirstNameEN", MinimumLength = 2)]
        public string FirstNameEN  { get; set; }




        [Display(Name = "SecondNameEN")]
        //  [Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength SecondNameEN", MinimumLength = 2)]
        public string SecondNameEN  { get; set; }




        [Display(Name = "LastNameEN")]
        [StringLength(128, ErrorMessage = "StringLength LastNameEN", MinimumLength = 2)]
        public string LastNameEN  { get; set; }
       

        [Display(Name = "FullNameEN")]
        public string FullNameEN
        {
        get
        {
            return SecondNameEN + " " + FirstNameEN+ " " + LastNameEN;
        }
        }



        [Display(Name = "BirthDay")]
        //[Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]    
        public DateTime? BirthDay  { get; set; }


        [Display(Name = "TaxCode")]
        //[Required(ErrorMessage = "RequiredFld")]
        [StringLength(256, ErrorMessage = "StringLength TaxCode", MinimumLength = 1)]
        public string TaxCode { get; set; }



        [Display(Name = "PassSerial")]
        //[Required(ErrorMessage = "RequiredFld")]
        [StringLength(10, ErrorMessage = "StringLength PassSerial", MinimumLength = 1)]
        public string PassSerial { get; set; }



        [Display(Name = "PassCode")]
        //[Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength PassCode", MinimumLength = 2)]
        public string PassCode { get; set; }



        [Display(Name = "DocDate")]
        // [Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]
        public DateTime? DocDate { get; set; }



        [Display(Name = "DocDateEnd")]
       //  [Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]
        public DateTime? DocDateEnd { get; set; }



        [Display(Name = "PassOrg")]
        //[Required(ErrorMessage = "RequiredFld")]
        [StringLength(128, ErrorMessage = "StringLength PassOrg", MinimumLength = 2)]
        public string PassOrg { get; set; }



        [Display(Name = "Address")]
        //[Required(ErrorMessage = "RequiredFld")]
        [StringLength(256, ErrorMessage = "StringLength Address", MinimumLength = 1)]
        public string Address  { get; set; }


       [Display(Name = "CreatedDate")]
        // [Required(ErrorMessage = "RequiredFldSmpl")]
        [DataType(DataType.Date)]
        public DateTime? CreatedDate  { get; set; }
        
      //=================================================  
        
       // public List<Contact> Contact { get; set; }
       public virtual  ICollection<Contact> Contact { get; set; }


        [Display(Name = "Gender")]
        public int? GenderId  { get; set; }
        
        [Display(Name = "Gender")]
        public Gender Gender  { get; set; }



         [Display(Name = "BirthPlace")]
         public int? BirthPlace_CountryId  { get; set; }
        
         [Display(Name = "BirthPlace")]
         public Country BirthPlace_Country  { get; set; }


        /*


        [Display(Name = "Department")]
        public int? DepartmentId  { get; set; }
        [Display(Name = "Department")]
        public Department Department  { get; set; }



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


     public class IndividualValidator : AbstractValidator<Individual>
    {
        public IndividualValidator()
        {

         string fieldName=StatCls.GetTranslation("FirstName",@AppData.ActiveUser,"Individual"); 
         
         int firstNameMin=2;int firstNameMax=128;
         var min_max_FirstNameMsg =StatCls.GetTranslation("StringLength",@AppData.ActiveUser,"General");
         var min_max_FirstNameMsgFull=String.Format(min_max_FirstNameMsg,fieldName,firstNameMin,firstNameMax);
         RuleFor(p => p.FirstName).MinimumLength(firstNameMin).WithMessage(min_max_FirstNameMsgFull);
         RuleFor(p => p.FirstName).MaximumLength(firstNameMax).WithMessage(min_max_FirstNameMsgFull);
          
         var FirstNameNotNullMsg=StatCls.GetTranslation("RequiredFld",@AppData.ActiveUser,"General");
         var  FirstNameNotNullMsgFull=String.Format(FirstNameNotNullMsg,fieldName);
         RuleFor(p => p.FirstName).NotEmpty().WithMessage(FirstNameNotNullMsgFull);
              


        }
    }


}
