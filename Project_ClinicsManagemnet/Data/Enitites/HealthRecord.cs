using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class HealthRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdRecord { set; get; }
        public decimal? Weight { set; get; }

        public decimal? Height { set; get; }
        [MaxLength(10,ErrorMessage ="Enter Viald Value")]
        public string BloodPressure { set; get; }
        
        public int HeartRate { set; get; }
       
        public string MedicalConditions { set; get; }

        public decimal CholesterolLevel { set; get; }
        public decimal BloodSugarLevel { set; get; }

        [ForeignKey("Patient")]
        public int Idpateint { set; get; }
        public Patient Patient { set; get; }

        [ForeignKey("doctor")]
        public byte IdDoctor { set; get; }
        public Doctor doctor { set; get; }


}
}
