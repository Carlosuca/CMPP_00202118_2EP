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
            
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = lista;
            
            dvgUsuarios.DataSource = null;
            dvgUsuarios.DataSource = lista;
        }
        
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + username.username + "?", 
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            /*else
            {
                e.Cancel = false;
                MessageBox.Show("Ha sucedido un error, favor intente dentro de un minuto.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoUsuario.Text.Length >= 5)
                {
                    UsuarioD.crearNuevo(txtNuevoUsuario.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a usuario y nombre, no administrador", 
                        "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtNuevoUsuario.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)", 
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.", 
                    "Lo siento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbUsuario.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioD.eliminar(cmbUsuario.Text);
                
                MessageBox.Show("Usuario eliminado exitosamente", 
                    "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarControles();
        }
    }
}