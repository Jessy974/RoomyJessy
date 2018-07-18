using Roomy.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roomy.Utils.Validators
{
    
    public class ExistingMail :ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            //créer un dbcontext
            using (RoomyDbContext db = new RoomyDbContext())
            {
                //méthode entity
                return !db.Users.Any(x => x.Mail == value.ToString());
            }
            
        }

    }
  
}
