using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmPrincipal : Form
    {
        private Usuario  username;
        public frmPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            username = pUsuario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = 
                "Bienvenido " + username.username + " [" + (username.usertype ? "Administrador" : "Usuario") + "]";

            if (username.usertype)
            {
                actualizarControles();
                tabContenedor.TabPages[0].Parent = null;
            }
            else
            {
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
                tabContenedor.TabPages[1].Parent = null;
            }
        }
        
        private void actualizarControles()
        {
            List<Usuario> lista = UsuarioD.getLista();
        }
    }
}