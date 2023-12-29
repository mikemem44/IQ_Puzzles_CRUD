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
    public partial class crearFactura : Form
    {
        public short ID_Usuario { get; set; }
        public short ID_Rol { get; set; }
        public short ID_Permiso { get; set; }
        public short ID_Factura { get; set; }
        public short ID_Detalle { get; set; }

        private float pagado;
        private float cambio;
        private float total;
        public crearFactura()
        {
            InitializeComponent();
        }


        private void cargarGrid(short facturaID)
        {
            try
            {
                var detallesFactura = BL_Detalle.listDetalleFactura(facturaID);
                gridDetalles.DataSource = detallesFactura;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validarMontoPagado()
        {
            pagado = Convert.ToSingle(numMontoPagado.Value);
            if (pagado < total)
            {
                MessageBox.Show("El monto pagado no puede ser menor al total. Rectifique la cantidad");
                return false;
            }
            return true;
        }

        private void btnAddDetalle_Click(object sender, EventArgs e)
        {
            crearDetalleVenta detalle = Application.OpenForms.OfType<crearDetalleVenta>().FirstOrDefault();
            if (detalle == null)
            {
                detalle = new crearDetalleVenta();
            }
            detalle.ID_Usuario = this.ID_Usuario;
            detalle.ID_Rol = this.ID_Rol;
            detalle.ID_Permiso = this.ID_Permiso;
            detalle.ID_Factura = this.ID_Factura;
            detalle.Show();
            this.Close();
        }

        private void crearFactura_Load(object sender, EventArgs e)
        {
            cargarGrid(ID_Factura);
            calcularSumaTotal();
            this.lblFechaCompra.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void calcularSumaTotal()
        {
            float sumaTotal = 0.0f;

            foreach (DataGridViewRow row in gridDetalles.Rows)
            {
                if (row.Cells["totalDetalle"].Value != null)
                {
                    sumaTotal += Convert.ToSingle(row.Cells["totalDetalle"].Value);
                }
            }

            total = sumaTotal;
            lblTotalCompra.Text = sumaTotal.ToString();

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ID_Detalle == 0)
            {
                MessageBox.Show("Debe crear un detalle para la factura");
                return;
            }
            else
            {
                if (validarMontoPagado() == true)
                {
                    cambio = pagado - total;
                    this.lblCambio.Text = cambio.ToString();
                    Factura f = new Factura();
                    f.ID = ID_Factura;
                    f.totalCompra = total;
                    f.montoPagado = pagado;
                    f.Cambio = cambio;
                    f.usuarioActualiza = ID_Usuario;
                    try
                    {
                        BL_Factura.Update(f);
                        MessageBox.Show("Se ha finalizado la facturacion exito");


                        Producto p = new Producto();
                        p.ID = Convert.ToInt16(gridDetalles.CurrentRow.Cells["ProductoID"].Value.ToString());
                        p.Stock = Convert.ToInt16(gridDetalles.CurrentRow.Cells["Cantidad"].Value.ToString());
                        p.usuarioActualiza = ID_Usuario;
                        BL_Producto.actualizarStock(p);

                        menuPrincipal mainMenu = Application.OpenForms.OfType<menuPrincipal>().FirstOrDefault();
                        if (mainMenu == null)
                        {
                            mainMenu = new menuPrincipal();
                        }

                        mainMenu.ID_Usuario = this.ID_Usuario;
                        mainMenu.ID_Rol = this.ID_Rol;
                        mainMenu.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;
                }


            }
        }


    }
}
