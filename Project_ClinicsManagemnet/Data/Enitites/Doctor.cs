using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Doctor:PersonalData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IdDoctor { set; get; }
        [Required(ErrorMessage = "This Filed Is Required")]
        public string Specialication { set; get; }
 
        [ForeignKey("clinic")]
        public byte IdClinic { get; set; }
        public Clinic clinic { set; get; }
        [ForeignKey("user")]
        public string IdUser { set; get; }
        public IdentityUser user { set; get; }
    }
}
