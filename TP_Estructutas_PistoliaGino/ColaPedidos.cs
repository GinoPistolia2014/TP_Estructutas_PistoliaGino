using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Estructutas_PistoliaGino
{
    public class ColaPedidos
    {
        private NodoCola Inicio;
        private NodoCola Fin;

        public int Count { get; private set; }

        public ColaPedidos()
        {
            Inicio = null;
            Fin = null;
            Count = 0;
        }

        // Insertar pedido en la cola
        public void Insertar(string nombre, string pedido)
        {
            NodoCola nuevo = new NodoCola(pedido);
            if (Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else
            {
                Fin.Siguiente = nuevo;
                Fin = nuevo;
            }
            Count++;
        }

        public void Eliminar()
        {
            Pedido aux = Inicio;
            Inicio = Inicio.Siguiente;
            aux = null;
        }
        public List<string> devolverRegistros()
        {
            List<string> lista = new List<string>();

            Pedido aux = Inicio;
            while (aux != null)
            {
                lista.Add(aux.nombre + "," + aux.pedido);
                aux = aux.Siguiente;
            }
            return lista;
        }
    }
}
