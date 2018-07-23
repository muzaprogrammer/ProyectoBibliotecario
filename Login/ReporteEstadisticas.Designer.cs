namespace CapaDiseño
{
    partial class ReporteEstadisticas
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
            this.crvEstadisticas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.eReport1 = new CapaDiseño.eReport();
            this.SuspendLayout();
            // 
            // crvEstadisticas
            // 
            this.crvEstadisticas.ActiveViewIndex = 0;
            this.crvEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEstadisticas.CachedPageNumberPerDoc = 10;
            this.crvEstadisticas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEstadisticas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.crvEstadisticas.Name = "crvEstadisticas";
            this.crvEstadisticas.ReportSource = this.eReport1;
            this.crvEstadisticas.ShowGroupTreeButton = false;
            this.crvEstadisticas.ShowLogo = false;
            this.crvEstadisticas.ShowParameterPanelButton = false;
            this.crvEstadisticas.Size = new System.Drawing.Size(864, 466);
            this.crvEstadisticas.TabIndex = 0;
            this.crvEstadisticas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReporteEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 466);
            this.Controls.Add(this.crvEstadisticas);
            this.Name = "ReporteEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteEstadisticas";
            this.Load += new System.EventHandler(this.ReporteEstadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEstadisticas;
        private eReport eReport1;

    }
}