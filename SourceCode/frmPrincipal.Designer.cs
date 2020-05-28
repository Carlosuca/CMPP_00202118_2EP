using System.ComponentModel;

namespace SourceCode
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tabContenedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNegocio = new System.Windows.Forms.TextBox();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.cmbNegocioEliminar = new System.Windows.Forms.ComboBox();
            this.btnAgregarNegocio = new System.Windows.Forms.Button();
            this.btnEliminarNegocio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbNegocio = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cmbProductoEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbProducto1 = new System.Windows.Forms.ComboBox();
            this.cmbDireccion1 = new System.Windows.Forms.ComboBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnPedido = new System.Windows.Forms.Button();
            this.tabContenedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dvgUsuarios)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContenedor
            // 
            this.tabContenedor.Controls.Add(this.tabPage1);
            this.tabContenedor.Controls.Add(this.tabPage2);
            this.tabContenedor.Controls.Add(this.tabPage3);
            this.tabContenedor.Controls.Add(this.tabPage4);
            this.tabContenedor.Controls.Add(this.tabPage5);
            this.tabContenedor.Controls.Add(this.tabPage6);
            this.tabContenedor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabContenedor.Location = new System.Drawing.Point(0, 63);
            this.tabContenedor.Name = "tabContenedor";
            this.tabContenedor.SelectedIndex = 0;
            this.tabContenedor.Size = new System.Drawing.Size(522, 378);
            this.tabContenedor.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabContenedor.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnPedido);
            this.tabPage1.Controls.Add(this.dgvPedidos);
            this.tabPage1.Controls.Add(this.dtpfecha);
            this.tabPage1.Controls.Add(this.cmbDireccion1);
            this.tabPage1.Controls.Add(this.cmbProducto1);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ordenes (admin)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnActualizar);
            this.tabPage3.Controls.Add(this.btnEliminarUsuario);
            this.tabPage3.Controls.Add(this.btnCrearUsuario);
            this.tabPage3.Controls.Add(this.dvgUsuarios);
            this.tabPage3.Controls.Add(this.cmbUsuario);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtNuevoUsuario);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(514, 350);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnEliminarProducto);
            this.tabPage5.Controls.Add(this.cmbProductoEliminar);
            this.tabPage5.Controls.Add(this.btnAgregarProducto);
            this.tabPage5.Controls.Add(this.txtProducto);
            this.tabPage5.Controls.Add(this.cmbNegocio);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(514, 350);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Productos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(4, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(514, 24);
            this.lblBienvenido.TabIndex = 1;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Usuario";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(153, 28);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(166, 23);
            this.txtNuevoUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eliminar Usuario";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(153, 69);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(166, 23);
            this.cmbUsuario.TabIndex = 3;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(8, 124);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.Size = new System.Drawing.Size(498, 186);
            this.dvgUsuarios.TabIndex = 4;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(349, 28);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(133, 23);
            this.btnCrearUsuario.TabIndex = 5;
            this.btnCrearUsuario.Text = "Crear";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(349, 69);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(133, 23);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(153, 316);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(177, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar Tabla";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnEliminarNegocio);
            this.tabPage4.Controls.Add(this.btnAgregarNegocio);
            this.tabPage4.Controls.Add(this.cmbNegocioEliminar);
            this.tabPage4.Controls.Add(this.rtbDescripcion);
            this.tabPage4.Controls.Add(this.txtNegocio);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(514, 350);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Negocios";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre de negocio";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Negocio a Eliminar";
            // 
            // txtNegocio
            // 
            this.txtNegocio.Location = new System.Drawing.Point(165, 27);
            this.txtNegocio.Name = "txtNegocio";
            this.txtNegocio.Size = new System.Drawing.Size(189, 23);
            this.txtNegocio.TabIndex = 3;
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.Location = new System.Drawing.Point(165, 82);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.Size = new System.Drawing.Size(188, 62);
            this.rtbDescripcion.TabIndex = 4;
            this.rtbDescripcion.Text = "";
            // 
            // cmbNegocioEliminar
            // 
            this.cmbNegocioEliminar.FormattingEnabled = true;
            this.cmbNegocioEliminar.Location = new System.Drawing.Point(165, 193);
            this.cmbNegocioEliminar.Name = "cmbNegocioEliminar";
            this.cmbNegocioEliminar.Size = new System.Drawing.Size(187, 23);
            this.cmbNegocioEliminar.TabIndex = 5;
            // 
            // btnAgregarNegocio
            // 
            this.btnAgregarNegocio.Location = new System.Drawing.Point(393, 103);
            this.btnAgregarNegocio.Name = "btnAgregarNegocio";
            this.btnAgregarNegocio.Size = new System.Drawing.Size(113, 41);
            this.btnAgregarNegocio.TabIndex = 6;
            this.btnAgregarNegocio.Text = "Agregar Negocio";
            this.btnAgregarNegocio.UseVisualStyleBackColor = true;
            this.btnAgregarNegocio.Click += new System.EventHandler(this.btnAgregarNegocio_Click);
            // 
            // btnEliminarNegocio
            // 
            this.btnEliminarNegocio.Location = new System.Drawing.Point(393, 192);
            this.btnEliminarNegocio.Name = "btnEliminarNegocio";
            this.btnEliminarNegocio.Size = new System.Drawing.Size(113, 23);
            this.btnEliminarNegocio.TabIndex = 7;
            this.btnEliminarNegocio.Text = "Eliminar Negocio";
            this.btnEliminarNegocio.UseVisualStyleBackColor = true;
            this.btnEliminarNegocio.Click += new System.EventHandler(this.btnEliminarNegocio_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(26, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione a que negocio agregara elproducto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre del producto";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(26, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Seleccione el producto a eliminar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNegocio
            // 
            this.cmbNegocio.FormattingEnabled = true;
            this.cmbNegocio.Location = new System.Drawing.Point(190, 40);
            this.cmbNegocio.Name = "cmbNegocio";
            this.cmbNegocio.Size = new System.Drawing.Size(209, 23);
            this.cmbNegocio.TabIndex = 3;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(190, 98);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(209, 23);
            this.txtProducto.TabIndex = 4;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(217, 146);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(145, 31);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // cmbProductoEliminar
            // 
            this.cmbProductoEliminar.FormattingEnabled = true;
            this.cmbProductoEliminar.Location = new System.Drawing.Point(190, 239);
            this.cmbProductoEliminar.Name = "cmbProductoEliminar";
            this.cmbProductoEliminar.Size = new System.Drawing.Size(209, 23);
            this.cmbProductoEliminar.TabIndex = 6;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(217, 281);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(145, 31);
            this.btnEliminarProducto.TabIndex = 7;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnEliminarDireccion);
            this.tabPage6.Controls.Add(this.btnAgregarDireccion);
            this.tabPage6.Controls.Add(this.cmbDireccion);
            this.tabPage6.Controls.Add(this.txtDireccion);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(514, 350);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Direccion";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Agregar Direccion";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Eliminar Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(178, 31);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 23);
            this.txtDireccion.TabIndex = 2;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Location = new System.Drawing.Point(178, 161);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(192, 23);
            this.cmbDireccion.TabIndex = 3;
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.Location = new System.Drawing.Point(394, 25);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(112, 33);
            this.btnAgregarDireccion.TabIndex = 4;
            this.btnAgregarDireccion.Text = "Agregar";
            this.btnAgregarDireccion.UseVisualStyleBackColor = true;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.Location = new System.Drawing.Point(394, 155);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(112, 33);
            this.btnEliminarDireccion.TabIndex = 5;
            this.btnEliminarDireccion.Text = "Eliminar";
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "Producto";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 28);
            this.label12.TabIndex = 1;
            this.label12.Text = "Direccion";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "Fecha";
            // 
            // cmbProducto1
            // 
            this.cmbProducto1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto1.FormattingEnabled = true;
            this.cmbProducto1.Location = new System.Drawing.Point(143, 30);
            this.cmbProducto1.Name = "cmbProducto1";
            this.cmbProducto1.Size = new System.Drawing.Size(188, 23);
            this.cmbProducto1.TabIndex = 3;
            // 
            // cmbDireccion1
            // 
            this.cmbDireccion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDireccion1.FormattingEnabled = true;
            this.cmbDireccion1.Location = new System.Drawing.Point(143, 72);
            this.cmbDireccion1.Name = "cmbDireccion1";
            this.cmbDireccion1.Size = new System.Drawing.Size(188, 23);
            this.cmbDireccion1.TabIndex = 4;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(143, 117);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(187, 23);
            this.dtpfecha.TabIndex = 5;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(9, 175);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(493, 164);
            this.dgvPedidos.TabIndex = 6;
            
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(384, 64);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(103, 53);
            this.btnPedido.TabIndex = 7;
            this.btnPedido.Text = "Realizar Orden";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(522, 441);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.tabContenedor);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tabContenedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dvgUsuarios)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TabControl tabContenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNegocio;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.ComboBox cmbNegocioEliminar;
        private System.Windows.Forms.Button btnAgregarNegocio;
        private System.Windows.Forms.Button btnEliminarNegocio;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbNegocio;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ComboBox cmbProductoEliminar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbProducto1;
        private System.Windows.Forms.ComboBox cmbDireccion1;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DateTimePicker dtpfecha;
    }
}