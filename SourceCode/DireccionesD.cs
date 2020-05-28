using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class DireccionesD
    {
        public static List<Direcciones> getLista()
        {
            string sql = "select * from ADDRESS";
        
            DataTable dt = Conexion.realizarConsulta(sql);
        
            List<Direcciones> lista = new List<Direcciones>();
            foreach (DataRow fila in dt.Rows)
            {
                Direcciones u = new Direcciones();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.idusuario = Convert.ToInt32(fila[1].ToString());
                u.address = fila[2].ToString();
    
                lista.Add(u);
            }
            return lista;

        }
        public static void nuevoDireccion(Direcciones u)
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS( idusuario, address)" +
                $"values( '{1}', {0});",
                u.idusuario, u.address);
                
            Conexion.realizarAccion(sql);
        }
        public static void eliminarDireccion(string address)
        {
            string sql = String.Format(
                "DELETE FROM ADDRESS WHERE address = '{0}'", 
                address);
            
            Conexion.realizarAccion(sql);
        }
    }
}