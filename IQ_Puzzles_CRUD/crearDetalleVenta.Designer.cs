namespace IQ_Puzzles_CRUD
{
    partial class crearDetalleVenta
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
            btnAddtoFactura = new Button();
            gridProductos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            numPrecioVenta = new NumericUpDown();
            numCantidad = new NumericUpDown();
            label3 = new Label();
            lblNombreProd = new Label();
            label4 = new Label();
            label5 = new Label();
            numDescuento = new NumericUpDown();
            label6 = new Label();
            lblTotalDetalle = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDescuento).BeginInit();
            SuspendLayout();
            // 
            // btnAddtoFactura
            // 
            btnAddtoFactura.BackColor = Color.FromArgb(40, 40, 40);
            btnAddtoFactura.FlatAppearance.BorderSize = 0;
            btnAddtoFactura.FlatStyle = FlatStyle.Flat;
            btnAddtoFactura.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddtoFactura.ForeColor = Color.LightGray;
            btnAddtoFactura.Location = new Point(457, 391);
            btnAddtoFactura.Name = "btnAddtoFactura";
            btnAddtoFactura.Size = new Size(138, 23);
            btnAddtoFactura.TabIndex = 0;
            btnAddtoFactura.Text = "Agregar a factura";
            btnAddtoFactura.UseVisualStyleBackColor = false;
            btnAddtoFactura.Click += btnAddtoFactura_Click;
            // 
            // gridProductos
            // 
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(12, 27);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 62;
            gridProductos.RowTemplate.Height = 25;
            gridProductos.Size = new Size(439, 387);
            gridProductos.TabIndex = 2;
            gridProductos.DoubleClick += gridProductos_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 3;
            label1.Text = "Listado de productos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(457, 81);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 4;
            label2.Text = "Precio de venta:";
            // 
            // numPrecioVenta
            // 
            numPrecioVenta.Location = new Point(457, 99);
            numPrecioVenta.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrecioVenta.Name = "numPrecioVenta";
            numPrecioVenta.Size = new Size(130, 23);
            numPrecioVenta.TabIndex = 5;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(457, 177);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(130, 23);
            numCantidad.TabIndex = 7;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(457, 27);
            label3.Name = "label3";
            label3.Size = new Size(151, 17);
            label3.TabIndex = 6;
            label3.Text = "Producto seleccionado:";
            // 
            // lblNombreProd
            // 
            lblNombreProd.AutoSize = true;
            lblNombreProd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProd.ForeColor = Color.DodgerBlue;
            lblNombreProd.Location = new Point(457, 51);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(0, 17);
            lblNombreProd.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(457, 159);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 9;
            label4.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(457, 239);
            label5.Name = "label5";
            label5.Size = new Size(76, 17);
            label5.TabIndex = 10;
            label5.Text = "Descuento:";
            // 
            // numDescuento
            // 
            numDescuento.Location = new Point(457, 257);
            numDescuento.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numDescuento.Name = "numDescuento";
            numDescuento.Size = new Size(130, 23);
            numDescuento.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(457, 316);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 12;
            label6.Text = "Total Detalle:";
            // 
            // lblTotalDetalle
            // 
            lblTotalDetalle.AutoSize = true;
            lblTotalDetalle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDetalle.ForeColor = Color.DodgerBlue;
            lblTotalDetalle.Location = new Point(457, 343);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Size = new Size(0, 17);
            lblTotalDetalle.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(40, 40, 40);
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = Color.LightGray;
            btnCalcular.Location = new Point(457, 362);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(138, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // crearDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(607, 420);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotalDetalle);
            Controls.Add(label6);
            Controls.Add(numDescuento);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNombreProd);
            Controls.Add(numCantidad);
            Controls.Add(label3);
            Controls.Add(numPrecioVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridProductos);
            Controls.Add(btnAddtoFactura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "crearDetalleVenta";
            Opacity = 0.8D;
            Text = "crearDetalleVenta";
            Load += crearDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDescuento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddtoFactura;
        private DataGridView gridProductos;
        private Label label1;
        private Label label2;
        private NumericUpDown numPrecioVenta;
        private NumericUpDown numCantidad;
        private Label label3;
        private Label lblNombreProd;
        private Label label4;
        private Label label5;
        private NumericUpDown numDescuento;
        private Label label6;
        private Label lblTotalDetalle;
        private Button btnCalcular;
    }
}