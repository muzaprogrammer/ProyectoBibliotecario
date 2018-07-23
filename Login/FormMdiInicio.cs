using System;
using System.Windows.Forms;
using CapaNegocio;
using System.Drawing;

namespace CapaDiseño
{
    public partial class FormMdiInicio : Form
    {
        public FormMdiInicio()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void FormMdiInicio_Load(object sender, EventArgs e)
        {
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 ancho = (desktopSize.Width - 680) / 2;
            panel2.Location = new Point(ancho);
           
            lblUsuario.Text = FormLogin.nUsuario;
            estatusHora.Text = DateTime.Now.ToLongTimeString();
            barraEstado.Text = "Tipo de Usuario : " + FormLogin.rol;       
            
            if ( FormLogin.rol == "Bibliotecario")
                {
                    btnUsuarios.Enabled= false;
                    btnEstadisticas.Enabled = false;
                }
            if (FormLogin.rol == "Usuario")
                {
                    
                   btnEstadisticas.Enabled = false;
                   btnUsuarios.Enabled = false;
                   btnInventarios.Enabled = false;
               }
            
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        
        }

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*ModificarUsuarios.DefInstance.MdiParent = this;
            ModificarUsuarios.DefInstance.Show();  */
        }

        private void cerrarSesiónToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin mostrar = new FormLogin();
            mostrar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            estatusHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void eliminarUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBusqueda_MouseHover(object sender, EventArgs e)
        {
            btnBusqueda.Size = new Size(105, 100);
            //btnBusqueda.BackgroundImage = Properties.Resources.btn_hover;
        }

        private void btnBusqueda_MouseLeave(object sender, EventArgs e)
        {
            btnBusqueda.Size = new Size(90, 85);
        }

        private void btnPrestamos_MouseHover(object sender, EventArgs e)
        {
            btnPrestamos.Size = new Size(105, 100);
        }

        private void btnPrestamos_MouseLeave(object sender, EventArgs e)
        {
            btnPrestamos.Size = new Size(90, 85);
        }

        private void btnEstadisticas_MouseHover(object sender, EventArgs e)
        {
            btnEstadisticas.Size = new Size(105, 100);
        }

        private void btnEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            btnEstadisticas.Size = new Size(90, 85);
        }

        private void btnInventarios_MouseHover(object sender, EventArgs e)
        {
            btnInventarios.Size = new Size(105, 100);
        }

        private void btnInventarios_MouseLeave(object sender, EventArgs e)
        {
            btnInventarios.Size = new Size(90, 85);
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.Size = new Size(105, 100);
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.Size = new Size(90, 85);
        }

        private void pBoxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas Cerrar tu Sesión", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                FormLogin mostrar = new FormLogin();
                mostrar.Show();
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            AgregarLibro.DefInstance.MdiParent = this;
            AgregarLibro.DefInstance.Show();
        }

        private void btnAgregarLibro_MouseHover(object sender, EventArgs e)
        {
            btnAgregarLibro.Size = new Size(105, 100);
        }

        private void btnAgregarLibro_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarLibro.Size = new Size(90, 85);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Busqueda.DefInstance.MdiParent = this;
           Busqueda.DefInstance.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            ControlPrestamos.DefInstance.MdiParent = this;
            ControlPrestamos.DefInstance.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            Inventario.DefInstance.MdiParent = this;
            Inventario.DefInstance.Show();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Estadisticas.DefInstance.MdiParent = this;
            Estadisticas.DefInstance.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios.DefInstance.MdiParent = this;
            Usuarios.DefInstance.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBusqueda_Click_1(object sender, EventArgs e)
        {
            Busqueda.DefInstance.MdiParent = this;
            Busqueda.DefInstance.Show();
        }

        private void btnPrestamos_Click_1(object sender, EventArgs e)
        {
            ControlPrestamos.DefInstance.MdiParent = this;
            ControlPrestamos.DefInstance.Show();

        }

        private void btnPrestamos_MouseHover_1(object sender, EventArgs e)
        {
            btnPrestamos.Size = new Size(105, 100);
        }

        private void btnPrestamos_MouseLeave_1(object sender, EventArgs e)
        {
            btnPrestamos.Size = new Size(90,85);
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            Usuarios.DefInstance.MdiParent = this;
            Usuarios.DefInstance.Show();
        }

        private void btnUsuarios_MouseHover_1(object sender, EventArgs e)
        {
            btnUsuarios.Size = new Size(105, 100);
        }

        private void btnUsuarios_MouseLeave_1(object sender, EventArgs e)
        {
            btnUsuarios.Size = new Size(90, 85);
        }
    }
}
