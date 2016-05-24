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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
            armarTabla();
        }

        private void armarTabla()
        {
            DaoProducto bd = new DaoProducto();
            gridControl1.DataSource = bd.findTodos();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmAddProductos ventananueva = new FrmAddProductos();
            DialogResult ok = ventananueva.ShowDialog();
            if (ok == DialogResult.OK)
                armarTabla();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.PrintDialog();
        }


        /// <summary>
        /// Este boton sirve para modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            int[] seleccionados = gridView1.GetSelectedRows();
            int pos = seleccionados[0];
            DtoProducto producto = new DtoProducto();
            producto.IdcatProducto = Convert.ToInt32(gridView1.GetRowCellValue
                                     (pos, gridView1.Columns[0]).ToString());
            producto.Nombre = gridView1.GetRowCellValue(pos, gridView1.Columns[1])
                              .ToString();
            producto.CodigoBarras = gridView1.GetRowCellValue(pos, gridView1.Columns[2])
                              .ToString();
            producto.Marca = gridView1.GetRowCellValue(pos, gridView1.Columns[3])
                              .ToString();
            producto.Precio = Convert.ToDouble(gridView1.GetRowCellValue(pos, 
                              gridView1.Columns[4]).ToString());

            FrmAddProductos ventananueva = new FrmAddProductos(producto);
            DialogResult ok = ventananueva.ShowDialog();
            if (ok == DialogResult.OK)
                armarTabla();
        }
    }
}
