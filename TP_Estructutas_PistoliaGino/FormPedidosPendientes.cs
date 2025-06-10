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
        ColaPedidos pedidos = new ColaPedidos();
        FormPedidosAtendidos listaAtendidos = new FormPedidosAtendidos();

        public FormPedidosPendientes()
        {
            InitializeComponent();
            Atender();
            listaAtendidos.Show();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pedidos.Insertar(txtNombre.Text, txtDetalle.Text, DateTime.Now);
            txtNombre.Clear();
            txtDetalle.Clear();
            Atender();
            MostrarPedidosPendientes(Pedido);
        }
        public void Atender()
        {
            if (pedidos.Inicio != null)
            {
                pedidos.Eliminar();

            }
            else MessageBox.Show("Pedido atendido");
        }
        public void MostrarPedidosPendientes(ColaPedidos listaPendientes, ColaPedidos Encargo)
        {
            dgvPedidosPendientes.Rows.Clear();
            List<String> listPendientes = Encargo.devolverRegistros();
            foreach (var pedidos in listPendientes)
            {
                dgvPedidosPendientes.Rows.Add(pedidos.NombreCliente + pedidos.Detalle);
            }
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {

        }
    }
}
