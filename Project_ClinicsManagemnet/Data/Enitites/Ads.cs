using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_ClinicsManagemnet.Data.Enitites
{
    public class Ads
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdAds { get; set; }
        [MaxLength(50)]
  
        public string AdsName { set; get; }
        public string Description { set; get; }

        [ForeignKey("clinic")]
        public byte IdClinic { get; set; }
        public Clinic clinic { set; get; }
        [ForeignKey("user")]
        public string IdUser { set; get; }
        public IdentityUser user { set; get; }

    }
}
