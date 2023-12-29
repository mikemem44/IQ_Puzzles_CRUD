namespace IQ_Puzzles_CRUD
{
    partial class Productos
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
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gridProductos = new DataGridView();
            cmbboxModelo = new ComboBox();
            cmbboxMarca = new ComboBox();
            label6 = new Label();
            numPrecioUnit = new NumericUpDown();
            numStock = new NumericUpDown();
            btnMarca = new Button();
            btnModelo = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(160, 160, 236);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(449, 380);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(216, 23);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(160, 160, 236);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.Location = new Point(449, 348);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(216, 26);
            btnEditar.TabIndex = 24;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(160, 160, 236);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.WhiteSmoke;
            btnAgregar.Location = new Point(450, 316);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(216, 26);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(449, 192);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 19;
            label5.Text = "Precio Unitario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(449, 136);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 17);
            label4.TabIndex = 18;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(449, 80);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 17;
            label3.Text = "Modelo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(449, 41);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 23);
            txtNombre.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(449, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 15;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 14;
            label1.Text = "Listado de productos:";
            // 
            // gridProductos
            // 
            gridProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductos.Location = new Point(12, 24);
            gridProductos.Name = "gridProductos";
            gridProductos.RowHeadersWidth = 62;
            gridProductos.RowTemplate.Height = 25;
            gridProductos.Size = new Size(432, 379);
            gridProductos.TabIndex = 13;
            gridProductos.DoubleClick += gridProductos_DoubleClick;
            // 
            // cmbboxModelo
            // 
            cmbboxModelo.FormattingEnabled = true;
            cmbboxModelo.Location = new Point(449, 98);
            cmbboxModelo.Name = "cmbboxModelo";
            cmbboxModelo.Size = new Size(216, 23);
            cmbboxModelo.TabIndex = 26;
            // 
            // cmbboxMarca
            // 
            cmbboxMarca.FormattingEnabled = true;
            cmbboxMarca.Location = new Point(448, 154);
            cmbboxMarca.Name = "cmbboxMarca";
            cmbboxMarca.Size = new Size(216, 23);
            cmbboxMarca.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(449, 251);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 17);
            label6.TabIndex = 28;
            label6.Text = "Stock:";
            // 
            // numPrecioUnit
            // 
            numPrecioUnit.Location = new Point(450, 210);
            numPrecioUnit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrecioUnit.Name = "numPrecioUnit";
            numPrecioUnit.Size = new Size(216, 23);
            numPrecioUnit.TabIndex = 29;
            // 
            // numStock
            // 
            numStock.Location = new Point(449, 269);
            numStock.Name = "numStock";
            numStock.Size = new Size(216, 23);
            numStock.TabIndex = 30;
            // 
            // btnMarca
            // 
            btnMarca.BackColor = Color.FromArgb(160, 160, 236);
            btnMarca.FlatAppearance.BorderSize = 0;
            btnMarca.FlatStyle = FlatStyle.Flat;
            btnMarca.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMarca.ForeColor = Color.WhiteSmoke;
            btnMarca.Location = new Point(560, 128);
            btnMarca.Name = "btnMarca";
            btnMarca.Size = new Size(104, 23);
            btnMarca.TabIndex = 31;
            btnMarca.Text = "Marcas";
            btnMarca.UseVisualStyleBackColor = false;
            btnMarca.Click += btnMarca_Click;
            // 
            // btnModelo
            // 
            btnModelo.BackColor = Color.FromArgb(160, 160, 236);
            btnModelo.FlatAppearance.BorderSize = 0;
            btnModelo.FlatStyle = FlatStyle.Flat;
            btnModelo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModelo.ForeColor = Color.WhiteSmoke;
            btnModelo.Location = new Point(562, 72);
            btnModelo.Name = "btnModelo";
            btnModelo.Size = new Size(104, 23);
            btnModelo.TabIndex = 32;
            btnModelo.Text = "Modelos";
            btnModelo.UseVisualStyleBackColor = false;
            btnModelo.Click += btnModelo_Click;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 130);
            ClientSize = new Size(676, 421);
            Controls.Add(btnModelo);
            Controls.Add(btnMarca);
            Controls.Add(numStock);
            Controls.Add(numPrecioUnit);
            Controls.Add(label6);
            Controls.Add(cmbboxMarca);
            Controls.Add(cmbboxModelo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            ((System.ComponentModel.ISupportInitialize)gridProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private DataGridView gridProductos;
        private ComboBox cmbboxModelo;
        private ComboBox cmbboxMarca;
        private Label label6;
        private NumericUpDown numPrecioUnit;
        private NumericUpDown numStock;
        private Button btnMarca;
        private Button btnModelo;
    }
}