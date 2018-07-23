using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class AgregarLibro : Form
    {
        public AgregarLibro()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
        private static AgregarLibro m_FormDefInstance;
        public static AgregarLibro DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new AgregarLibro();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Libros Asig_Libro_text()
        {
            int id = 0, ISBN = 0, Cantidad = 0, Volumen = 0, Numero_de_Paginas = 0;
            string Titulo, Autor, Catalogacion, Edicion, Resumen, Fecha_de_Adquisicion, Editorial, Pais, Ciudad, ID_Libro_Estado;


            Titulo = txtTitulo.Text;
            Autor = txtAutor.Text;
            Catalogacion = txtCatalogacion.Text;
            Edicion = txtEdicion.Text;
            Fecha_de_Adquisicion = dateFecha_de_Adquisicion.Text;
            Editorial = txtEditorial.Text;
            Resumen = txtResumen.Text;
            Pais = ConbPais.Text;
            Ciudad = ConbCiudad.Text;
            ID_Libro_Estado = comboEstado.Text;

            try
            {
                id = int.Parse(txtCodigo.Text);
            }
            catch
            {
                MessageBox.Show("INGRESE UN VALOR NUMERIOCO CODIGO");
                txtCodigo.Focus();
                txtCodigo.SelectionStart = 0;
                txtCodigo.SelectionStart = txtCodigo.Text.Length;

            }
            try
            {
                ISBN = int.Parse(txtISBN.Text);
            }
            catch
            {
                MessageBox.Show("INGRESE UN VALOR NUMERIOCO ISBN");
                txtISBN.Focus();
                txtISBN.SelectionStart = 0;
                txtISBN.SelectionStart = txtISBN.Text.Length;
            }
            try
            {
                Cantidad = int.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("INGRESE UN VALOR NUMERIOCO CANTIDAD");
                txtCantidad.Focus();
                txtCantidad.SelectionStart = 0;
                txtCantidad.SelectionStart = txtCantidad.Text.Length;
            }
            try
            {
                Volumen = int.Parse(txtVolumen.Text);
            }
            catch
            {
                MessageBox.Show("INGRESE UN VALOR NUMERIOCO VOLUMEN");
                txtVolumen.Focus();
                txtVolumen.SelectionStart = 0;
                txtVolumen.SelectionStart = txtVolumen.Text.Length;
            }
            try
            {
                Numero_de_Paginas = int.Parse(txtNumero_de_Paginas.Text);
            }
            catch
            {
                MessageBox.Show("INGRESE UN VALOR NUMERIOCO EN NUMERO DE PAGINAS");
                txtNumero_de_Paginas.Focus();
                txtNumero_de_Paginas.SelectionStart = 0;
                txtNumero_de_Paginas.SelectionStart = txtNumero_de_Paginas.Text.Length;

            }


            Libros L = new Libros(id, Titulo, Autor, Catalogacion, Edicion, Fecha_de_Adquisicion,
             Resumen, Editorial, Numero_de_Paginas, Volumen, Ciudad, Pais, ISBN, Cantidad, ID_Libro_Estado);

            return L;

        }
        void Limpiar()
        {
            txtAutor.Text = " ";
            txtTitulo.Text = " ";
            txtCatalogacion.Text = " ";
            txtEdicion.Text = " ";
            txtCodigo.Text = " ";
            txtResumen.Text = " ";
            txtEditorial.Text = " ";
            txtISBN.Text = " ";
            txtCantidad.Text = " ";
            txtNumero_de_Paginas.Text = " ";
            ConbCiudad.Text = " ";
            ConbPais.Text = " ";
            txtVolumen.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libros aux = Asig_Libro_text();

            int Resultado = Metodos.Registrar(aux);




            if (Resultado > 0)
            {
                MessageBox.Show("Los Datos se Registrados Correctamente ", "Registro de Datos ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpiar();
            }
            else
            {
                MessageBox.Show("Registro de Datos NO Realizado ", "Error al Registrar la Informacion ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AgregarLibro_Load(object sender, EventArgs e)
        {

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void ConbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_MouseHover(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.DimGray;
            btnGuardar.ForeColor = Color.White;
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            btnGuardar.BackColor = Color.Silver;
            btnGuardar.ForeColor = Color.Black;
        }

        private void btnCancelarIngreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarIngreso_MouseHover(object sender, EventArgs e)
        {
            btnCancelarIngreso.BackColor = Color.DimGray;
            btnCancelarIngreso.ForeColor = Color.White;
        }

        private void btnCancelarIngreso_MouseLeave(object sender, EventArgs e)
        {
            btnCancelarIngreso.BackColor = Color.Silver;
            btnCancelarIngreso.ForeColor = Color.Black;
        }
    }


}
