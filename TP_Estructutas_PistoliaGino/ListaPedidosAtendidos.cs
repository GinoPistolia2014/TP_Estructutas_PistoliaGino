using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Estructutas_PistoliaGino
{
    public class ListaPedidosAtendidos
    {
        FormPedidosAtendidos listaAtendidos = new FormPedidosAtendidos();
        private NodoLista Cabeza;

        public ListaPedidosAtendidos()
        {
            Cabeza = null;
        }

        // Insertar en orden cronológico (por hora de ingreso)
        public void Insertar(Pedido pedidoAtendido)
        {
            NodoLista nuevo = new NodoLista(pedidoAtendido);
            if (Cabeza == null || Cabeza.Pedido.HoraPedido > pedidoAtendido.HoraPedido)
            {
                nuevo.Siguiente = Cabeza;
                Cabeza = nuevo;
            }
            else
            {
                NodoLista actual = Cabeza;
                while (actual.Siguiente != null && actual.Siguiente.Pedido.HoraPedido <= pedidoAtendido.HoraPedido)
                {
                    actual = actual.Siguiente;
                }
                nuevo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevo;
            }
        }
    }
}
