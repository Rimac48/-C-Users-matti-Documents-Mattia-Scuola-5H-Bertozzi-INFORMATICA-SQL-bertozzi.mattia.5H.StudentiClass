using System;
using System.Collections.Generic;

#nullable disable

namespace bertozzi.mattia._5H.StudentiClassi.Models
{
    public partial class Studente
    {
        public long IdStudente { get; set; }
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public long FkIdclasse { get; set; }

        public virtual Classe FkIdclasseNavigation { get; set; }
    }
}
