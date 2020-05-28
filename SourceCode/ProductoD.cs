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
                Producto i = new Producto();
                i.idproduct = Convert.ToInt32(fila[0].ToString());
                i.idbusiness = Convert.ToInt32(fila[1].ToString());
                i.name = fila[2].ToString();
    
                lista.Add(i);
            }
            return lista;

        }
        public static void nuevoProducto(Producto i)
        {
            string sql = String.Format(
                "INSERT INTO PRODUCT( idbusiness, name)" +
                "values( '{1}', '{0}');",
                 i.idbusiness, i.name);
                
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