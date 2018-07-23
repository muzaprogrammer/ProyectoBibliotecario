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
    public partial class ControlPrestamos : Form
    {
        public ControlPrestamos()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        private void Cargar_Prestamos()
        {
            Conexion.Cn_conexion().Open();
            string estado = "prestado";
            OleDbDataAdapter Data_Prestamo= new OleDbDataAdapter("SELECT * FROM Prestamos WHERE Estado_Prestamo = '" + estado+ "'", Conexion.Cn_conexion());
            SIDIBDataSet dt = new SIDIBDataSet();
            Data_Prestamo.Fill(dt, "Prestamos");
            DTV_Mostrar_Prestamos.DataSource = dt;
            DTV_Mostrar_Prestamos.DataMember = "prestamos";

            Conexion.Cn_conexion().Close();
        }
        private void ControlPrestamos_Load(object sender, EventArgs e)
        {
            Cargar_Prestamos();
        }
        private static ControlPrestamos m_FormDefInstance;
        public static ControlPrestamos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new ControlPrestamos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btnCancelarEntrega_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Conexion.Cn_conexion().Open();
            OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT * FROM Prestamos WHERE  ID_Usuario like ('" + textBox1.Text + "%')");

            //cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            DTV_Mostrar_Prestamos.DataSource = dt;

            Conexion.Cn_conexion().Close();
        }
        private Libros Asig_Prestamo_text()
        {
            int id_prestamo;
            int id_usuario;
            DateTime fecha_prestamo;
            DateTime fecha_entrega;
            string tipo_prestamo;
            string estado_prestamo;
            int id_libro;

            int Reglon = DTV_Mostrar_Prestamos.CurrentCell.RowIndex;
            string prestamo = "entregado";
            id_prestamo= Convert.ToInt32(DTV_Mostrar_Prestamos[0, Reglon].Value.ToString());
            id_usuario = Convert.ToInt32(FormLogin.ID);
            fecha_prestamo = DateTime.Parse(DTV_Mostrar_Prestamos[2, Reglon].Value.ToString());
            fecha_entrega = DateTime.Now;
            tipo_prestamo = DTV_Mostrar_Prestamos[4, Reglon].Value.ToString() ;
            estado_prestamo = prestamo;
            textBoxCodigoEntrega.Text= (DTV_Mostrar_Prestamos[6, Reglon].Value.ToString());
            id_libro = Convert.ToInt32(DTV_Mostrar_Prestamos[6, Reglon].Value.ToString());

            Libros L = new Libros(id_prestamo, id_usuario, fecha_prestamo, fecha_entrega, tipo_prestamo, estado_prestamo, id_libro);

            return L;

        }

        private void btnEntregarLibro_Click(object sender, EventArgs e)
        {
            Libros aux = Asig_Prestamo_text();

            int Resultado = Metodos.EditarPrestamo(aux);




            if (Resultado > 0)
            {
                MessageBox.Show("Se ingreso al sistema el libro correctamente", "Registro de Datos ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cargar_Prestamos();

            }
            else
            {
                MessageBox.Show("Registro de Datos NO Realizado ", "Error al Registrar la Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DTV_Mostrar_Prestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Reglon = DTV_Mostrar_Prestamos.CurrentCell.RowIndex;
            textBoxCodigoEntrega.Text = (DTV_Mostrar_Prestamos[6, Reglon].Value.ToString());
        }

        private void btnCancelarEntrega_MouseHover(object sender, EventArgs e)
        {
            btnCancelarEntrega.BackColor = Color.DimGray;
            btnCancelarEntrega.ForeColor = Color.White;
        }

        private void btnCancelarEntrega_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarEntrega.BackColor = Color.Silver;
            btnCancelarEntrega.ForeColor = Color.Black;
        }

        private void btnEntregarLibro_MouseHover(object sender, EventArgs e)
        {
            btnEntregarLibro.BackColor = Color.DimGray;
            btnEntregarLibro.ForeColor = Color.White;
        }

        private void btnEntregarLibro_MouseLeave(object sender, EventArgs e)
        {
            btnEntregarLibro.BackColor = Color.Silver;
            btnEntregarLibro.ForeColor = Color.Black;
        }
    }
    }

