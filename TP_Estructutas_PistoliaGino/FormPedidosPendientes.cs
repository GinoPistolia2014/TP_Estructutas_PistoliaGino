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
    public partial class FormPedidosPendientes : Form
    {
        FormPedidosPendientes listapendientes = new FormPedidosPendientes();
        public FormPedidosPendientes()
        {
            InitializeComponent();
        }
        public void MostrarPedidos(List<Pedido> listaPedidos)
        {
            dgvPedidosPendientes.Rows.Clear();
            foreach (var pedido in listaPedidos)
            {
                dgvPedidosPendientes.Rows.Add(pedido.NombreCliente + pedido.OrdenPedido);
            }
        }
    }
}
