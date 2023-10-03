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
    public partial class AsistenciaReporte : Form
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public AsistenciaReporte()
        {
            InitializeComponent();
        }
        private void AsistenciaReporte_Load(object sender, EventArgs e)
        {
            TableReporteAsistencia.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.Fill);
            CargarDGV();
        }
        private void CargarDGV()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM RegistroAsistencia;", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TableReporteAsistencia.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM RegistroAsistencia WHERE Identificacion = {txtBuscar.Text}", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TableReporteAsistencia.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Desea eliminar todos los registros",
                    "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                int flag;
                string cons = "Delete from RegistroAsistencia;";
                SqlCommand comando = new SqlCommand(cons, conexion);
                flag = comando.ExecuteNonQuery(); //positivo = 1 / negativo = 2
                if (flag == 1) { MessageBox.Show("Los datos se eliminaron correctamente"); }
                else { MessageBox.Show("Error al realizar la operacion"); }
                CargarDGV();
            }
            else if (dg == DialogResult.Cancel)
            {
                MessageBox.Show("Operacion cancelada");
            }
        }
    }
}
