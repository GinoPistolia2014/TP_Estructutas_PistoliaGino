using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Estructutas_PistoliaGino
{
    public class NodoCola
    {
        public Pedido Pedido { get; set; }
        public NodoCola Siguiente { get; set; }

        public NodoCola(Pedido pedido)
        {
            Pedido = pedido;
            Siguiente = null;
        }
    }
}
