using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class OrdenD
    {
        public static List<Orden> getLista()
        {
            string sql = "select * from ORDER";

            DataTable dt = Conexion.realizarConsulta(sql);
            
            List<Orden> lista = new List<Orden>();
            foreach (DataRow fila in dt.Rows)
            {
                Orden p = new Orden();
                p.idorder = Convert.ToInt32(fila[0].ToString());
                p.fecha = DateTime.Parse(fila[1].ToString());
                p.idaddress = Convert.ToInt32(fila[2].ToString());
                p.idproduct = Convert.ToInt32(fila[3].ToString());
                
                lista.Add(p);
            }
            return lista;
        }
        public static void realizarOrden(Usuario u, Producto i, DateTime fecha, Orden p)
        {
            string createDate = fecha.ToString("yyyy/MM/dd");
            
            string sql = String.Format(
                
                "INSERT INTO ORDER ( idorder, createDate, idaddress, idproducto)" +
                "values( {0}, '{1}', {2}, {3});",
                p.idorder, createDate, i.idbusiness,i.idproduct );

            Conexion.realizarAccion(sql);
        }

        public static void realizarOrden(Direcciones direcciones, Producto producto, DateTime dtpfechaValue)
        {
            
        }
    }
}
