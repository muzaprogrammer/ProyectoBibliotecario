namespace CapaDiseño
{
    partial class Usuarios
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
            this.btnCancelarEntrega = new System.Windows.Forms.Button();
            this.textBoxCodigoEntrega = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrega = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarEntrega
            // 
            this.btnCancelarEntrega.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelarEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEntrega.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEntrega.Location = new System.Drawing.Point(408, 301);
            this.btnCancelarEntrega.Name = "btnCancelarEntrega";
            this.btnCancelarEntrega.Size = new System.Drawing.Size(88, 37);
            this.btnCancelarEntrega.TabIndex = 17;
            this.btnCancelarEntrega.Text = "Cancelar";
            this.btnCancelarEntrega.UseVisualStyleBackColor = false;
            this.btnCancelarEntrega.Click += new System.EventHandler(this.btnCancelarEntrega_Click);
            // 
            // textBoxCodigoEntrega
            // 
            this.textBoxCodigoEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoEntrega.Location = new System.Drawing.Point(118, 308);
            this.textBoxCodigoEntrega.Name = "textBoxCodigoEntrega";
            this.textBoxCodigoEntrega.Size = new System.Drawing.Size(194, 26);
            this.textBoxCodigoEntrega.TabIndex = 15;
            this.textBoxCodigoEntrega.TextChanged += new System.EventHandler(this.textBoxCodigoEntrega_TextChanged);
            // 
            // lblCodigoEntrega
            // 
            this.lblCodigoEntrega.AutoSize = true;
            this.lblCodigoEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrega.Location = new System.Drawing.Point(32, 308);
            this.lblCodigoEntrega.Name = "lblCodigoEntrega";
            this.lblCodigoEntrega.Size = new System.Drawing.Size(71, 23);
            this.lblCodigoEntrega.TabIndex = 14;
            this.lblCodigoEntrega.Text = "Usuario:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(596, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(35, 49);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(652, 237);
            this.dgvUsuarios.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(502, 301);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 37);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.ventana_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 359);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancelarEntrega);
            this.Controls.Add(this.textBoxCodigoEntrega);
            this.Controls.Add(this.lblCodigoEntrega);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarEntrega;
        private System.Windows.Forms.TextBox textBoxCodigoEntrega;
        private System.Windows.Forms.Label lblCodigoEntrega;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnEliminar;
    }
}