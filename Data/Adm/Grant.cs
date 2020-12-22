using System.ComponentModel.DataAnnotations;

namespace Woorj.Data.Adm
{
    public class Grant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Code")]
        public int Code { get; set; }

        //???????????

 
    }
}