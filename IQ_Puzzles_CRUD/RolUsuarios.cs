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
    public partial class RolUsuarios : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public RolUsuarios()
        {
            InitializeComponent();
        }

        private void loadGrid()
        {
            try
            {
                gridRolUsuarios.DataSource = BL_RolUsuario.listRolUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void loadComboboxRoles()
        {
            List<Rol> listaRoles = BL_Rol.Lista();

            comboboxRoles.DisplayMember = "nombreRol";
            comboboxRoles.ValueMember = "ID";
            comboboxRoles.DataSource = listaRoles;
        }

        private void gridRolUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RolUsuarios_Load(object sender, EventArgs e)
        {
            loadGrid();
            loadComboboxRoles();
            if (ID_Permiso == 1)
            {
                btnInsertar.Enabled = false;
            }
        }


        private void validarActualizarRol()
        {
            RolUsuario ru = new RolUsuario();
            ru.ID = Convert.ToInt16(gridRolUsuarios.CurrentRow.Cells["RolUsuarioID"].Value.ToString());
            ru.RolID = Convert.ToInt16(comboboxRoles.SelectedValue);
            ru.UsuarioID = Convert.ToInt16(gridRolUsuarios.CurrentRow.Cells["UsuarioID"].Value.ToString());
            ru.usuarioRegistro = ID_Usuario;
            if (BL_RolUsuario.Update(ru))
            {
                MessageBox.Show("Se actualizo el rol de usuario correctamente");
                loadGrid();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el rol de usuario");
                loadGrid();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            validarActualizarRol();
        }

        private void gridRolUsuarios_DoubleClick(object sender, EventArgs e)
        {
            Rol r = new Rol();
            r.ID = Convert.ToInt16(gridRolUsuarios.CurrentRow.Cells["RolID"].Value.ToString());
            if (BL_Rol.getRol(r.ID) != null)
            {
                this.comboboxRoles.Text = BL_Rol.getRol(r.ID);
            }
            else
            {
                this.comboboxRoles.Text = "";
            }
        }
    }
}
