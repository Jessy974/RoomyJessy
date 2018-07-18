using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class Room : BaseModel
    {
        [Required(ErrorMessage = "le champ{0} est obligatoire")]
        [StringLength(50)]
        [Display(Name = "Libellé")]
        public string Name { get; set; }


        [Required(ErrorMessage = "le champ{0} est obligatoire")]
        [Range(0, 50)]
        [Display(Name = "Nombre de places")]
        public int Capacity { get; set; }


        [Required(ErrorMessage = "le champ{0} est obligatoire")]
        [Display(Name = "Tarif")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }



        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Required(ErrorMessage = "le champ{0} est obligatoire")]
        [Display(Name = "Date de création")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dddd dd MMMM yyyy}")]
        public DateTime CreatedAt { get; set; }

        [Display(Name="Utilisateur")]
        public int? UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}