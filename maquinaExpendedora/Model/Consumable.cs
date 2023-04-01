using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectNet.Model
{
    public class Consumable
    {
        public Consumable() { }

        public Consumable(int id, int precio, int cantidad, string nombre)
        {
            this.id = id;
            this.precio = precio;
            this.cantidad = cantidad;
            this.nombre = nombre;
        }

        public int id { get; set; }
        public int precio { get; set; }
        public int cantidad { get; set; }
        public string nombre { get; set; }
    }
}
