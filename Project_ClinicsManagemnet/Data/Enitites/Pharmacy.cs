using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Pharmacy
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdParm { get; set; }

        [ForeignKey("prescription")]
        public int IdPrescription { set; get; }
        public Prescription prescription { set; get; }

        public DateTime ApplayOn { set; get; }
        public decimal TotalPrice { set; get; }

        [ForeignKey("doctor")]
        public byte IdDoctor { set; get; }
        public Doctor doctor { set; get; }
    }
}
