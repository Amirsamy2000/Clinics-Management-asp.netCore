using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int IdAppoint {  get; set; }
        [Required(ErrorMessage = "This Field Is Requried")]
        [MaxLength(10, ErrorMessage = "Must Day Name Less Then 10 char")]
        public string DayName { set; get; }

        [Required(ErrorMessage = "This Filed Is Required")]
        [DataType(DataType.Date)]
        public DateOnly Day { get; set; }

       
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "This Field Is Requried")]

        public TimeOnly AppointTime { set; get; }
        [ForeignKey("AvailableAppointment")]
        public byte IdAAppoint { set; get; }
        public AvailableAppointment AvailableAppointment { get; set; }


        [ForeignKey("Patient")]
        public int Idpateint { set; get; }
        public Patient Patient { set; get; }

        [ForeignKey("doctor")]
        public byte IdDoctor { set; get; }
        public Doctor doctor { set; get; }







    }
}
