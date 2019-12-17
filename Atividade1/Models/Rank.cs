using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1.Models
{
    public class Rank
    {
        [Key]
        public int ID { get; set; }
        public Jogador jogador1 { get; set; }
    }
}
