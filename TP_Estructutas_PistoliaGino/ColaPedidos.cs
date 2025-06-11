using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Estructutas_PistoliaGino
{
    public class ColaPedidos
    {
        public NodoCola Inicio;
        public NodoCola Fin;



        public ColaPedidos()
        {
            Inicio = null;
            Fin = null;
           
        }

        // Insertar pedido en la cola
        public void Insertar(string nombre, string detalle, DateTime hora)
        {
            Pedido pedido = new Pedido(nombre, detalle, hora);
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
        }

        public void Eliminar()
        {
            NodoCola aux = Inicio;
            Inicio = Inicio.Siguiente;
            aux = null;
        }
        public List<Pedido> devolverRegistros()
        {
            List<Pedido> lista = new List<Pedido>();

            NodoCola aux = Inicio;
            while (aux != null)
            {
                lista.Add(aux.Pedido);
                aux = aux.Siguiente;
            }
            return lista;
        }
    }
}
