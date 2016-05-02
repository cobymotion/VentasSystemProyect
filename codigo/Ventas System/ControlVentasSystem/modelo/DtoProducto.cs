using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentasSystem.modelo
{
    public class DtoProducto
    {
        private int idcatProducto;

        public int IdcatProducto
        {
            get { return idcatProducto; }
            set { idcatProducto = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string marca;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string codigoBarras;

        public string CodigoBarras
        {
            get { return codigoBarras; }
            set { codigoBarras = value; }
        }
        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        } 

    }
}
