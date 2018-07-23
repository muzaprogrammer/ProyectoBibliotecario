using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.OleDb;

namespace CapaDiseño
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Centrar el Panel
            Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
            Int32 alto = (desktopSize.Height - 350) / 2;
            Int32 ancho = (desktopSize.Width - 500) / 2;
            panel1.Location = new Point(ancho, alto);
            //Fin central el Panel

            //Mostrar Fecha y Hora
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Actualizar cada segundo la Hora
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(57, 56);
            btnIngresar.BackgroundImage = Properties.Resources.btn_hover;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.Size = new Size(55, 54);
            btnIngresar.BackgroundImage = Properties.Resources.btn_ingresar1;
        }
        public static string rol;
        public static string nUsuario;
        public static string user;
        public static string pass;
        public static string ID;

        public static int login(string pUsuario, string pContraseña)
        {
            user = pUsuario;
            pass = pContraseña;            
            //crear el objeto conexion
            //Conexion.Cn_conexion();
            //Conexion.Cn_conexion().Open();
            OleDbConnection CadenaConexion = new OleDbConnection(Conexion.Con());
            CadenaConexion.Open();
            int encontrado = 0;
            //realizar consulta a la base de datos
            string consulta = "select Usuario, Contraseña from Usuarios where Contraseña ='" + pContraseña + "'and Usuario = '" + pUsuario + "';";
            //creando objeto comando
            OleDbCommand Comando = new OleDbCommand(consulta, CadenaConexion);
            //declarando variable reader
            OleDbDataReader lectorDatos;
            //ejecutar la consulta
            lectorDatos = Comando.ExecuteReader();
            //validar si lectorDatos tiene registros
            Boolean existencia = lectorDatos.HasRows;
            //validar los datos del usuario
            if (existencia)
            {

                encontrado = 1;
                OleDbCommand Rol = new OleDbCommand(" select rol FROM Usuarios INNER JOIN Roles ON Usuarios.ID_Rol=Roles.ID_Rol where Usuario ='" + pUsuario + "';", CadenaConexion);
                OleDbDataReader idRol = Rol.ExecuteReader();
                idRol.Read();
                rol = idRol.GetValue(0).ToString() + Environment.NewLine;
                OleDbCommand usuario = new OleDbCommand(" select Nombre_Usuario FROM Usuarios where Usuario ='" + pUsuario + "';", CadenaConexion);
                OleDbDataReader nameUsuario = usuario.ExecuteReader();
                nameUsuario.Read();
                nUsuario = nameUsuario.GetValue(0).ToString() + Environment.NewLine;
                OleDbCommand idusuario = new OleDbCommand(" select ID_Usuario FROM Usuarios where Usuario ='" + pUsuario + "';", CadenaConexion);
                OleDbDataReader IDUsuario = idusuario.ExecuteReader();
                IDUsuario.Read();
                ID = IDUsuario.GetValue(0).ToString() + Environment.NewLine;


            }
            CadenaConexion.Close();
            return encontrado;
        }

        public static int espaciosSolos(string pUsuario, string pContraseña, string pNombres)
        {
            int solos = 0;
            if (pUsuario == "" || pContraseña == "" || pNombres == "")
            {
                solos = 1;
            }
            return solos;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;
            int validado = login(usuario, contraseña);
            if (validado == 1)
            {

                FormMdiInicio abrir = new FormMdiInicio();
                abrir.Show();
                this.Hide();

            }
            else
            {
                textBoxContraseña.Clear();
                textBoxUsuario.Clear();
                MessageBox.Show("Usuario y/o Contraseña no Validos");
            }              
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
