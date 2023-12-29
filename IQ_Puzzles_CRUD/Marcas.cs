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
    public partial class Marcas : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public Marcas()
        {
            InitializeComponent();
        }

        private void cargarGrid()
        {
            try
            {
                gridMarcas.DataSource = null;
                gridMarcas.DataSource = BL_Marca.Lista();
                gridMarcas.Columns["Activo"].Visible = false;
                gridMarcas.Columns["usuarioActualiza"].Visible = false;
                gridMarcas.Columns["fechaActualizacion"].Visible = false;
                gridMarcas.Columns["Productos"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Marcas_Load(object sender, EventArgs e)
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
                Marca m = new Marca();
                m.nombreMarca = txtNombre.Text;
                m.usuarioRegistro = ID_Usuario;
                if (BL_Marca.Insert(m).ID > 0)
                {
                    MessageBox.Show("Se ha registrado la marca con exito");
                    cargarGrid();
                    txtNombre.Text = string.Empty;
                    return;
                }
                MessageBox.Show("No se registro la marca");
                return;
            }
        }

    }
}
