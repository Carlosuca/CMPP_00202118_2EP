using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class ProductoD
    {
        public static List<Producto> getLista()
        {
            string sql = "select * from PRODUCT";
        
            DataTable dt = Conexion.realizarConsulta(sql);
        
            List<Producto> lista = new List<Producto>();
            foreach (DataRow fila in dt.Rows)
            {
                Producto u = new Producto();
                u.idproduct = Convert.ToInt32(fila[0].ToString());
                u.idbusiness = Convert.ToInt32(fila[1].ToString());
                u.name = fila[2].ToString();
    
                lista.Add(u);
            }
            return lista;

        }
        public static void nuevoProducto(Producto u)
        {
            string sql = String.Format(
                "INSERT INTO PRODUCT(idproduct, idbusiness, name )" +
                "values({0}, {1}, '{2}');",
                u.idproduct, u.idbusiness, u.name);
                
            Conexion.realizarAccion(sql);
        }
        public static void eliminarProducto(string name)
        {
            string sql = String.Format(
                "DELETE FROM PRODUCT WHERE name = '{0}'", 
                name);
            
            Conexion.realizarAccion(sql);
        }
    }
}