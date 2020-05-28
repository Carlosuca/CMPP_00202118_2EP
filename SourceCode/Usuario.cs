namespace SourceCode
{
    public class Usuario
    {
        public string userid { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string contrasena { get; set; }
        public bool usertype { get; set; }
        

        public Usuario()
        {
            userid = "";
            fullname = "";
            username = "";
            contrasena = "";
            usertype = false;
            
        }
    }
}