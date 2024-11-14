using C2_110924;

namespace Proyecto1Seminario2Grupo13
{
    public partial class Form1 : Form
    {
        // Colección de productos para usar
        private List<Producto> _listaProductos = new List<Producto>();
        // Un producto en particular para usar
        private Producto _unProducto;
        // Instancia del controlador de movimientos
        private MovimientosController movimientosController = new MovimientosController();

        public Form1()
        {
            InitializeComponent();
        }

        private void sincronizarListado()
        {
            this.lstProductos.Items.Clear();
            try
            {
                _listaProductos = ProductosController.LeerProductos();
                foreach (var producto in _listaProductos)
                {
                    this.lstProductos.Items.Add(producto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error en la lectura de productos: {ex.Message}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = this.txtNombre.Text;
                int cantidadInicial = int.Parse(this.nupCantidad.Text);

                // Usamos el método CrearProducto del controlador para generar el ID automáticamente
                Producto unProducto = ProductosController.CrearProducto(nombreProducto, cantidadInicial);

                sincronizarListado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Soy un programa malo y no me gusta funcionar. {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            sincronizarListado();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstProductos.SelectedIndex != -1)
            {
                // Hay algo seleccionado
                _unProducto = this._listaProductos[this.lstProductos.SelectedIndex];
                int cantidadIngresada = (int)this.nupCantidadMovimineto.Value;
                if (this.cbxTipoMovimiento.SelectedIndex == 0)
                {
                    // Ingreso
                    Movimiento unMovimiento = movimientosController.agregarUnidades(cantidadIngresada, DateTime.Now);
                    movimientosController.AgregarMovimiento(_unProducto, unMovimiento);
                }
                else
                {
                    // Egreso
                    try
                    {
                        Movimiento unMovimiento = movimientosController.restarUnidades(cantidadIngresada, DateTime.Now);
                        movimientosController.AgregarMovimiento(_unProducto, unMovimiento);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.sincronizarListado();
            }
            else
            {
                MessageBox.Show("Se tiene que seleccionar un Producto desde la lista.");
            }
        }
    }

}
