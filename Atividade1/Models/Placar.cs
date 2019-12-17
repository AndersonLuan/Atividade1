using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1.Models
{
    public class Placar
    {
        [Key]
        public int ID { get; set; }
        public string JogadorPts { get; set; }
        public int TotalPts { get; set; }
        public string DiaPts { get; set; }

    }
}
