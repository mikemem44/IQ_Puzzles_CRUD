namespace IQ_Puzzles_CRUD
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewVenta = new Button();
            gridFacturas = new DataGridView();
            label1 = new Label();
            cmbboxCliente = new ComboBox();
            label2 = new Label();
            gridDetalles = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            SuspendLayout();
            // 
            // btnNewVenta
            // 
            btnNewVenta.BackColor = Color.FromArgb(160, 160, 236);
            btnNewVenta.FlatAppearance.BorderSize = 0;
            btnNewVenta.FlatStyle = FlatStyle.Flat;
            btnNewVenta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewVenta.ForeColor = Color.WhiteSmoke;
            btnNewVenta.Location = new Point(483, 388);
            btnNewVenta.Name = "btnNewVenta";
            btnNewVenta.Size = new Size(173, 23);
            btnNewVenta.TabIndex = 0;
            btnNewVenta.Text = "Crear nueva factura";
            btnNewVenta.UseVisualStyleBackColor = false;
            btnNewVenta.Click += btnNewVenta_Click;
            // 
            // gridFacturas
            // 
            gridFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridFacturas.Location = new Point(12, 25);
            gridFacturas.Name = "gridFacturas";
            gridFacturas.RowHeadersWidth = 62;
            gridFacturas.RowTemplate.Height = 25;
            gridFacturas.Size = new Size(644, 189);
            gridFacturas.TabIndex = 1;
            gridFacturas.DoubleClick += gridFacturas_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 391);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 17);
            label1.TabIndex = 2;
            label1.Text = "Seleccionar cliente:";
            // 
            // cmbboxCliente
            // 
            cmbboxCliente.FormattingEnabled = true;
            cmbboxCliente.Location = new Point(149, 389);
            cmbboxCliente.Margin = new Padding(2);
            cmbboxCliente.Name = "cmbboxCliente";
            cmbboxCliente.Size = new Size(204, 23);
            cmbboxCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(8, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 4;
            label2.Text = "Listado de facturas:";
            // 
            // gridDetalles
            // 
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Location = new Point(12, 246);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.RowHeadersWidth = 62;
            gridDetalles.RowTemplate.Height = 25;
            gridDetalles.Size = new Size(644, 136);
            gridDetalles.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(12, 228);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 17);
            label3.TabIndex = 6;
            label3.Text = "Detalles de compra por factura:";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 130);
            ClientSize = new Size(676, 421);
            Controls.Add(label3);
            Controls.Add(gridDetalles);
            Controls.Add(label2);
            Controls.Add(cmbboxCliente);
            Controls.Add(label1);
            Controls.Add(gridFacturas);
            Controls.Add(btnNewVenta);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)gridFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewVenta;
        private DataGridView gridFacturas;
        private Label label1;
        private ComboBox cmbboxCliente;
        private Label label2;
        private DataGridView gridDetalles;
        private Label label3;
    }
}