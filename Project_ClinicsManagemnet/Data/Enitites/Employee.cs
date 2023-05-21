using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Employee:PersonalData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public byte IdEmployee { set; get;}

        [MaxLength(50,ErrorMessage ="Please Enter Less Then 50")]
        [Required(ErrorMessage = "This Filed Is Required ")]
        public string Type { set; get;}

        [Required(ErrorMessage = "Salary Filed Is Required ")]
        public Double Salary { set; get; }

        [ForeignKey("clinic")]
        public byte IdClinic { get; set; }
        public Clinic clinic { set; get; }
        [ForeignKey("user")]
        public string IdUser { set; get; }
        public IdentityUser user { set; get; }
    }
}
