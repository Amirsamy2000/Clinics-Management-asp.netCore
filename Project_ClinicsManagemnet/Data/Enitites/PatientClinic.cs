using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class PatientClinic
    {
        [ForeignKey("patient")]
        public int idPatient { set;get; }
        public Patient patient { get; set; }

        [ForeignKey("clinic")]
        public byte IdClinic { set; get; }
        public Clinic clinic { get; set; }  
    }
}
