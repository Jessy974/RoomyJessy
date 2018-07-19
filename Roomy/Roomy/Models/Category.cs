using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Models
{
    public class Category :BaseModel
    {
        [Required(ErrorMessage = "le champ {0} est obligatoire")]
        [StringLength(50)]
        [Display(Name = "Catégorie")]
        public string Name { get; set; }
    }
}