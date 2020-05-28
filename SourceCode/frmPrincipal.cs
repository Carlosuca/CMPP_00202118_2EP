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
                tabContenedor.TabPages[5].Parent = null;
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

            List<Negocio> lista1 = NegocioD.getLista();
            
            cmbNegocioEliminar.DataSource = null;
            cmbNegocioEliminar.ValueMember = "name";
            cmbNegocioEliminar.DisplayMember = "name";
            cmbNegocioEliminar.DataSource = lista1;
            
            List<Negocio> lista2 = NegocioD.getLista();
            
            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idbusiness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = lista2;
            
            List<Producto> lista3 =ProductoD.getLista();
            
            cmbProductoEliminar.DataSource = null;
            cmbProductoEliminar.ValueMember = "idproduct";
            cmbProductoEliminar.DisplayMember = "name";
            cmbProductoEliminar.DataSource = lista3;
            
            List<Direcciones> lista4 =DireccionesD.getLista();
            
            cmbDireccion.DataSource = null;
            cmbDireccion.ValueMember = "idaddress";
            cmbDireccion.DisplayMember = "address";
            cmbDireccion.DataSource = lista4;
            
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

        private void btnAgregarNegocio_Click(object sender, EventArgs e)
        {
            Negocio u = new Negocio();
            u.name = txtNegocio.Text;
            u.description = rtbDescripcion.Text;
            
            try
            {
                NegocioD.nuevoNegocio(u);
                
                MessageBox.Show("Negocio agregado exitosamente", "Enhorabuena",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarNegocio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio " + cmbNegocioEliminar.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NegocioD.eliminarNegocio(cmbNegocioEliminar.Text);
                
                MessageBox.Show("Usuario negocio exitosamente", 
                    "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto u = new Producto();
            u.name = txtProducto.Text;
            
            try
            {
                ProductoD.nuevoProducto(u);
                
                MessageBox.Show("Producto agregado exitosamente", "Enhorabuena",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el producto " + cmbProductoEliminar.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductoD.eliminarProducto(cmbProductoEliminar.Text);
                
                MessageBox.Show("Producto se elimino exitosamente", 
                    "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
            
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            Direcciones u = new Direcciones();
            u.address = txtDireccion.Text;
            
            try
            {
                DireccionesD.nuevoDireccion(u);
                
                MessageBox.Show("Direccion agregada exitosamente", "Enhorabuena",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la direcion " + cmbDireccion.Text + "?", 
                "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DireccionesD.eliminarDireccion(cmbDireccion.Text);
                
                MessageBox.Show("La direccion se elimino exitosamente", 
                    "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                actualizarControles();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            try
            {
                 Producto i = (Producto) cmbProducto1.SelectedItem;
                Direcciones u = (Direcciones) cmbDireccion1.SelectedItem;
                
                OrdenD.realizarOrden(u, i, dtpfecha.Value);
                
                MessageBox.Show("Orden agregada exitosamente", "Enhonabuena",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        
    }
}