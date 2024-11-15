using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto1Seminario2Grupo13
{
    public partial class Form1 : Form
    {
        private List<Producto> _listaProductos = new List<Producto>();
        private Producto _unProducto;
        private MovimientosController movimientosController = new MovimientosController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void sincronizarListado()
        {
            this.lstProductos.Items.Clear();
            try
            {
                _listaProductos = ProductosController.LeerProductos();
                foreach (var producto in _listaProductos)
                {
                    movimientosController.CargarMovimientos(producto);
                    this.lstProductos.Items.Add($"{producto} | Stock actual: {movimientosController.CalcularStockActual(producto)}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error en la lectura de productos: {ex.Message}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreProducto = this.txtNombre.Text;
            if (!string.IsNullOrEmpty(nombreProducto))
            {
                try
                {
                    Producto unProducto = ProductosController.CrearProducto(nombreProducto);
                    sincronizarListado();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hubo un error en la creación de un producto. {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("El nombre no puede ser nulo o vacío.");
            }

            this.txtNombre.Text = string.Empty;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                try
                {
                    _unProducto = this._listaProductos[this.lstProductos.SelectedIndex];
                    int cantidadIngresada = (int)this.nupCantidadMovimineto.Value;

                    Movimiento unMovimiento = null;
                    if (this.cbxTipoMovimiento.SelectedIndex == 0)
                    {
                        unMovimiento = movimientosController.AgregarUnidades(cantidadIngresada, DateTime.Now);
                    }
                    else
                    {
                        unMovimiento = movimientosController.RestarUnidades(cantidadIngresada, DateTime.Now, _unProducto);
                    }
                    if (unMovimiento != null)
                    {
                        movimientosController.AgregarMovimiento(_unProducto, unMovimiento);
                        this.sincronizarListado();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizar el movimiento debido a una cantidad insuficiente en el stock.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hubo un error en la carga de un movimiento. {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }
    }
}
