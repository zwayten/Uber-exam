using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GP.Domain.Entities
{
   public class Client
    {
        [Key]
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "This field is required !")]
        public string Email { get; set; }
        public string  Password { get; set; }

        public virtual IList<Course> courses { get; set; }
    }
}
