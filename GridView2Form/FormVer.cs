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
    public partial class FormVer : Form
    {
        private List<Producto> ListaProducto = new List<Producto>();
        private int n;

        public FormVer(List<Producto> pLista)
        {
            InitializeComponent();
            ListaProducto = pLista;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            foreach (Producto prod in ListaProducto)

            {
                //crea una fila en el gridview usando la lista de productos
                dgvProductos.Rows.Add(prod.Codigo, prod.Descripcion, prod.Precio);

   
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //muestro abajo el codigo cuando hago doble click en la celda
            //n es el index en la lista y en el gridview
            int n = e.RowIndex;
          
            // valida de que no sea la celda en blanco, o sea la primera si no hay datos, y que tampoco sea la de titulos
            if (n != -1) 
            {
                if ((string)dgvProductos.Rows[n].Cells[1].Value != null) { 
                lblDatos.Text ="Codigo nro: " +  (int)dgvProductos.Rows[n].Cells[0].Value;
                }

            }

         
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borra el contenido de fila seleccionada 

            int a = 0;
            //Indice de donde esta parado el usuario en el datagriview
            a = dgvProductos.CurrentCell.RowIndex;

            
                string texto = (string)dgvProductos.Rows[a].Cells[1].Value;
            int codigo2 = Convert.ToInt32(dgvProductos.Rows[a].Cells[0].Value);



            //valida de que no sea la celda en blanco , o sea la primera si no hay datos, y que tampoco sea la de titulos


            if ((a != -1) && (texto!=null))
                {
                int codigo = Convert.ToInt32(dgvProductos.Rows[a].Cells[0].Value);
                MessageBox.Show("Borrando fila Actual ");

                    dgvProductos.Rows.RemoveAt(a);
                
                   

                    foreach (Producto prod in ListaProducto)
                    {

                        if (codigo == prod.Codigo)
                        {
                            ListaProducto.Remove(prod);
                            break;

                        }


                    }


                    lblDatos.Text = "";
                }
            }
            
              }
            
        }
    
