using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class MaterialConsumer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdConsumerM { set; get; }
        [Required(ErrorMessage ="This Field Is Required")]
        public int Quentity { set; get; }


        public string ?Description { set; get; }
        [ForeignKey("material")]
        public int IdMaterial { set; get; }
        public Material material { set; get; }
        [ForeignKey("clinic")]
        public byte IdClinic { get; set; }
        public Clinic clinic { set; get; }
        [ForeignKey("user")]
        public string IdUser { set; get; }
        public IdentityUser user { set; get; }
    }
}
