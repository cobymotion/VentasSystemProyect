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
using Ventas_System.procesos;

namespace Ventas_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProducto == null)
                frmProducto = new FrmProductos();
            if (frmProducto.IsDisposed)
                frmProducto = new FrmProductos();
            frmProducto.MdiParent = this;
            frmProducto.BringToFront();
            frmProducto.Show();
        }

        FrmProductos frmProducto=null;
        private void btnProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmProducto == null) 
                   frmProducto = new FrmProductos();
            if(frmProducto.IsDisposed)
                frmProducto = new FrmProductos();
            frmProducto.MdiParent = this;
            frmProducto.BringToFront();
            frmProducto.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmVentas frventas = new FrmVentas();
            frventas.ShowDialog();
        }
    }
}
