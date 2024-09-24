using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGA.Entidad
{
    public class Cuarto
    {
        [Key]
        public int N_Cuarto {  get; set; }
        public int Cedula {  get; set; }
        public int N_servicios { get; set; }
        public bool Uso_Parqueadero { get; set; }
        // relaciones 
        //huesped
        public ICollection<Huesped> huespedes { get; set; }
        // lavanderia 
        public Lavanderia Lavanderia { get; set; }
        //parqueadero
        public Parqueadero Parqueadero { get; set; }
       
    }
}
