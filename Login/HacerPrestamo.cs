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
    public partial class HacerPrestamo : Form
    {
        public HacerPrestamo()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void HacerPrestamo_Load(object sender, EventArgs e)
        {
            lblnombre.Text = "Usuario que hace el prestamo: "+FormLogin.nUsuario;
            lblFecha.Text = DateTime.Now.ToLongDateString();
            fechaentrega.Text = "Seleccione si es prestamo interno o externo para saber fecha de entrega";

        }
        public void SetLibro(string var1, string var2, string var3, string var4, string var5, string var6, string var7, string var8, string var9, string var10, string var11, string var12, string var13, string var14, string var15)
        {
            lbl_id_libro.Text = var1;
            label1.Text = "Id libro: "+var1;
            label2.Text = "Titulo: "+var2;
            label3.Text = "Autor: " + var3;
            label4.Text = "Catalogacion: " + var4;
            label5.Text = "Edicion: " + var5;
            label6.Text = "Fecha adquisicion: " + var6;
            label7.Text = "Editorial: "+var7;
            //label8.Text = "Resumen: " + var8;
            label9.Text = "Numero de paginas: " + var9;
            label10.Text = "Volumen: " + var10;
            label11.Text = "Ciudad: " + var11;
            label12.Text = "Pais: " + var12;
            label13.Text = "ISBN: " + var13;
            label14.Text = "Cantidad: " + var14;
            label15.Text = "Estado Libro: " + var15;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        DateTime fecha;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text=="Interno")
            {
                fecha = DateTime.Parse(DateTime.Now.ToShortDateString());
                fechaentrega.Text =DateTime.Now.ToLongDateString();
            }
            else if (comboBox2.Text == "Externo")
            {
                fecha = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                fecha = fecha.AddDays(3);
                fechaentrega.Text = Convert.ToString(fecha);
            }
            else
            {
                fechaentrega.Text = "";
            }
        }
        private Libros Asig_Prestamo_text()
        {
            int id_usuario;
            DateTime fecha_prestamo;
            DateTime fecha_entrega;
            string tipo_prestamo;
            string estado_prestamo;
            int id_libro;

            string prestamo = "Prestado";
            id_usuario = Convert.ToInt32(FormLogin.ID);
            fecha_prestamo = DateTime.Now;
            fecha_entrega = Convert.ToDateTime(fechaentrega.Text);
            tipo_prestamo = comboBox2.Text;
            estado_prestamo = prestamo;
            id_libro = Convert.ToInt32(lbl_id_libro.Text);

            Libros L = new Libros(id_usuario, fecha_prestamo, fecha_entrega,tipo_prestamo, estado_prestamo, id_libro);

            return L;

        }
        private void btnEntregarLibro_Click(object sender, EventArgs e)
        {
            Libros aux = Asig_Prestamo_text();

            int Resultado = Metodos.RegistrarPrestamo(aux);




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

        private void btnCancelarEntrega_Click(object sender, EventArgs e)
        {
            Busqueda.DefInstance.Show();
            this.Close();
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

