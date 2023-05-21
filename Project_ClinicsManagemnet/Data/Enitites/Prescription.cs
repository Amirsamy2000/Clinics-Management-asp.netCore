using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Prescription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdPrescription { get; set; }
        public string Disease { set; get; }
        public DateTime ApplayOn { set; get; }


        [ForeignKey("Patient")]
        public int Idpateint { set; get; }
        public Patient Patient { set; get; }

        [ForeignKey("doctor")]
        public byte IdDoctor { set; get; }
        public Doctor doctor { set; get; }

    }
}
