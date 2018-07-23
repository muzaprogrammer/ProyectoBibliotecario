using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace CapaDiseño
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        private static Inventario m_FormDefInstance;
        public static Inventario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Inventario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarLibros()
        {
            Conexion.Cn_conexion().Open();
            
            OleDbDataAdapter daEstadisticas = new OleDbDataAdapter("Select * FROM Libros", Conexion.Cn_conexion());
            DataSet DataSetInventario = new DataSet();
            daEstadisticas.Fill(DataSetInventario, "Libros");
            dgvEstadisticas.DataSource = DataSetInventario;
            dgvEstadisticas.DataMember = "Libros";         
           
            Conexion.Cn_conexion().Close();
        }
        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void textBoxInventario_TextChanged(object sender, EventArgs e)
        {

            Conexion.Cn_conexion().Open();
            OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM Libros WHERE  Titulo like ('" + textBoxInventario.Text + "%')");

            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvEstadisticas.DataSource = dt;

            Conexion.Cn_conexion().Close();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.DimGray;
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.Silver;
            button4.ForeColor = Color.Black;
        }

        private void btnGenerarReporteInv_MouseHover(object sender, EventArgs e)
        {
            btnGenerarReporteInv.BackColor = Color.DimGray;
            btnGenerarReporteInv.ForeColor = Color.White;
        }

        private void btnGenerarReporteInv_MouseLeave(object sender, EventArgs e)
        {
            btnGenerarReporteInv.BackColor = Color.Silver;
            btnGenerarReporteInv.ForeColor = Color.Black;
        }

        private void btnGenerarReporteInv_Click(object sender, EventArgs e)
        {
            ReporteEstadisticas abrir = new ReporteEstadisticas();
            abrir.Show();
        }
    }
}
