using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Clinic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte ClinicId  { get; set; }
        [MaxLength(100,ErrorMessage ="Please Enter Name Less Then 100 char")]
        public string Name { get; set; }

        public string Specialization { get; set; }
        [RegularExpression(@"01[125]$[0-9]{9}",ErrorMessage ="Please Enter Vilad Number Phone")]
        public string PhoneOne { get; set; }
        [RegularExpression(@"01[125]$[0-9]{9}", ErrorMessage = "Please Enter Vilad Number Phone")]

        public int PhoneTwo { get; set; }
        [MaxLength(50,ErrorMessage ="The Location of Clinic Must Less Then  50 char")]
        public string Location { get; set; }

        public string Address { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
