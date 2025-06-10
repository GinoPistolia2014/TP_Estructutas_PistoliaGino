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
    public partial class FormPedidos : Form
    {
        ColaPedidos pedidos = new ColaPedidos();
        ListaPedidosAtendidos pedidosAtendidos = new ListaPedidosAtendidos();
        FormPedidosPendientes listapendientes = new FormPedidosPendientes();

        public FormPedidos()
        {
            InitializeComponent();
            Pedir();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPedir_Click(object sender, EventArgs e)
        {
            pedidos.Insertar(txtNombre.Text, txtPedido.Text);
            txtNombre.Clear();
            txtPedido.Clear();
        }
        public void Pedir()
        {
            if (pedidos.inicio != null)
            {
                pedidos.listapendientes(pedidos.Inicio);
                pedidos.Eliminar();

            }
            else MessageBox.Show("Pedido atendido");
        }
    }
}
