using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGA.Entidad
{
    public class Lavanderia
    {
        [Key] 
        public int N_Servicios { get; set; }
        public int Cedula { get; set; }
        //relacion con el cuarto
        public int N_Cuarto { get; set; }
        public ICollection<Cuarto> Cuartos { get; set; }  // Lavandería puede servir varios cuartos

    }
}
