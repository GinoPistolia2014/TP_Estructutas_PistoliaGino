namespace TP_Estructutas_PistoliaGino
{
    partial class FormPedidos
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
            this.btnPedir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgbPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPedir
            // 
            this.btnPedir.Location = new System.Drawing.Point(38, 286);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(166, 73);
            this.btnPedir.TabIndex = 0;
            this.btnPedir.Text = "Pedir";
            this.btnPedir.UseVisualStyleBackColor = true;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvHora,
            this.dgvNombre,
            this.dgbPedido});
            this.dataGridView1.Location = new System.Drawing.Point(368, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 426);
            this.dataGridView1.TabIndex = 1;
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
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(38, 121);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 4;
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
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(35, 105);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(40, 13);
            this.lblPedido.TabIndex = 6;
            this.lblPedido.Text = "Pedido";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPedir);
            this.Name = "FormPedidos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgbPedido;
    }
}

