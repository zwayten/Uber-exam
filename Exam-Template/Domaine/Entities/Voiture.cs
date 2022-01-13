using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GP.Domain.Entities
{
    public class Voiture
    {
        [Key]
        public string NumMat { get; set; }
        public string Couleur  { get; set; }
        public string Marque { get; set; }

        public virtual IList<Chauffeur> Chauffeurs { get; set; }
        public virtual IList<Course> Courses { get; set; }
    }
}
