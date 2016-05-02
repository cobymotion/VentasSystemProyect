using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CobyMysql.conection;
using ControlVentasSystem.modelo;
//using BackMysql.conexion;

namespace ControlVentasSystem.control
{
    public class DaoProducto : ManageConnection
    {
        public bool addProducto(DtoProducto producto)
        {
            string sql = 
       "INSERT INTO cat_productos VALUES(@param1,@param2,@param3,@param4,@param5)";
            List<MySqlParameter> parametros = 
                new List<MySqlParameter>();
            parametros.Add(new MySqlParameter
                ("@param1",producto.IdcatProducto));
            parametros.Add(new MySqlParameter
                ("@param2", producto.Nombre));
            parametros.Add(new MySqlParameter
                ("@param3", producto.CodigoBarras));
            parametros.Add(new MySqlParameter
                ("@param4", producto.Marca));
            parametros.Add(new MySqlParameter
                ("@param5", producto.Precio));
            bool res = executeQueryUpdate(sql,parametros);
            return res;
        }
    }
}
