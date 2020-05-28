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
            this.tabPage4 = new System.Windows.Forms.TabPage();
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
            this.tabContenedor.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dvgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContenedor
            // 
            this.tabContenedor.Controls.Add(this.tabPage1);
            this.tabContenedor.Controls.Add(this.tabPage2);
            this.tabContenedor.Controls.Add(this.tabPage3);
            this.tabContenedor.Controls.Add(this.tabPage4);
            this.tabContenedor.Controls.Add(this.tabPage5);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(514, 350);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Negocios";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.tabContenedor.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dvgUsuarios)).EndInit();
            this.ResumeLayout(false);
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
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
    }
}