using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class AvailableAppointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte IdAAppoint { set; get; }
        [Required(ErrorMessage ="This Field Is Requried")]
        [MaxLength(10,ErrorMessage ="Must Day Name Less Then 10 char")]
        public string DayName { set; get; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "This Field Is Requried")]

        public TimeOnly AMForm { set; get; }
        [DataType(DataType.Time)]
        [TypeConverter(typeof(TimeOnlyToTimeSpanConverter))]

        [Required(ErrorMessage = "This Field Is Requried")]

        public TimeOnly AMTo { set; get; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "This Field Is Requried")]

        public TimeOnly PMForm { set; get; }
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "This Field Is Requried")]

        public TimeOnly PMTo { set; get; }
        public byte NumbersAppoint { set; get; }
        [ForeignKey("doctor")]
        public byte IdDoctor { set; get; }
        public Doctor doctor { set; get; }

    }
}
