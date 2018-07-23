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
    public partial class AgregarUsuaario : Form
    {
        public AgregarUsuaario()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void btnCancelarEntrega_Click(object sender, EventArgs e)
        {
            
            Usuarios.DefInstance.Show();
            this.Close();
            
        }

        private Libros Asig_Usuario_text()
        {
            string nombre, usuario, contraseña, rol, correo, telefono;

            nombre = textBox1.Text;
            usuario = textBox2.Text;
            contraseña = textBox3.Text;
            rol = Convert.ToString(comboBox1.SelectedIndex);
            correo = textBox5.Text;
            telefono = textBox6.Text;
            
            Libros L = new Libros(nombre, usuario, contraseña, rol, correo, telefono);

            return L;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libros aux = Asig_Usuario_text();

            int Resultado = Metodos.RegistrarUsuario(aux);




            if (Resultado > 0)
            {
                MessageBox.Show("Los Datos se Registrados Correctamente ", "Registro de Datos ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Registro de Datos NO Realizado ", "Error al Registrar la Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarUsuaario_Load(object sender, EventArgs e)
        {

        }
        private static AgregarUsuaario m_FormDefInstance;
        public static AgregarUsuaario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new AgregarUsuaario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
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

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.DimGray;
            button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Silver;
            button2.ForeColor = Color.Black;
        }
    }
}
