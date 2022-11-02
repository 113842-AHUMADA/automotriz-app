using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
    public class Documento
    {
        public int Id_Documento { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha_Documento { get; set; }
        public DateTime Fecha_Entrega { get; set; }
        public List<Detalle> lstDetalle { get; set; }

        public Documento()
        {
            lstDetalle = new List<Detalle>();
        }

        public void AgregarDetalle(Detalle detalle)
        {
            lstDetalle.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            lstDetalle.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (Detalle item in lstDetalle)
                total += item.CalcularSubTotal();
            return total;
        }
    }
}
