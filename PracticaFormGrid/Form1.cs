using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormGrid
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Rows crea una nueva fila y nos devuelve el indice de la fila actual
           int n = dgvProductos.Rows.Add();
           // Colocamos Informacion
            dgvProductos.Rows[n].Cells[0].Value = textBox1.Text;
           dgvProductos.Rows[n].Cells[1].Value = textBox2.Text; 
           dgvProductos.Rows[n].Cells[2].Value = textBox3.Text;
           textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n!=-1 ) {
                label4.Text = (string)dgvProductos.Rows[n].Cells[1].Value;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string texto = (string)dgvProductos.Rows[n].Cells[1].Value;
            try {

                //if (n != -1) & (n != -1)
                if ((n != -1) && (texto != null))
                {
                    MessageBox.Show("Borrando fila Actual");

                    dgvProductos.Rows.RemoveAt(n);
            }
          }
      catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
           Form formulario = new Form2();
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
