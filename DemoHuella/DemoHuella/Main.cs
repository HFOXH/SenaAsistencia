using DemoHuella.Views;
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

namespace DemoHuella
{
    public partial class Main : Form
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public Main(){
            InitializeComponent();
            conexion.Open();
            if (conexion.State == ConnectionState.Open)
            {
                LabelConexion.Text = "Conexión a la base de datos, establecida Correctamente";
                pictureError.Visible = false;
                conexion.Close();
            }
            else
            {
                LabelConexion.Text = "Error de Conexión a la base de datos";
                pictureError.Visible = true;
            }
        }
        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new()
        {
            Form Formularios;
            Formularios = PanelContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();
            if (Formularios == null)
            {
                Formularios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };
                PanelContenedor.Controls.Add(Formularios);
                PanelContenedor.Tag = Formularios;
                Formularios.Show();
                Formularios.BringToFront();
            }
            else { Formularios.BringToFront(); }
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            AbrirFormularios<frmVerificar>();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Users>();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormularios<AsistenciaReporte>();
        }
        private void btnAreas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Areas>();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularios<Ayuda>();
        }
    }
}
