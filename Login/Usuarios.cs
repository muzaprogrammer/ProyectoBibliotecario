using System;
using System.Data.OleDb;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        private void Cargar_Usuarios()
        {
            Conexion.Cn_conexion().Open();

            OleDbDataAdapter Data_Libro = new OleDbDataAdapter("SELECT * FROM Usuarios", Conexion.Cn_conexion());
            SIDIBDataSet dt = new SIDIBDataSet();
            Data_Libro.Fill(dt, "Usuarios");
            dgvUsuarios.DataSource = dt;
            dgvUsuarios.DataMember = "Usuarios";

            Conexion.Cn_conexion().Close();
        }
        private void btnCancelarEntrega_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static Usuarios m_FormDefInstance;
        public static Usuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Usuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            Cargar_Usuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            AgregarUsuaario.DefInstance.Show();
           // AgregarUsuaario form = new AgregarUsuaario();
            //form.Show();            
            this.Hide();
        }

        private void textBoxCodigoEntrega_TextChanged(object sender, EventArgs e)
        {

            Conexion.Cn_conexion().Open();
            OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM Usuarios WHERE  Nombre_Usuario like ('" + textBoxCodigoEntrega.Text + "%')");

            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dgvUsuarios.DataSource = dt;

            Conexion.Cn_conexion().Close();
        }
    }
}
