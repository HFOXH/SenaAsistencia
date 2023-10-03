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
    public partial class Users : Form
    {
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        public Users()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            UsersAdd newUser = new UsersAdd();
            newUser.Show();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            CargarDGV();
        }
        private void CargarDGV()
        {
            try
            {
                SqlCommand comando = new SqlCommand("SELECT Identificacion, Nombres, Apellidos, Area, Celular, Correo FROM Empleado;", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TablaEmpleado.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int TotalSeleccion = TablaEmpleado.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["Column1"].Value)).Count();
            DialogResult dg;
            int Id;
            if (TotalSeleccion >= 1)
            {
                dg = MessageBox.Show("Desea eliminar los " + TotalSeleccion + " registros seleccionados",
                    "Verificación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dg == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in TablaEmpleado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Column1"].Value))
                        {
                            Id = Convert.ToInt32(row.Cells["Identificacion"].Value);
                            EliminarEmp(Id);
                        }
                    }
                    MessageBox.Show("Registro(s) eliminados con exito");
                    CargarDGV();
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
        }
        private void EliminarEmp(int pId){
            try{
                using (BeOnTimeDBEntities db = new BeOnTimeDBEntities()){
                    db.Empleado.Remove(db.Empleado.Single(p => p.Identificacion == pId));
                    db.SaveChanges();
                }
            }catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void TablaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pId;
            if (TablaEmpleado.Columns[e.ColumnIndex].Name == "Column2")
            {
                pId = Convert.ToInt32(TablaEmpleado.CurrentRow.Cells["Identificacion"].Value.ToString());
                UserEdit f2 = new UserEdit(pId);
                f2.ShowDialog();
                CargarDGV();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarDGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand comando = new SqlCommand($"SELECT EmpleadoId, Nombres, Apellidos, Area, TrabajaSabados, HoraAlmuerzo FROM Empleado WHERE EmpleadoId = {txtBuscar.Text}", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TablaEmpleado.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
