using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHuella.Views
{
    public partial class UsersAdd : Form
    {
        private DPFP.Template Template;
        private BeOnTimeDBEntities contexto;
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public UsersAdd()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnAgregarEmp.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("El patrón de la huella se ha registrado correctamente.", "Registro de Huella");
                    txtHuella.Text = "Huella capturada correctamente";
                    txtHuella.BackColor = Color.FromArgb(60, 179, 113);
                }
                else
                {
                    MessageBox.Show("El patrón de la huella no es valido. Repita el Registro.", "Registro de Huella");
                    txtHuella.Text = "Error en la captura de Huella";
                    txtHuella.BackColor = Color.FromArgb(203, 92, 92);
                }
            }));
        }
        private void UsersAdd_Load(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Area";

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(tabla);
            comboArea.DataSource = tabla;
            comboArea.DisplayMember = "NombreArea";
            comboArea.ValueMember = "IdArea";
        }

        private void btnAgregarEmp_Click(object sender, EventArgs e)
        {
            try {
                byte[] streamHuella = Template.Bytes;
                Empleado empleado = new Empleado()
                {
                    Identificacion = Decimal.Parse(TxtIdentificacion.Text),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Area = (int?)comboArea.SelectedValue,
                    Celular = Decimal.Parse(txtCelular.Text),
                    Correo = txtCorreo.Text,
                    Huella = streamHuella
                };
                contexto.Empleado.Add(empleado);
                contexto.SaveChanges();
                MessageBox.Show("Registro guardado satisfactoriamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                Template = null;
                btnAgregarEmp.Enabled = false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtHuella.Text = "";
            TxtIdentificacion.Text = "";
        }
        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.Show();
        }
        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresNumeros(sender, e);
        }
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresLetras(sender, e);
        }
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresLetras(sender, e);
        }
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionCaracteresNumeros(sender, e);
        }
        public void validacionCaracteresLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Por favor, solo ingrese letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void validacionCaracteresNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor, solo ingrese números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegistraHuella_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }
    }
}
