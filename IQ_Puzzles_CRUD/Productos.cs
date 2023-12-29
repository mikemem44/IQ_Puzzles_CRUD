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
    public partial class Productos : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public Productos()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtNombre.Text = string.Empty;
            cmbboxMarca.SelectedIndex = -1;
            cmbboxModelo.SelectedIndex = -1;
            numPrecioUnit.Value = 0;
            numStock.Value = 0;
        }

        public void cargarModelos()
        {
            List<Modelo> listaModelos = BL_Modelo.Lista();

            cmbboxModelo.DisplayMember = "nombreModelo";
            cmbboxModelo.ValueMember = "ID";
            cmbboxModelo.DataSource = listaModelos;
        }

        public void cargarMarcas()
        {
            List<Marca> listaMarcas = BL_Marca.Lista();

            cmbboxMarca.DisplayMember = "nombreMarca";
            cmbboxMarca.ValueMember = "ID";
            cmbboxMarca.DataSource = listaMarcas;
        }

        private void cargarGrid()
        {
            try
            {
                gridProductos.DataSource = null;
                gridProductos.DataSource = BL_Producto.Lista();
                gridProductos.Columns["Activo"].Visible = false;
                gridProductos.Columns["Modelo"].Visible = false;
                gridProductos.Columns["Marca"].Visible = false;
                gridProductos.Columns["Detalles"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cargarGrid();
            cargarModelos();
            cargarMarcas();
            if (ID_Permiso == 1)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnMarca.Enabled = false;
                btnModelo.Enabled = false;
            }
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingresar nombre");
                return false;
            }
            if (cmbboxMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar marca");
                return false;
            }
            if (cmbboxModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar modelo");
                return false;
            }
            if (numPrecioUnit.Value < 1)
            {
                MessageBox.Show("Ingrese un precio valido");
                return false;
            }
            if (numPrecioUnit.Value > 10000)
            {
                MessageBox.Show("Precio maximo es 10,000.00");
                return false;
            }
            if (numStock.Value < 1)
            {
                MessageBox.Show("Ingrese una cantidad valida");
                return false;
            }
            if (numStock.Value > 100)
            {
                MessageBox.Show("La cantidad maxima es 100");
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Producto p = new Producto();
                p.nombreProducto = txtNombre.Text;
                p.ModeloID = Convert.ToInt16(cmbboxModelo.SelectedValue);
                p.MarcaID = Convert.ToInt16(cmbboxMarca.SelectedValue);
                p.precioUnitario = Convert.ToSingle(numPrecioUnit.Value);
                p.Stock = Convert.ToInt16(numStock.Value);
                p.usuarioRegistro = ID_Usuario;
                if (BL_Producto.Insert(p).ID > 0)
                {
                    MessageBox.Show("Se ha registrado el producto con exito");
                    cargarGrid();
                    Clear();
                    return;
                }
                MessageBox.Show("No se registro el producto");
                return;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Producto p = new Producto();
                p.ID = Convert.ToInt16(gridProductos.CurrentRow.Cells["ID"].Value.ToString());
                p.nombreProducto = txtNombre.Text;
                p.ModeloID = Convert.ToInt16(cmbboxModelo.SelectedValue);
                p.MarcaID = Convert.ToInt16(cmbboxMarca.SelectedValue);
                p.precioUnitario = Convert.ToSingle(numPrecioUnit.Value);
                p.Stock = Convert.ToInt16(numStock.Value);
                p.usuarioActualiza = ID_Usuario;
                BL_Producto.Update(p);
                MessageBox.Show("Se actualizo el producto correctamente");
                cargarGrid();
                Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.ID = Convert.ToInt16(gridProductos.CurrentRow.Cells["ID"].Value.ToString());
            p.usuarioActualiza = ID_Usuario;
            if (!(BL_Producto.Archivar(p)))
            {
                MessageBox.Show("No se pudo eliminar el producto");
                cargarGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("Se elimino el producto correctamente");
                cargarGrid();
                Clear();
            }
        }

        private void gridProductos_DoubleClick(object sender, EventArgs e)
        {
            this.txtNombre.Text = gridProductos.CurrentRow.Cells["nombreProducto"].Value.ToString();
            Modelo mo = new Modelo();
            mo.ID = Convert.ToInt16(gridProductos.CurrentRow.Cells["ModeloID"].Value.ToString());
            if (BL_Modelo.getModelo(mo.ID) != null)
            {
                this.cmbboxModelo.Text = BL_Modelo.getModelo(mo.ID);
            }
            else
            {
                this.cmbboxModelo.Text = " ";
            }

            Marca ma = new Marca();
            ma.ID = Convert.ToInt16(gridProductos.CurrentRow.Cells["MarcaID"].Value.ToString());
            if (BL_Marca.getMarca(ma.ID) != null)
            {
                this.cmbboxMarca.Text = BL_Marca.getMarca(ma.ID);
            }
            else
            {
                this.cmbboxMarca.Text = " ";
            }

            this.numPrecioUnit.Value = Convert.ToInt16(gridProductos.CurrentRow.Cells["precioUnitario"].Value.ToString());
            this.numStock.Value = Convert.ToInt16(gridProductos.CurrentRow.Cells["Stock"].Value.ToString());
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol,3) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Modelos modelo = new Modelos();
                modelo.ID_Usuario = this.ID_Usuario;
                modelo.ID_Rol = this.ID_Rol;
                modelo.ID_Permiso = this.ID_Permiso;
                modelo.Show();
                this.Hide();
            }
            
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            if (BL_RolFormulario.verificarAccesoFormulario(ID_Rol, 4) == false)
            {
                MessageBox.Show("Su usuario no tiene acceso a este formulario. Contactese con un administrador");
                return;
            }
            else
            {
                Marcas marca = new Marcas();
                marca.ID_Usuario = this.ID_Usuario;
                marca.ID_Rol = this.ID_Rol;
                marca.ID_Permiso = this.ID_Permiso;
                marca.Show();
                this.Hide();
            }
            
        }
    }
}
