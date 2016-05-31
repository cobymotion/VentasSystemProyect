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
        bool actualiza = false; 
        DtoProducto producto; 
        public FrmAddProductos(DtoProducto producto) : this()
        {
            textEdit1.Enabled = false;
            textEdit1.Text = producto.Nombre;
            textEdit2.Text = producto.CodigoBarras;
            textEdit3.Text = producto.Marca;
            textEdit4.Text = Convert.ToString(producto.Precio);
            textEdit2.Focus(); 
            actualiza = true; 
            this.producto = producto;
        }

        /// <summary>
        /// GUarda producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(!actualiza)
                producto = new DtoProducto();
            //producto.IdcatProducto = 0;
            producto.Nombre = textEdit1.Text;
            producto.CodigoBarras = textEdit2.Text;
            producto.Marca = textEdit3.Text;
            producto.Precio = Convert.ToDouble(textEdit4.Text);
            /// 
            DaoProducto baseDatos = new DaoProducto();
            bool res;
            if (actualiza)
                res = baseDatos.modifyProducto(producto);
            else
               res = baseDatos.addProducto(producto);
            if (res)
            {
                MessageBox.Show("Se Grabo correctamente");
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Hay un error");
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
