using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGA.Entidad
{
    public class Parqueadero
    {
        public bool Uso_Parqueadero {  get; set; }
        public int Cedula {  get; set; }
        // relacion con el cuarto
        public int N_Cuarto { get; set; }
        public Cuarto Cuarto { get; set; }
    }
}
