using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade1.Models
{
    public class Jogador
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nacionalidade { get; set; }

    }
}
