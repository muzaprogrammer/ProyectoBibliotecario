namespace CapaDiseño
{
    partial class FormMdiInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.estatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnAgregarLibro = new System.Windows.Forms.PictureBox();
            this.btnInventarios = new System.Windows.Forms.PictureBox();
            this.btnEstadisticas = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pBoxUsuario = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadisticas)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirDeSistemaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirDeSistemaToolStripMenuItem
            // 
            this.salirDeSistemaToolStripMenuItem.Name = "salirDeSistemaToolStripMenuItem";
            this.salirDeSistemaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salirDeSistemaToolStripMenuItem.Text = "Salir de Sistema";
            this.salirDeSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDeSistemaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraEstado,
            this.estatusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(914, 29);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // barraEstado
            // 
            this.barraEstado.ForeColor = System.Drawing.Color.Black;
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.Size = new System.Drawing.Size(141, 24);
            this.barraEstado.Text = "TIPO DE USUARIO";
            this.barraEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // estatusHora
            // 
            this.estatusHora.Margin = new System.Windows.Forms.Padding(1000, 3, 0, 2);
            this.estatusHora.Name = "estatusHora";
            this.estatusHora.Size = new System.Drawing.Size(55, 21);
            this.estatusHora.Text = "HORA";
            this.estatusHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 130);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnUsuarios);
            this.panel2.Controls.Add(this.btnPrestamos);
            this.panel2.Controls.Add(this.btnBusqueda);
            this.panel2.Controls.Add(this.btnAgregarLibro);
            this.panel2.Controls.Add(this.btnInventarios);
            this.panel2.Controls.Add(this.btnEstadisticas);
            this.panel2.Location = new System.Drawing.Point(96, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 129);
            this.panel2.TabIndex = 6;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Image = global::CapaDiseño.Properties.Resources.yellow_user_icon;
            this.btnUsuarios.Location = new System.Drawing.Point(572, 21);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(90, 85);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click_1);
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave_1);
            this.btnUsuarios.MouseHover += new System.EventHandler(this.btnUsuarios_MouseHover_1);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Image = global::CapaDiseño.Properties.Resources.yellow_address_book_icon;
            this.btnPrestamos.Location = new System.Drawing.Point(126, 21);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(90, 85);
            this.btnPrestamos.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnPrestamos, "CONTROL DE PRESTAMOS");
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click_1);
            this.btnPrestamos.MouseLeave += new System.EventHandler(this.btnPrestamos_MouseLeave_1);
            this.btnPrestamos.MouseHover += new System.EventHandler(this.btnPrestamos_MouseHover_1);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.FlatAppearance.BorderSize = 0;
            this.btnBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Image = global::CapaDiseño.Properties.Resources.icono_prestamo;
            this.btnBusqueda.Location = new System.Drawing.Point(18, 21);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(90, 85);
            this.btnBusqueda.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnBusqueda, "PRESTAMOS");
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click_1);
            this.btnBusqueda.MouseLeave += new System.EventHandler(this.btnBusqueda_MouseLeave);
            this.btnBusqueda.MouseHover += new System.EventHandler(this.btnBusqueda_MouseHover);
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackgroundImage = global::CapaDiseño.Properties.Resources.yellow_document_plus_icon;
            this.btnAgregarLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarLibro.Location = new System.Drawing.Point(231, 21);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(90, 85);
            this.btnAgregarLibro.TabIndex = 5;
            this.btnAgregarLibro.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregarLibro, "CATALOGO");
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            this.btnAgregarLibro.MouseLeave += new System.EventHandler(this.btnAgregarLibro_MouseLeave);
            this.btnAgregarLibro.MouseHover += new System.EventHandler(this.btnAgregarLibro_MouseHover);
            // 
            // btnInventarios
            // 
            this.btnInventarios.BackgroundImage = global::CapaDiseño.Properties.Resources.yellow_notes_icon;
            this.btnInventarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventarios.Location = new System.Drawing.Point(340, 21);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.Size = new System.Drawing.Size(90, 85);
            this.btnInventarios.TabIndex = 4;
            this.btnInventarios.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInventarios, "INVENTARIO");
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            this.btnInventarios.MouseLeave += new System.EventHandler(this.btnInventarios_MouseLeave);
            this.btnInventarios.MouseHover += new System.EventHandler(this.btnInventarios_MouseHover);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackgroundImage = global::CapaDiseño.Properties.Resources.yellow_chart_icon;
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.Location = new System.Drawing.Point(455, 21);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(90, 85);
            this.btnEstadisticas.TabIndex = 3;
            this.btnEstadisticas.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEstadisticas, "ESTADISTICAS");
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            this.btnEstadisticas.MouseLeave += new System.EventHandler(this.btnEstadisticas_MouseLeave);
            this.btnEstadisticas.MouseHover += new System.EventHandler(this.btnEstadisticas_MouseHover);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::CapaDiseño.Properties.Resources.ico_cerrar1;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Location = new System.Drawing.Point(8, 1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(40, 40);
            this.btnSalir.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnSalir, "Cerrar");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackgroundImage = global::CapaDiseño.Properties.Resources.ico_minimizar1;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Location = new System.Drawing.Point(51, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImage = global::CapaDiseño.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.Location = new System.Drawing.Point(95, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(40, 40);
            this.btnCerrarSesion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnCerrarSesion, "Cerrar Sesión");
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnCerrarSesion);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.pBoxUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(914, 44);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(800, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.lblUsuario.Size = new System.Drawing.Size(60, 35);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // pBoxUsuario
            // 
            this.pBoxUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBoxUsuario.BackgroundImage = global::CapaDiseño.Properties.Resources.ico_usuario1;
            this.pBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBoxUsuario.Image = global::CapaDiseño.Properties.Resources.ico_usuario2;
            this.pBoxUsuario.Location = new System.Drawing.Point(860, 0);
            this.pBoxUsuario.Name = "pBoxUsuario";
            this.pBoxUsuario.Size = new System.Drawing.Size(54, 44);
            this.pBoxUsuario.TabIndex = 1;
            this.pBoxUsuario.TabStop = false;
            // 
            // FormMdiInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.fondo_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 482);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(914, 477);
            this.Name = "FormMdiInicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMdiInicio_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregarLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEstadisticas)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel estatusHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pBoxUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrarSesion;
        public System.Windows.Forms.PictureBox btnEstadisticas;
        public System.Windows.Forms.PictureBox btnInventarios;
        public System.Windows.Forms.PictureBox btnAgregarLibro;
        public System.Windows.Forms.Button btnBusqueda;
        public System.Windows.Forms.Button btnPrestamos;
        public System.Windows.Forms.Button btnUsuarios;
    }
}