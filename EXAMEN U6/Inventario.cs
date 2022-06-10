using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_U6
{
    public class Inventario
    {
        //campos de la clase
        public string NombreProducto, DescripcionProducto;
        public int Stock;
        public float Precio;

        //constructor
        public Inventario(string NombreProducto, string DescripcionProducto, int Stock, float Precio)
        {
            this.NombreProducto = NombreProducto;
            this.DescripcionProducto = DescripcionProducto;
            this.Stock = Stock;
            this.Precio = Precio;
        }
    }
}

