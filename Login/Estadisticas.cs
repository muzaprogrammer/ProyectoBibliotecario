using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        private static Estadisticas m_FormDefInstance;
        public static Estadisticas DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Estadisticas();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void prestamosExternos()
        {
            Conexion.Cn_conexion().Open();
            string estado = "Externo";
            OleDbDataAdapter daEstadisticas = new OleDbDataAdapter("Select * FROM Prestamos WHERE ID_Tipo_Prestamo = '" + estado + "'", Conexion.Cn_conexion());
            DataSet dsEstadisticas = new DataSet();
            daEstadisticas.Fill(dsEstadisticas, "Prestamos");
            dgvEstadisticas.DataSource = dsEstadisticas;
            dgvEstadisticas.DataMember = "Prestamos";
            Conexion.Cn_conexion().Close();

        }
        private void prestamosInternos()
        {
            Conexion.Cn_conexion().Open();
            string estado = "Interno";
            OleDbDataAdapter daEstadisticas = new OleDbDataAdapter("Select * FROM Prestamos WHERE ID_Tipo_Prestamo = '" + estado + "'", Conexion.Cn_conexion());
            DataSet dsEstadisticas = new DataSet();
            daEstadisticas.Fill(dsEstadisticas, "Prestamos");
            dgvEstadisticas.DataSource = dsEstadisticas;
            dgvEstadisticas.DataMember = "Prestamos";
            Conexion.Cn_conexion().Close();

        }
        private void moras()
        {
            Conexion.Cn_conexion().Open();
            
            OleDbDataAdapter daEstadisticas = new OleDbDataAdapter("Select M.ID_Mora, U.Nombre_Usuario, L.Titulo, M.Monto, M.Mora_Estado, P.Fecha_Prestamo FROM Moras M, Prestamos P, Usuarios U, Libros L WHERE M.ID_Prestamo = P.ID_Prestamo and M.ID_Usuario = U.ID_Usuario and P.ID_Libro = L.ID_Libro", Conexion.Cn_conexion());
            DataSet dsEstadisticas = new DataSet();
            daEstadisticas.Fill(dsEstadisticas, "Moras");
            dgvEstadisticas.DataSource = dsEstadisticas;
            dgvEstadisticas.DataMember = "Moras";
            Conexion.Cn_conexion().Close();

        }
        private void Estadisticas_Load(object sender, EventArgs e)
        {

        }

        private void dgvEstadisticas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prestamosInternos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prestamosExternos();
        }

        private void btnGReporte_Click(object sender, EventArgs e)
        {
            DataSetPInternos da = new DataSetPInternos();
            int filas = dgvEstadisticas.RowCount;
            for (int i = 0;i <= filas-2; i ++)
            {
                da.Tables[0].Rows.Add
                (
                new object[] 
                {
                dgvEstadisticas[0,i].Value.ToString(),
                dgvEstadisticas[1,i].Value.ToString(),
                dgvEstadisticas[2,i].Value.ToString(),
                dgvEstadisticas[3,i].Value.ToString(),
                dgvEstadisticas[4,i].Value.ToString(),
                dgvEstadisticas[5,i].Value.ToString(),
                dgvEstadisticas[6,i].Value.ToString(),
                dgvEstadisticas[7,i].Value.ToString()
                }
                );
            }
                       
            ReporteEstadisticas abrir = new ReporteEstadisticas();
            abrir.Show();
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            moras();
        }

        private void btnGReporte_MouseHover(object sender, EventArgs e)
        {
            btnGReporte.BackColor = Color.DimGray;
            btnGReporte.ForeColor = Color.White;
        }

        private void btnGReporte_MouseLeave(object sender, EventArgs e)
        {
            btnGReporte.BackColor = Color.Silver;
            btnGReporte.ForeColor = Color.Black;
        }

        private void btnCancelarEstadisticas_MouseHover(object sender, EventArgs e)
        {
            btnCancelarEstadisticas.BackColor = Color.DimGray;
            btnCancelarEstadisticas.ForeColor = Color.White;
        }

        private void btnCancelarEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarEstadisticas.BackColor = Color.Silver;
            btnCancelarEstadisticas.ForeColor = Color.Black;
        }

    }
}
