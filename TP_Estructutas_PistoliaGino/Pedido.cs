using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Estructutas_PistoliaGino
{
    public class Pedido
    {
        public string NombreCliente { get; set; }
        public string Detalle { get; set; }

        public DateTime HoraPedido { get; set; }

        public Pedido Siguiente;

        public Pedido(string nombre, string detalle, DateTime hora)
        {
            this.NombreCliente = nombre;
            this.Detalle = detalle;
            this.HoraPedido = hora;
            this.Siguiente = null;
        }
    }
}
