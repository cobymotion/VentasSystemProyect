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

namespace Ventas_System.procesos
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            DaoProducto dao = new DaoProducto();
            lookUpEdit1.Properties.DataSource = dao.findTodos();
            lookUpEdit1.Properties.DisplayMember = "nombre";
            lookUpEdit1.Properties.ValueMember = "idcat_productos"; 
        }

        private void cambio(object sender, EventArgs e)
        {
            MessageBox.Show(lookUpEdit1.EditValue.ToString());
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
            DateTime fecha2 = dateTimePicker1.Value;
            fecha.AddMonths(6); 

            if(comboBoxEdit1.Text.Equals("HOMBRE"))
                Console.Write("Cuando es hombre");
            
            

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textEdit1.Text);
            DaoProducto cProducto = new DaoProducto();
            DtoProducto producto = cProducto.getProductoById(id);
            textEdit2.Text = producto.Nombre;
            textEdit3.Text = producto.Precio.ToString("C");

        }
        //codigo de barras por medio del lector
        private void Otro(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton3_Click(null, null);
            }
        }
    }
}
