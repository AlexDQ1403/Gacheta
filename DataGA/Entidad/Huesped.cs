using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGA.Entidad
{
    public class Huesped
    {
        [Key]
        public int Cedula{ get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public int Celular { get; set; }
        public int Edad {  get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_Salida { get;set; }
        public int S_Lavanderia { get; set; }


        // relacion con la clase Cuarto

        public int N_Cuarto { get; set; }
        public Cuarto Cuarto { get; set; }

    }
}
