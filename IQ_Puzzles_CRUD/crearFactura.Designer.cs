namespace IQ_Puzzles_CRUD
{
    partial class crearFactura
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
            btnAddDetalle = new Button();
            gridDetalles = new DataGridView();
            btnFinalizar = new Button();
            label1 = new Label();
            label2 = new Label();
            lblFechaCompra = new Label();
            label3 = new Label();
            lblTotalCompra = new Label();
            label4 = new Label();
            numMontoPagado = new NumericUpDown();
            lblCambio = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridDetalles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMontoPagado).BeginInit();
            SuspendLayout();
            // 
            // btnAddDetalle
            // 
            btnAddDetalle.BackColor = Color.FromArgb(40, 40, 40);
            btnAddDetalle.FlatAppearance.BorderSize = 0;
            btnAddDetalle.FlatStyle = FlatStyle.Flat;
            btnAddDetalle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddDetalle.ForeColor = Color.LightGray;
            btnAddDetalle.Location = new Point(771, 605);
            btnAddDetalle.Margin = new Padding(4, 5, 4, 5);
            btnAddDetalle.Name = "btnAddDetalle";
            btnAddDetalle.Size = new Size(177, 38);
            btnAddDetalle.TabIndex = 2;
            btnAddDetalle.Text = "Agregar detalle";
            btnAddDetalle.UseVisualStyleBackColor = false;
            btnAddDetalle.Click += btnAddDetalle_Click;
            // 
            // gridDetalles
            // 
            gridDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDetalles.Location = new Point(17, 38);
            gridDetalles.Margin = new Padding(4, 5, 4, 5);
            gridDetalles.Name = "gridDetalles";
            gridDetalles.RowHeadersWidth = 62;
            gridDetalles.RowTemplate.Height = 25;
            gridDetalles.Size = new Size(931, 513);
            gridDetalles.TabIndex = 4;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(40, 40, 40);
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizar.ForeColor = Color.LightGray;
            btnFinalizar.Location = new Point(771, 557);
            btnFinalizar.Margin = new Padding(4, 5, 4, 5);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(177, 38);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar factura";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(17, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 23);
            label1.TabIndex = 6;
            label1.Text = "Listado de detalles de factura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(17, 557);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 7;
            label2.Text = "Fecha compra:";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaCompra.ForeColor = Color.DodgerBlue;
            lblFechaCompra.Location = new Point(17, 590);
            lblFechaCompra.Margin = new Padding(4, 0, 4, 0);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(0, 23);
            lblFechaCompra.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(225, 557);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 9;
            label3.Text = "Total compra:";
            // 
            // lblTotalCompra
            // 
            lblTotalCompra.AutoSize = true;
            lblTotalCompra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCompra.ForeColor = Color.DodgerBlue;
            lblTotalCompra.Location = new Point(225, 590);
            lblTotalCompra.Margin = new Padding(4, 0, 4, 0);
            lblTotalCompra.Name = "lblTotalCompra";
            lblTotalCompra.Size = new Size(0, 23);
            lblTotalCompra.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(391, 557);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(165, 23);
            label4.TabIndex = 11;
            label4.Text = "Monto pagado:";
            // 
            // numMontoPagado
            // 
            numMontoPagado.Location = new Point(392, 582);
            numMontoPagado.Margin = new Padding(4, 5, 4, 5);
            numMontoPagado.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            numMontoPagado.Name = "numMontoPagado";
            numMontoPagado.Size = new Size(164, 31);
            numMontoPagado.TabIndex = 12;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCambio.ForeColor = Color.DodgerBlue;
            lblCambio.Location = new Point(581, 590);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(0, 23);
            lblCambio.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(581, 557);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 16;
            label5.Text = "Cambio:";
            // 
            // crearFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(966, 655);
            Controls.Add(label5);
            Controls.Add(lblCambio);
            Controls.Add(numMontoPagado);
            Controls.Add(label4);
            Controls.Add(lblTotalCompra);
            Controls.Add(label3);
            Controls.Add(lblFechaCompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnFinalizar);
            Controls.Add(gridDetalles);
            Controls.Add(btnAddDetalle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "crearFactura";
            Text = "crearFactura";
            Load += crearFactura_Load;
            ((System.ComponentModel.ISupportInitialize)gridDetalles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMontoPagado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddDetalle;
        private DataGridView gridDetalles;
        private Button btnFinalizar;
        private Label label1;
        private Label label2;
        private Label lblFechaCompra;
        private Label label3;
        private Label lblTotalCompra;
        private Label label4;
        private NumericUpDown numMontoPagado;
        private Label lblCambio;
        private Label label5;
    }
}