using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Estructutas_PistoliaGino
{
    public partial class FormPedidosAtendidos : Form
    {
        public FormPedidosAtendidos()
        {
            InitializeComponent();
        }
        public void MostrarPedidos(List<Pedido> listaAtendidos)
        {
            dgvPedidosAtendidos.Rows.Clear();
            foreach (var pedido in listaAtendidos)
            {
                dgvPedidosAtendidos.Rows.Add(pedido.NombreCliente + pedido.Detalle);
            }
        }
    }
}
