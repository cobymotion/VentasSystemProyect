using ControlVentasSystem.control;
using ControlVentasSystem.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_System.catalogos
{
    public partial class FrmAddProductos : Form
    {
        public FrmAddProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GUarda producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DtoProducto producto = new DtoProducto();
            producto.IdcatProducto = 0;
            producto.Nombre = textEdit1.Text;
            producto.CodigoBarras = textEdit2.Text;
            producto.Marca = textEdit3.Text;
            producto.Precio = Convert.ToDouble(textEdit4.Text);
            /// 
            DaoProducto baseDatos = new DaoProducto();
            bool res = baseDatos.addProducto(producto);
            if (res)
                MessageBox.Show("Se Grabo correctamente");
            else
                MessageBox.Show("Hay un error");
        }
    }
}
