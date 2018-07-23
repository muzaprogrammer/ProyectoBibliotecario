namespace CapaDiseño
{
    partial class ControlPrestamos
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarEntrega = new System.Windows.Forms.Button();
            this.btnEntregarLibro = new System.Windows.Forms.Button();
            this.textBoxCodigoEntrega = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrega = new System.Windows.Forms.Label();
            this.DTV_Mostrar_Prestamos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Mostrar_Prestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(184, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo de Usuario ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCancelarEntrega
            // 
            this.btnCancelarEntrega.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEntrega.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarEntrega.Image = global::CapaDiseño.Properties.Resources.btn_Cancel;
            this.btnCancelarEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEntrega.Location = new System.Drawing.Point(371, 356);
            this.btnCancelarEntrega.Name = "btnCancelarEntrega";
            this.btnCancelarEntrega.Size = new System.Drawing.Size(110, 35);
            this.btnCancelarEntrega.TabIndex = 13;
            this.btnCancelarEntrega.Text = "Cancelar";
            this.btnCancelarEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarEntrega.UseVisualStyleBackColor = false;
            this.btnCancelarEntrega.Click += new System.EventHandler(this.btnCancelarEntrega_Click);
            this.btnCancelarEntrega.MouseLeave += new System.EventHandler(this.btnCancelarEntrega_MouseLeave);
            this.btnCancelarEntrega.MouseHover += new System.EventHandler(this.btnCancelarEntrega_MouseHover);
            // 
            // btnEntregarLibro
            // 
            this.btnEntregarLibro.BackColor = System.Drawing.Color.Silver;
            this.btnEntregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntregarLibro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregarLibro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEntregarLibro.Image = global::CapaDiseño.Properties.Resources.ok;
            this.btnEntregarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntregarLibro.Location = new System.Drawing.Point(487, 356);
            this.btnEntregarLibro.Name = "btnEntregarLibro";
            this.btnEntregarLibro.Size = new System.Drawing.Size(114, 35);
            this.btnEntregarLibro.TabIndex = 12;
            this.btnEntregarLibro.Text = "Entregar";
            this.btnEntregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntregarLibro.UseVisualStyleBackColor = false;
            this.btnEntregarLibro.Click += new System.EventHandler(this.btnEntregarLibro_Click);
            this.btnEntregarLibro.MouseLeave += new System.EventHandler(this.btnEntregarLibro_MouseLeave);
            this.btnEntregarLibro.MouseHover += new System.EventHandler(this.btnEntregarLibro_MouseHover);
            // 
            // textBoxCodigoEntrega
            // 
            this.textBoxCodigoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoEntrega.Location = new System.Drawing.Point(162, 361);
            this.textBoxCodigoEntrega.Name = "textBoxCodigoEntrega";
            this.textBoxCodigoEntrega.Size = new System.Drawing.Size(56, 26);
            this.textBoxCodigoEntrega.TabIndex = 11;
            // 
            // lblCodigoEntrega
            // 
            this.lblCodigoEntrega.AutoSize = true;
            this.lblCodigoEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrega.Location = new System.Drawing.Point(32, 362);
            this.lblCodigoEntrega.Name = "lblCodigoEntrega";
            this.lblCodigoEntrega.Size = new System.Drawing.Size(125, 23);
            this.lblCodigoEntrega.TabIndex = 10;
            this.lblCodigoEntrega.Text = "Codigo de Libro";
            // 
            // DTV_Mostrar_Prestamos
            // 
            this.DTV_Mostrar_Prestamos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DTV_Mostrar_Prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTV_Mostrar_Prestamos.Location = new System.Drawing.Point(36, 97);
            this.DTV_Mostrar_Prestamos.Name = "DTV_Mostrar_Prestamos";
            this.DTV_Mostrar_Prestamos.Size = new System.Drawing.Size(565, 244);
            this.DTV_Mostrar_Prestamos.TabIndex = 14;
            this.DTV_Mostrar_Prestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTV_Mostrar_Prestamos_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(190, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "CONTROL DE PRESTAMOS";
            // 
            // ControlPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.ventana_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 419);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTV_Mostrar_Prestamos);
            this.Controls.Add(this.btnCancelarEntrega);
            this.Controls.Add(this.btnEntregarLibro);
            this.Controls.Add(this.textBoxCodigoEntrega);
            this.Controls.Add(this.lblCodigoEntrega);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ControlPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTV_Mostrar_Prestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarEntrega;
        private System.Windows.Forms.Button btnEntregarLibro;
        private System.Windows.Forms.TextBox textBoxCodigoEntrega;
        private System.Windows.Forms.Label lblCodigoEntrega;
        private System.Windows.Forms.DataGridView DTV_Mostrar_Prestamos;
        private System.Windows.Forms.Label label2;
    }
}