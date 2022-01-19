using System;
using System.Collections.Generic;

#nullable disable

namespace bertozzi.mattia._5H.StudentiClassi.Models
{
    public partial class Docente
    {
        public long IdDocente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Cf { get; set; }
    }
}
