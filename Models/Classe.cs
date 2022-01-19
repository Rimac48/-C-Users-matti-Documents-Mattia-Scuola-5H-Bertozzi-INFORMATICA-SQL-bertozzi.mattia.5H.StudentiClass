using System;
using System.Collections.Generic;

#nullable disable

namespace bertozzi.mattia._5H.StudentiClassi.Models
{
    public partial class Classe
    {
        public Classe()
        {
            Studentes = new HashSet<Studente>();
        }

        public long Idclasse { get; set; }
        public string AnnoScolastico { get; set; }
        public long Anno { get; set; }
        public string Sezione { get; set; }

        public virtual ICollection<Studente> Studentes { get; set; }
    }
}
