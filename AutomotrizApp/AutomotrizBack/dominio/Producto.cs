using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AutomotrizApp.dominio
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public int Stock { get; set; }
        public int Stock_Critico { get; set; }
        public double Precio_Vta { get; set; }
        public Producto()
        {
        }
        public Producto(int id_producto, string marca, string modelo, string descripcion, string color,int anio,double precio_vta)
        {
            Id_Producto = id_producto;
            Marca = marca;
            Modelo = modelo;
            Descripcion = descripcion;
            Color = color;
            Anio = anio;
            Precio_Vta = precio_vta;

        }
        


    }
    

}
