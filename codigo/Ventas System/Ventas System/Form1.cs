using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas_System.catalogos;

namespace Ventas_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Que este boton solo sirve para mandar llamar la otra ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddProductos frmAddProducto = new FrmAddProductos();
            frmAddProducto.ShowDialog();
        }
    }
}
