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
    public partial class Accesos : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        private short getRol;
        public Accesos()
        {
            InitializeComponent();
        }

        private void cargarCombobox()
        {
            List<Rol> listaRoles = BL_Rol.Lista();

            cmbboxRoles.DisplayMember = "nombreRol";
            cmbboxRoles.ValueMember = "ID";
            cmbboxRoles.DataSource = listaRoles;
        }

        private void cargarGridRolFormulario(short rolID)
        {
            try
            {
                gridRolFormulario.DataSource = null;
                gridRolFormulario.DataSource = BL_RolFormulario.listaRolFormulario(rolID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Accesos_Load(object sender, EventArgs e)
        {
            cargarCombobox();
            
        }

        private void cmbboxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbboxRoles_SelectedValueChanged(object sender, EventArgs e)
        {
            getRol = Convert.ToInt16(cmbboxRoles.SelectedValue);
            cargarGridRolFormulario(getRol);
        }

        private void gridRolFormulario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ID_Permiso != 1)
            {
                if (e.ColumnIndex == gridRolFormulario.Columns["Habilitado"].Index && e.RowIndex >= 0)
                {
                    bool nuevoValor = (bool)gridRolFormulario.Rows[e.RowIndex].Cells["Habilitado"].Value;
                    RolFormulario rf = new RolFormulario();
                    rf.ID = Convert.ToInt16(gridRolFormulario.CurrentRow.Cells["ID"].Value.ToString());
                    rf.Activo = nuevoValor;
                    rf.usuarioActualiza = ID_Usuario;
                    if (BL_RolFormulario.Update(rf))
                    {
                        MessageBox.Show("Se actualizo el acceso al formulario");
                        cargarGridRolFormulario(getRol);
                    }
                }
            }
            
        }
    }
}
