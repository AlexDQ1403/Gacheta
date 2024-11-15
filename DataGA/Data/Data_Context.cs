using DataGA.Entidad;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGA.Data
{
    public class Clientes_Gacheta : DbContext
    {
        public Clientes_Gacheta(DbContextOptions<Clientes_Gacheta> options)
            : base(options)
        {
        }

        public DbSet<Cuarto> Cuartos { get; set; }
        public DbSet<Huesped> Clientes { get; set; }
        public DbSet<Parqueadero> Parqueaderos { get; set; }
        public DbSet<Lavanderia> Lavanderias { get; set; }


    }
}
