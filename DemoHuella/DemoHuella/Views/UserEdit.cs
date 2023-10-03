using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHuella.Views
{
    public partial class UserEdit : Form
    {
        private DPFP.Template Template;
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public UserEdit(int pId)
        {
            InitializeComponent();
            Buscar(pId);
        }
        //referencia para actualizar la huella
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
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
        private void Buscar(int pId)
        {
            try{
                using (BeOnTimeDBEntities db = new BeOnTimeDBEntities())
                {
                    var Lst2 = db.Empleado.Where(p => p.Identificacion == pId).ToList();
                    if (Lst2.Count > 0)
                    {
                        foreach (Empleado Emp in Lst2)
                        {
                            TxtIdentificacion.Text = Emp.Identificacion.ToString();
                            txtNombres.Text = Emp.Nombres.ToString();
                            txtApellidos.Text = Emp.Apellidos.ToString();
                            comboArea.Text = Emp.Area.ToString();
                            txtCelular.Text = Emp.Celular.ToString();
                            txtCorreo.Text = Emp.Correo.ToString();
                            txtHuella.Text = Emp.Huella.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Empleado SET Nombres = @Nombres, Apellidos = @Apellidos, Area = @Area, Celular = @Celular, Correo = @Correo, Huella = @Huella WHERE EmpleadoId = @EmpleadoId;";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Nombres", txtNombres.Text);
                comando.Parameters.AddWithValue("@Apellidos", txtApellidos.Text);
                comando.Parameters.AddWithValue("@Area", comboArea.SelectedValue);
                comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
                comando.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                comando.Parameters.AddWithValue("@Huella", txtHuella.Text);
                comando.Parameters.AddWithValue("@EmpleadoId", Convert.ToDecimal(TxtIdentificacion.Text));

                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistraHuella_Click(object sender, EventArgs e)
        {
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }
    }
}
