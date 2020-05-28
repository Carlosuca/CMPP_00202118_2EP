using System;
using System.Collections.Generic;
using System.Data;

namespace SourceCode
{
    public class NegocioD
    {
        public static List<Negocio> getLista()
                {
                    string sql = "select * from BUSINESS";
        
                    DataTable dt = Conexion.realizarConsulta(sql);
        
                    List<Negocio> lista = new List<Negocio>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        Negocio u = new Negocio();
                        u.idbusiness = Convert.ToInt32(fila[0].ToString());
                        u.name = fila[1].ToString();
                        u.description = fila[2].ToString();
                     
                        lista.Add(u);
                    }
                    return lista;
                }
        public static void nuevoNegocio(Negocio u)
        {
            string sql = String.Format(
                "INSERT INTO BUSINESS(name, description)" +
                "values('{0}', '{1}');",
                u.name, u.description);
                
            Conexion.realizarAccion(sql);
        }
        public static void eliminarNegocio(string name)
        {
            string sql = String.Format(
                "DELETE FROM BUSINESS WHERE name = '{0}'", 
                name);
            
            Conexion.realizarAccion(sql);
        }

    }
}