using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Material
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMaterial { set; get; }

        public string Name { set; get; }

        public int Quentity { set; get; }

        [Required(ErrorMessage = "This Filed Is Required")]
        [DataType(DataType.Date)]
        public DateOnly ProductionDate { get; set; }

        [Required(ErrorMessage = "This Filed Is Required")]
        [DataType(DataType.Date)]
        public DateOnly ExpiryDate { get; set; }
        [Required(ErrorMessage = "This Filed Is Required")]
        public Double Price { set; get; }
        [Required(ErrorMessage = "This Filed Is Required")]

        public Double TotalPrice { set; get; }

        public string ?Description { set; get; }
        [Required]
        public DateTime DateOn { set; get; }
        
       public double Discounts { set;get; }


    }
}
