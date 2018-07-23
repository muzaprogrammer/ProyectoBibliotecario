namespace CapaDiseño
{
    partial class Inventario
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
            this.textBoxInventario = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxCodigoEntrega = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrega = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporteInv = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInventario
            // 
            this.textBoxInventario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInventario.Location = new System.Drawing.Point(92, 73);
            this.textBoxInventario.Name = "textBoxInventario";
            this.textBoxInventario.Size = new System.Drawing.Size(405, 30);
            this.textBoxInventario.TabIndex = 4;
            this.textBoxInventario.TextChanged += new System.EventHandler(this.textBoxInventario_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = global::CapaDiseño.Properties.Resources.btn_Cancel;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(459, 439);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // textBoxCodigoEntrega
            // 
            this.textBoxCodigoEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigoEntrega.Location = new System.Drawing.Point(172, 442);
            this.textBoxCodigoEntrega.Name = "textBoxCodigoEntrega";
            this.textBoxCodigoEntrega.Size = new System.Drawing.Size(194, 30);
            this.textBoxCodigoEntrega.TabIndex = 13;
            // 
            // lblCodigoEntrega
            // 
            this.lblCodigoEntrega.AutoSize = true;
            this.lblCodigoEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoEntrega.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrega.Location = new System.Drawing.Point(36, 447);
            this.lblCodigoEntrega.Name = "lblCodigoEntrega";
            this.lblCodigoEntrega.Size = new System.Drawing.Size(130, 23);
            this.lblCodigoEntrega.TabIndex = 12;
            this.lblCodigoEntrega.Text = "Codigo de Libro:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 30);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total de Libros:";
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.AllowUserToAddRows = false;
            this.dgvEstadisticas.AllowUserToDeleteRows = false;
            this.dgvEstadisticas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(39, 122);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.Size = new System.Drawing.Size(716, 296);
            this.dgvEstadisticas.TabIndex = 17;
            // 
            // btnGenerarReporteInv
            // 
            this.btnGenerarReporteInv.BackColor = System.Drawing.Color.Silver;
            this.btnGenerarReporteInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarReporteInv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerarReporteInv.Image = global::CapaDiseño.Properties.Resources.greporte;
            this.btnGenerarReporteInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporteInv.Location = new System.Drawing.Point(577, 439);
            this.btnGenerarReporteInv.Name = "btnGenerarReporteInv";
            this.btnGenerarReporteInv.Size = new System.Drawing.Size(180, 35);
            this.btnGenerarReporteInv.TabIndex = 18;
            this.btnGenerarReporteInv.Text = "Generar Reporte";
            this.btnGenerarReporteInv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarReporteInv.UseVisualStyleBackColor = false;
            this.btnGenerarReporteInv.Click += new System.EventHandler(this.btnGenerarReporteInv_Click);
            this.btnGenerarReporteInv.MouseLeave += new System.EventHandler(this.btnGenerarReporteInv_MouseLeave);
            this.btnGenerarReporteInv.MouseHover += new System.EventHandler(this.btnGenerarReporteInv_MouseHover);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::CapaDiseño.Properties.Resources.ico_buscar;
            this.btnbuscar.Location = new System.Drawing.Point(39, 62);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(48, 48);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "INVENTARIO";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.ventana_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 503);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerarReporteInv);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxCodigoEntrega);
            this.Controls.Add(this.lblCodigoEntrega);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.textBoxInventario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInventario;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxCodigoEntrega;
        private System.Windows.Forms.Label lblCodigoEntrega;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Button btnGenerarReporteInv;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label2;
        //private DataSetInventario dataSetInventario;
    }
}