using System;
using System.Collections.Generic;

#nullable disable

namespace bertozzi.mattia._5H.StudentiClassi.Models
{
    public partial class Materium
    {
        public long IdMateria { get; set; }
        public string Nome { get; set; }
        public long? FkIdclasse { get; set; }
    }
}
