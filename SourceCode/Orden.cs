using System;
using System.Globalization;

namespace SourceCode
{
    public class Orden
    {
        public int idorder { get; set; }
        public DateTime fecha { get; set;}
        public int idaddress { get; set; }
        public int idproduct { get; set; }

        public Orden()
        {
            idorder = idorder;
            fecha = fecha = DateTime.ParseExact(fecha.ToString(), "yyyy/MM/dd", CultureInfo.InvariantCulture);
            idaddress = idaddress;
            idproduct = idproduct;
        }

}
}