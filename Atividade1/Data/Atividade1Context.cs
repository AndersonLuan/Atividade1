using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Atividade1.Models;

namespace Atividade1.Data
{
    public class Atividade1Context : DbContext
    {
        public Atividade1Context (DbContextOptions<Atividade1Context> options)
            : base(options)
        {
        }

        public DbSet<Atividade1.Models.Jogador> Jogador { get; set; }

        public DbSet<Atividade1.Models.Placar> Placar { get; set; }

        public DbSet<Atividade1.Models.Rank> Rank { get; set; }
    }
}
