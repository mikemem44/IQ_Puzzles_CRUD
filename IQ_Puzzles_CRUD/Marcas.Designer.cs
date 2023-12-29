namespace IQ_Puzzles_CRUD
{
    partial class Marcas
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
            btnVolver = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            label1 = new Label();
            gridMarcas = new DataGridView();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridMarcas).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(40, 40, 40);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(384, 226);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(204, 29);
            btnVolver.TabIndex = 24;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(40, 40, 40);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LightGray;
            btnAgregar.Location = new Point(384, 154);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 29);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(384, 56);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 22;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 21;
            label1.Text = "Listado de marcas:";
            // 
            // gridMarcas
            // 
            gridMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridMarcas.Location = new Point(13, 34);
            gridMarcas.Name = "gridMarcas";
            gridMarcas.RowHeadersWidth = 62;
            gridMarcas.RowTemplate.Height = 25;
            gridMarcas.Size = new Size(351, 333);
            gridMarcas.TabIndex = 20;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(25, 25, 25);
            txtNombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.LightGray;
            txtNombre.Location = new Point(384, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 19;
            // 
            // Marcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(600, 381);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridMarcas);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Marcas";
            Opacity = 0.9D;
            Text = "Marcas";
            Load += Marcas_Load;
            ((System.ComponentModel.ISupportInitialize)gridMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Button btnAgregar;
        private Label label2;
        private Label label1;
        private DataGridView gridMarcas;
        private TextBox txtNombre;
    }
}