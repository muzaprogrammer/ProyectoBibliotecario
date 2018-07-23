namespace CapaDiseño
{
    partial class Estadisticas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelarEstadisticas = new System.Windows.Forms.Button();
            this.btnGReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(127, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Prestamos Internos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(296, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prestamos Externos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelarEstadisticas
            // 
            this.btnCancelarEstadisticas.BackColor = System.Drawing.Color.Silver;
            this.btnCancelarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarEstadisticas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEstadisticas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelarEstadisticas.Image = global::CapaDiseño.Properties.Resources.btn_Cancel;
            this.btnCancelarEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarEstadisticas.Location = new System.Drawing.Point(369, 415);
            this.btnCancelarEstadisticas.Name = "btnCancelarEstadisticas";
            this.btnCancelarEstadisticas.Size = new System.Drawing.Size(110, 35);
            this.btnCancelarEstadisticas.TabIndex = 2;
            this.btnCancelarEstadisticas.Text = "Cancelar";
            this.btnCancelarEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarEstadisticas.UseVisualStyleBackColor = false;
            this.btnCancelarEstadisticas.Click += new System.EventHandler(this.button3_Click);
            this.btnCancelarEstadisticas.MouseLeave += new System.EventHandler(this.btnCancelarEstadisticas_MouseLeave);
            this.btnCancelarEstadisticas.MouseHover += new System.EventHandler(this.btnCancelarEstadisticas_MouseHover);
            // 
            // btnGReporte
            // 
            this.btnGReporte.BackColor = System.Drawing.Color.Silver;
            this.btnGReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGReporte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGReporte.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGReporte.Image = global::CapaDiseño.Properties.Resources.greporte;
            this.btnGReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGReporte.Location = new System.Drawing.Point(490, 415);
            this.btnGReporte.Name = "btnGReporte";
            this.btnGReporte.Size = new System.Drawing.Size(173, 35);
            this.btnGReporte.TabIndex = 3;
            this.btnGReporte.Text = "Generar Reporte";
            this.btnGReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGReporte.UseVisualStyleBackColor = false;
            this.btnGReporte.Click += new System.EventHandler(this.btnGReporte_Click);
            this.btnGReporte.MouseLeave += new System.EventHandler(this.btnGReporte_MouseLeave);
            this.btnGReporte.MouseHover += new System.EventHandler(this.btnGReporte_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(465, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 35);
            this.button5.TabIndex = 8;
            this.button5.Text = "Moras";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.AllowUserToAddRows = false;
            this.dgvEstadisticas.AllowUserToDeleteRows = false;
            this.dgvEstadisticas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Location = new System.Drawing.Point(36, 108);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.Size = new System.Drawing.Size(629, 292);
            this.dgvEstadisticas.TabIndex = 7;
            this.dgvEstadisticas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstadisticas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ESTADISTICAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CapaDiseño.Properties.Resources.ventana_proyecto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 483);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGReporte);
            this.Controls.Add(this.btnCancelarEstadisticas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Estadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelarEstadisticas;
        private System.Windows.Forms.Button btnGReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.Label label2;
    }
}