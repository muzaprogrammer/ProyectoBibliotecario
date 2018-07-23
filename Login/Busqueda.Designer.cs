namespace CapaDiseño
{
    partial class Busqueda
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
            this.DTV_Mostrar_Libros = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.btnPrestamo = new System.Windows.Forms.Button();
            this.btnCancelarPrestamo = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Mostrar_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // DTV_Mostrar_Libros
            // 
            this.DTV_Mostrar_Libros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DTV_Mostrar_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_Mostrar_Libros.Location = new System.Drawing.Point(42, 108);
            this.DTV_Mostrar_Libros.Name = "DTV_Mostrar_Libros";
            this.DTV_Mostrar_Libros.Size = new System.Drawing.Size(746, 231);
            this.DTV_Mostrar_Libros.TabIndex = 3;
            this.DTV_Mostrar_Libros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTV_Mostrar_Libros_CellClick);
            this.DTV_Mostrar_Libros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTV_Mostrar_Libros_CellContentClick);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(39, 368);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(125, 23);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Codigo de Libro";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(175, 367);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(189, 26);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // btnPrestamo
            // 
            this.btnPrestamo.BackColor = System.Drawing.Color.Silver;
            this.btnPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrestamo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrestamo.Image = global::CapaDiseño.Properties.Resources.ok;
            this.btnPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestamo.Location = new System.Drawing.Point(605, 360);
            this.btnPrestamo.Name = "btnPrestamo";
            this.btnPrestamo.Size = new System.Drawing.Size(183, 35);
            this.btnPrestamo.TabIndex = 8;
            this.btnPrestamo.Text = "Realizar Prestamo";
            this.btnPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrestamo.UseVisualStyleBackColor = false;
            this.btnPrestamo.Click += new System.EventHandler(this.btnPrestamo_Click);
            this.btnPrestamo.MouseLeave += new System.EventHandler(this.btnPrestamo_MouseLeave);
            this.btnPrestamo.MouseHover += new System.EventHandler(this.btnPrestamo_MouseHover);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarPrestamo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrestamo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarPrestamo.Image = global::CapaDiseño.Properties.Resources.btn_Cancel;
            this.btnCancelarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarPrestamo.Location = new System.Drawing.Point(483, 360);
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            this.btnCancelarPrestamo.Size = new System.Drawing.Size(110, 35);
            this.btnCancelarPrestamo.TabIndex = 9;
            this.btnCancelarPrestamo.Text = "Cancelar";
            this.btnCancelarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarPrestamo.UseVisualStyleBackColor = false;
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            this.btnCancelarPrestamo.MouseLeave += new System.EventHandler(this.btnCancelarPrestamo_MouseLeave);
            this.btnCancelarPrestamo.MouseHover += new System.EventHandler(this.btnCancelarPrestamo_MouseHover);
            // 
            // textBuscar
            // 
            this.textBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscar.Location = new System.Drawing.Point(153, 59);
            this.textBuscar.Multiline = true;
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(298, 30);
            this.textBuscar.TabIndex = 11;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            this.textBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBuscar_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Busqueda Por:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxTipoBusqueda
            // 
            this.cbxTipoBusqueda.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoBusqueda.FormattingEnabled = true;
            this.cbxTipoBusqueda.Items.AddRange(new object[] {
            "Titulo",
            "Autor",
            "Editorial",
            "ISBN"});
            this.cbxTipoBusqueda.Location = new System.Drawing.Point(610, 60);
            this.cbxTipoBusqueda.Name = "cbxTipoBusqueda";
            this.cbxTipoBusqueda.Size = new System.Drawing.Size(178, 30);
            this.cbxTipoBusqueda.TabIndex = 14;
            this.cbxTipoBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Image = global::CapaDiseño.Properties.Resources.ico_buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(43, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_MouseLeave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "PRESTAMO DE LIBROS";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.ventana_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 420);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxTipoBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.btnCancelarPrestamo);
            this.Controls.Add(this.btnPrestamo);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.DTV_Mostrar_Libros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Busqueda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Mostrar_Libros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DTV_Mostrar_Libros;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button btnPrestamo;
        private System.Windows.Forms.Button btnCancelarPrestamo;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTipoBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
    }
}