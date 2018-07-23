﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Areas.BackOffice.Models
{
    public class AuthenticationLoginViewModels
    {

        [Display(Name ="Adresse Mail")]
        [Required(ErrorMessage ="le champ {0} est obligatoire")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
        ErrorMessage = "L'adresse mail n'est pas au bon format")]
        public String Login { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "le champ {0} est obligatoire")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

    }
    
}