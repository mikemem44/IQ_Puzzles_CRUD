namespace IQ_Puzzles_CRUD
{
    partial class Accesos
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
            label1 = new Label();
            label2 = new Label();
            gridRolFormulario = new DataGridView();
            cmbboxRoles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gridRolFormulario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(13, 346);
            label1.Name = "label1";
            label1.Size = new Size(112, 17);
            label1.TabIndex = 11;
            label1.Text = "Listado de roles:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 4);
            label2.Name = "label2";
            label2.Size = new Size(221, 20);
            label2.TabIndex = 12;
            label2.Text = "Listado de roles y formularios:";
            // 
            // gridRolFormulario
            // 
            gridRolFormulario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridRolFormulario.Location = new Point(12, 27);
            gridRolFormulario.Name = "gridRolFormulario";
            gridRolFormulario.RowHeadersWidth = 62;
            gridRolFormulario.RowTemplate.Height = 25;
            gridRolFormulario.Size = new Size(639, 301);
            gridRolFormulario.TabIndex = 13;
            gridRolFormulario.CellValueChanged += gridRolFormulario_CellValueChanged;
            // 
            // cmbboxRoles
            // 
            cmbboxRoles.FormattingEnabled = true;
            cmbboxRoles.Location = new Point(139, 344);
            cmbboxRoles.Margin = new Padding(2);
            cmbboxRoles.Name = "cmbboxRoles";
            cmbboxRoles.Size = new Size(213, 23);
            cmbboxRoles.TabIndex = 14;
            cmbboxRoles.SelectedIndexChanged += cmbboxRoles_SelectedIndexChanged;
            cmbboxRoles.SelectedValueChanged += cmbboxRoles_SelectedValueChanged;
            // 
            // Accesos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 130);
            ClientSize = new Size(660, 382);
            Controls.Add(cmbboxRoles);
            Controls.Add(gridRolFormulario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accesos";
            Text = "Accesos";
            Load += Accesos_Load;
            ((System.ComponentModel.ISupportInitialize)gridRolFormulario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView gridRolFormulario;
        private ComboBox cmbboxRoles;
    }
}