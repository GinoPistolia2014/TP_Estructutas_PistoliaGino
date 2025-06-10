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
        public string OrdenPedido { get; set; }

        public DateTime HoraPedido { get; set; }

        public Pedido Siguiente;

        public Pedido(string nombre, string ordenpedido, DateTime hora)
        {
            this.NombreCliente = nombre;
            this.OrdenPedido = ordenpedido;
            this.HoraPedido = hora;
            this.Siguiente = null;
        }
    }
}
