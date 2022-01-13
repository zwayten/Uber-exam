using System;
using System.Collections.Generic;
using System.Text;

namespace GP.Domain.Entities
{
    public enum Etat { EnAttente, EnCours, Payee }
    public class Course
    {
        public DateTime DateCourse { get; set; }
        public string LieuDepart { get; set; }
        public string LieuArrive { get; set; }
        public string Montant { get; set; }
        public bool PaiementEnLigne { get; set; }
        public Etat Etat { get; set; }

        public string VoitureId { get; set; }
        public string ClientId { get; set; }
        public virtual Voiture voiture { get; set; }
        public virtual Client client { get; set; }

    }
}
