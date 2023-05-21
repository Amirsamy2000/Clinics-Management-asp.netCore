using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Patient:PersonalData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdPatient { get; set; }
        [ForeignKey("user")]
        public string IdUser { set; get; }
        public IdentityUser  user { get; set; }
        public ICollection<Clinic> clinics { get; set; }
    }
}
