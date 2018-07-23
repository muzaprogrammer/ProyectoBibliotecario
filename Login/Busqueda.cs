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
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            
        }
        private void Cargar_Libros()
        {
            Conexion.Cn_conexion().Open();

            OleDbDataAdapter Data_Libro = new OleDbDataAdapter("SELECT * FROM Libros", Conexion.Cn_conexion());
            SIDIBDataSet dt = new SIDIBDataSet();
            Data_Libro.Fill(dt, "Libros");
            DTV_Mostrar_Libros.DataSource = dt;
            DTV_Mostrar_Libros.DataMember = "Libros";

            Conexion.Cn_conexion().Close();
        }

        private void btnBuscar_MouseHover(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.DimGray;
            btnBuscar.ForeColor = Color.White;
        }

        private void btnBuscar_MouseLeave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.Silver;
            btnBuscar.ForeColor = Color.Black;
            
        }
        private static Busqueda m_FormDefInstance;
        public static Busqueda DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Busqueda();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrestamo_MouseHover(object sender, EventArgs e)
        {
            btnPrestamo.BackColor= Color.DimGray;
            btnPrestamo.ForeColor = Color.White;
        }

        private void btnPrestamo_MouseLeave(object sender, EventArgs e)
        {
            btnPrestamo.BackColor = Color.Silver;
            btnPrestamo.ForeColor = Color.Black;
           
        }

        private void btnCancelarPrestamo_MouseHover(object sender, EventArgs e)
        {
            btnCancelarPrestamo.BackColor = Color.DimGray;
            btnCancelarPrestamo.ForeColor = Color.White;
        }

        private void btnCancelarPrestamo_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarPrestamo.BackColor = Color.Silver;
            btnCancelarPrestamo.ForeColor = Color.Black;
        }

        private void Busqueda_Load(object sender, EventArgs e)
        {
            Cargar_Libros();
        }
        

        private void textBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cbxTipoBusqueda.Text == "Autor")
            {
                OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("Select * from Libros where Autor like('" + textBuscar.Text + "%')");
                //cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                DTV_Mostrar_Libros.DataSource = dt;

                Conexion.Cn_conexion().Close();
            }
            else
            {
                if (cbxTipoBusqueda.Text == "Titulo")
                {
                    OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("Select * from Libros where Titulo like('" + textBuscar.Text + "%')");
                    //cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);
                    DTV_Mostrar_Libros.DataSource = dt;

                    Conexion.Cn_conexion().Close();
                }
                else
                {
                    if (cbxTipoBusqueda.Text == "Editorial")
                    {
                        OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = ("Select * from Libros where Editorial like('" + textBuscar.Text + "%')");
                        //cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        da.Fill(dt);
                        DTV_Mostrar_Libros.DataSource = dt;

                        Conexion.Cn_conexion().Close();
                    }
                    else
                    {
                        if (cbxTipoBusqueda.Text == "ISBN")
                        {
                            OleDbCommand cmd = Conexion.Cn_conexion().CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = ("Select * from Libros where ISBN like('" + textBuscar.Text + "%')");
                            //cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                            da.Fill(dt);
                            DTV_Mostrar_Libros.DataSource = dt;

                            Conexion.Cn_conexion().Close();
                        }
                    }
                }
            }
            
        }
        private void prestamo()
        {
            HacerPrestamo abrir = new HacerPrestamo();
            int Reglon = DTV_Mostrar_Libros.CurrentCell.RowIndex;
            string var1 = DTV_Mostrar_Libros[0, Reglon].Value.ToString();
            string var2 = DTV_Mostrar_Libros[1, Reglon].Value.ToString();
            string var3 = DTV_Mostrar_Libros[2, Reglon].Value.ToString();
            string var4 = DTV_Mostrar_Libros[3, Reglon].Value.ToString();
            string var5 = DTV_Mostrar_Libros[4, Reglon].Value.ToString();
            string var6 = DTV_Mostrar_Libros[5, Reglon].Value.ToString();
            string var7 = DTV_Mostrar_Libros[6, Reglon].Value.ToString();
            string var8 = DTV_Mostrar_Libros[7, Reglon].Value.ToString();
            string var9 = DTV_Mostrar_Libros[8, Reglon].Value.ToString();
            string var10 = DTV_Mostrar_Libros[9, Reglon].Value.ToString();
            string var11 = DTV_Mostrar_Libros[10, Reglon].Value.ToString();
            string var12 = DTV_Mostrar_Libros[11, Reglon].Value.ToString();
            string var13 = DTV_Mostrar_Libros[12, Reglon].Value.ToString();
            string var14 = DTV_Mostrar_Libros[13, Reglon].Value.ToString();
            string var15 = DTV_Mostrar_Libros[14, Reglon].Value.ToString();
            abrir.Show();
            abrir.SetLibro(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13, var14, var15);
            this.Hide();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            prestamo();
            this.Hide();
        }

        private void DTV_Mostrar_Libros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DTV_Mostrar_Libros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Reglon = DTV_Mostrar_Libros.CurrentCell.RowIndex;
            textBoxCodigo.Text = DTV_Mostrar_Libros[0, Reglon].Value.ToString();           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
