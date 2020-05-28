using System;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void frmCambiarContrasena_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contrasena";
            cmbUsuario.DisplayMember = "username";
            cmbUsuario.DataSource = UsuarioD.getLista();
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuario.SelectedValue.Equals((txtActual.Text));
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuarioD.actualizarContra(cmbUsuario.Text, txtNueva.Text);
                    
                    MessageBox.Show("Contraseña actualizada exitosamente", 
                        "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("La contrasena no se pudo actualizar", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Favor verifique que los datos coincidan", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}