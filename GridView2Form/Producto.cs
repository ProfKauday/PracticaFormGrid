using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView2Form
{
   public class Producto
    {
        private int codigo { get; set; }
        private string descripcion { get; set; }
        private double precio { get; set; }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }
        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Producto(int pCodigo, string p_descripcion, double p_precio)
        {

            codigo = pCodigo;
            descripcion = p_descripcion;
            precio = p_precio;
        }
    }
}

