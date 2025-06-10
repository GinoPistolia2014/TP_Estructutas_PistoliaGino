namespace TP_Estructutas_PistoliaGino
{
    partial class FormPedidosPendientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPedidosPendientes = new System.Windows.Forms.DataGridView();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnAtendido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(2, 353);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 70);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // dgvPedidosPendientes
            // 
            this.dgvPedidosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHora,
            this.dgvNombre,
            this.dgbPedido});
            this.dgvPedidosPendientes.Location = new System.Drawing.Point(368, 12);
            this.dgvPedidosPendientes.Name = "dgvPedidosPendientes";
            this.dgvPedidosPendientes.Size = new System.Drawing.Size(420, 426);
            this.dgvPedidosPendientes.TabIndex = 1;
            // 
            // dgvHora
            // 
            this.dgvHora.HeaderText = "Hora";
            this.dgvHora.Name = "dgvHora";
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgbPedido
            // 
            this.dgbPedido.HeaderText = "Pedido";
            this.dgbPedido.Name = "dgbPedido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(38, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(38, 121);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 20);
            this.txtDetalle.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(35, 105);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle";
            // 
            // btnAtendido
            // 
            this.btnAtendido.Location = new System.Drawing.Point(160, 353);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(137, 73);
            this.btnAtendido.TabIndex = 7;
            this.btnAtendido.Text = "Atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click_1);
            // 
            // FormPedidosPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvPedidosPendientes);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormPedidosPendientes";
            this.Text = "Pedidos Pendientes";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPedidosPendientes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbPedido;
        private System.Windows.Forms.Button btnAtendido;
    }
}

