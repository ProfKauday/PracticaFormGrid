using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridView2Form
{
    public partial class formProductos : Form
    {
        public  List<Producto> Productos = new List<Producto>();
        public formProductos()
        {
            InitializeComponent();
        }

        private void formProductos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ListarProductos() 
        
          {
            
          }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos.Add(new Producto(Int32.Parse(txtCodigo.Text), txtDescripcion.Text, double.Parse(txtPrecio.Text)));
            MessageBox.Show("dato guardado correctamente");
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Form formulario = new FormVer(Productos);
            formulario.Show();
            
        }
    }
}
