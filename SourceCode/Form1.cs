using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        private void poblarControles()
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = UsuarioD.getLista();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedValue.Equals(txtContrasena.Text))
            {
                Usuario u = (Usuario) cmbUsuario.SelectedItem;

                MessageBox.Show("Bienvenido a HugoApp", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    frmPrincipal ventana = new frmPrincipal(u);
                    ventana.Show();
                    this.Hide();
            }
            else
                MessageBox.Show("Contraseña incorrecta", "Error de contrasena",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }//

        private void btnActualizarContrasena_Click(object sender, EventArgs e)
        {
            frmCambiarContrasena unaVentana = new frmCambiarContrasena();
                unaVentana.ShowDialog();
                poblarControles();
            }
    }
}