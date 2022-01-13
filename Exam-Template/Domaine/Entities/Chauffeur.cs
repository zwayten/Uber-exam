using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Domain.Entities
{
    public class Chauffeur
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public float TauxBenefice { get; set; }
        public virtual Voiture voiture { get; set; }
        public string  voitureFK { get; set; }

    }
}
