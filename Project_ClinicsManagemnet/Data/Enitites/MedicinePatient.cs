using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class MedicinePatient
    {
        [ForeignKey("prescription")]
        public int Idprescription { get; set; }
       public Prescription prescription { set; get; }
        [Required]
        public string MedicineName { set; get; }
        public string ?Description { set; get; }
    }
}
