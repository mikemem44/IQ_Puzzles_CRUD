namespace IQ_Puzzles_CRUD
{
    partial class Modelos
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
            txtNombre = new TextBox();
            gridModelos = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)gridModelos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(383, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 23);
            txtNombre.TabIndex = 0;
            // 
            // gridModelos
            // 
            gridModelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridModelos.Location = new Point(12, 30);
            gridModelos.Name = "gridModelos";
            gridModelos.RowHeadersWidth = 62;
            gridModelos.RowTemplate.Height = 25;
            gridModelos.Size = new Size(351, 333);
            gridModelos.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 15;
            label1.Text = "Listado de modelos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(383, 52);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 16;
            label2.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(40, 40, 40);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.LightGray;
            btnAgregar.Location = new Point(383, 150);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(40, 40, 40);
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.LightGray;
            btnVolver.Location = new Point(383, 222);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(204, 29);
            btnVolver.TabIndex = 18;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Modelos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(600, 381);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridModelos);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modelos";
            Opacity = 0.9D;
            Text = "Modelos";
            Load += Modelos_Load;
            ((System.ComponentModel.ISupportInitialize)gridModelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private DataGridView gridModelos;
        private Label label1;
        private Label label2;
        private Button btnAgregar;
        private Button btnVolver;
    }
}