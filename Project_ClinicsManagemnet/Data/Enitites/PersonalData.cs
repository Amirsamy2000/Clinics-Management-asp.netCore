using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class PersonalData
    {
        [MaxLength(200 ,ErrorMessage ="please Enter Less Then 200 char")]
        [Required(ErrorMessage = "This Filed Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Filed Is Required")]
        public string? Address { get; set; }
        [RegularExpression(@"01[125]$[0-9]{9}", ErrorMessage = "Please Enter Vilad Number Phone")]

        public int Phone { set; get; }
        [Required(ErrorMessage = "This Filed Is Required")]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }
        [Required(ErrorMessage = "This Filed Is Required")]

        public char Gender { set; get; }

     
    }
}
