using BL;
using EL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IQ_Puzzles_CRUD
{
    public partial class Modelos : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public Modelos()
        {
            InitializeComponent();
        }

        private void cargarGrid()
        {
            try
            {
                gridModelos.DataSource = null;
                gridModelos.DataSource = BL_Modelo.Lista();
                gridModelos.Columns["Activo"].Visible = false;
                gridModelos.Columns["usuarioActualiza"].Visible = false;
                gridModelos.Columns["fechaActualizacion"].Visible = false;
                gridModelos.Columns["Productos"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modelos_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menuPrincipal mainMenu = Application.OpenForms.OfType<menuPrincipal>().FirstOrDefault();
            if (mainMenu == null)
            {
                mainMenu = new menuPrincipal();
            }

            mainMenu.ID_Usuario = this.ID_Usuario;
            mainMenu.ID_Rol = this.ID_Rol;
            mainMenu.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar Nombre");
                return;
            }
            else
            {
                Modelo m = new Modelo();
                m.nombreModelo = txtNombre.Text;
                m.usuarioRegistro = ID_Usuario;
                if (BL_Modelo.Insert(m).ID > 0)
                {
                    MessageBox.Show("Se ha registrado el modelo con exito");
                    cargarGrid();
                    txtNombre.Text = string.Empty;
                    return;
                }
                MessageBox.Show("No se registro el modelo");
                return;
            }
        }
    }
}
