using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public int Anio { get; set; }
        public bool Stock { get; set; }
        public double Precio_Vta { get; set; }
        


    }
}
