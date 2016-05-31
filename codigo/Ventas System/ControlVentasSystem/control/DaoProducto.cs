using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CobyMysql.conection;
using ControlVentasSystem.modelo;
using System.Data;
//using BackMysql.conexion;

namespace ControlVentasSystem.control
{
    public class DaoProducto : ManageConnection
    {
        public bool addProducto(DtoProducto producto)
        {
           /* string sql = 
       "INSERT INTO cat_productos VALUES(@param1,@param2,@param3,@param4,@param5)";*/
            string sql = "registrar_producto";
            List<MySqlParameter> parametros = 
                new List<MySqlParameter>();
            parametros.Add(new MySqlParameter
                ("@pid",producto.IdcatProducto));
            parametros.Add(new MySqlParameter
                ("@pnombre", producto.Nombre));
            parametros.Add(new MySqlParameter
                ("@pcodigobarras", producto.CodigoBarras));
            parametros.Add(new MySqlParameter
                ("@pmarca", producto.Marca));
            parametros.Add(new MySqlParameter
                ("@pprecio", producto.Precio));
            bool res = executeStoredProcedureUpdate(sql,parametros);
            return res;
        }

        public DataTable findTodos()
        {
            string sql = "SELECT * FROM cat_productos";
            List<MySqlParameter> parametros = 
                new List<MySqlParameter>();
            DataTable datos = getListSentenciaSQL
                (sql,parametros);
            return datos;
        }



        public bool modifyProducto(DtoProducto producto)
        {
            string sql =
       "UPDATE cat_productos SET  nombre=@param2,codigo_barras=@param3,marca=@param4" +
       ",precio=@param5 WHERE idcat_productos=@param1";
            List<MySqlParameter> parametros =
                new List<MySqlParameter>();
            parametros.Add(new MySqlParameter
                ("@param1", producto.IdcatProducto));
            parametros.Add(new MySqlParameter
                ("@param2", producto.Nombre));
            parametros.Add(new MySqlParameter
                ("@param3", producto.CodigoBarras));
            parametros.Add(new MySqlParameter
                ("@param4", producto.Marca));
            parametros.Add(new MySqlParameter
                ("@param5", producto.Precio));
            bool res = executeQueryUpdate(sql, parametros);
            return res;
        }
    }
}
