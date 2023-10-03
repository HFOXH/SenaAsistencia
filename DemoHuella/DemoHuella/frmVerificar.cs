using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DemoHuella
{
    public partial class frmVerificar : CaptureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;
        private BeOnTimeDBEntities contexto;
        private BeOnTimeDBEntities contexto1;
        private SqlConnection conexion = new SqlConnection("Server=Asistencia.mssql.somee.com;Database=Asistencia;User Id=XXXkingXXX_SQLLogin_1;Password=tvhijitaj8;");

        public void Verify(DPFP.Template template)
        {
            Template = template;
            ShowDialog();
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Verificación de Huella Digital";
            Verificator = new DPFP.Verification.Verification();     // Create a fingerprint template verificator
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            // Show "False accept rate" value
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        protected override void Process(DPFP.Sample Sample)
        {
            base.Process(Sample);

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

                DPFP.Template template = new DPFP.Template();
                Stream stream;

                foreach (var emp in contexto.Empleado)
                {
                    stream = new MemoryStream(emp.Huella);
                    template = new DPFP.Template(stream);

                    Verificator.Verify(features, template, ref result);
                    UpdateStatus(result.FARAchieved);
                    if (result.Verified)
                    {
                        MakeReport("La huella ha sido verificada satisfactoriamente. " + emp.Nombres);
                        string Fecha = DateTime.Now.ToString("yyy-MM-dd");//Fecha actual del sistema
                        DateTime Hora = DateTime.Now;//hora actual del sistema
                        conexion.Open();
                        //consulta para saber si las horas ya estan en la BD
                        string consultahoraingreso = "SELECT * FROM RegistroAsistencia where EmpleadoId=" + emp.Identificacion + " AND Fecha='" + Fecha + "'";
                        SqlCommand comando0 = new SqlCommand(consultahoraingreso, conexion);
                        SqlDataReader consultaIngreso = comando0.ExecuteReader();
                        if (consultaIngreso.Read())
                        {
                            //variables para consultar las horas cada vez que se ponga el dedo
                            var horaingresoenBD = consultaIngreso["HoraIngreso"].ToString();
                            var horasalidaenBD = consultaIngreso["HoraSalida"].ToString();
                            //si la hora que esta en la BD, es null, va a poner la hora de ingreso
                            if (horaingresoenBD == "")
                            {
                                conexion.Close();
                                try
                                {
                                    string HoraIngreso = DateTime.Now.ToString("HH:mm:ss");
                                    MakeReport("Hora Ingreso:" + HoraIngreso);
                                    RegistroAsistencia tiempo = new RegistroAsistencia()
                                    {
                                        EmpleadoId = emp.Identificacion,
                                        HoraIngreso = TimeSpan.Parse(HoraIngreso),
                                        Fecha = Convert.ToDateTime(Fecha)
                                    };
                                    contexto1.RegistroAsistencia.Add(tiempo);
                                    contexto1.SaveChanges();
                                    MakeReport("Su Hora de Ingreso se guardo con exito!");
                                    Notificacion n = new Notificacion("¡Su Hora de Ingreso se guardo con exito!", emp.Nombres, Color.FromArgb(15, 202, 54), 1);
                                    n.Show();
                                }
                                catch (Exception ex) { MessageBox.Show(ex.Message); }
                                break;
                            }
                            else if (horasalidaenBD == "")
                            {
                                DateTime verhoraingreso = Convert.ToDateTime(horaingresoenBD);
                                if (Hora < verhoraingreso.AddMinutes(10))
                                {
                                    MakeReport("¡Su Hora de Ingreso ya se registró!");
                                    Notificacion n = new Notificacion("¡Su Hora de Ingreso ya se ha registrado!", emp.Nombres, Color.FromArgb(202, 15, 15), 2);
                                    n.Show();
                                    conexion.Close();
                                    break;
                                }
                                else {
                                    conexion.Close();
                                    try
                                    {
                                        string HoraSalida = DateTime.Now.ToString("HH:mm:ss");
                                        string query = "UPDATE RegistroAsistencia set HoraSalida='" + HoraSalida + "'where EmpleadoId=" + emp.Identificacion + " AND Fecha='" + Fecha + "'";
                                        conexion.Open();
                                        SqlCommand comando = new SqlCommand(query, conexion);
                                        comando.ExecuteNonQuery();
                                        conexion.Close();
                                        MakeReport("Su Hora de Salida se guardo con exito!");
                                        Notificacion n = new Notificacion("¡Su Hora de Salida se guardo con exito!", emp.Nombres, Color.FromArgb(0, 130, 255), 1);
                                        n.Show();
                                    }
                                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                                    break;
                                }
                            }else{
                                MakeReport("¡Su Hora ya se ha registrado!");
                                Notificacion n = new Notificacion("¡Su Hora ya se ha registrado!", emp.Nombres, Color.FromArgb(202, 15, 15), 2);
                                n.Show();
                                conexion.Close();
                            }
                        }
                        else 
                        {
                            conexion.Close();
                            try
                            {
                                string HoraIngreso = DateTime.Now.ToString("HH:mm:ss");
                                MakeReport("Hora Ingreso:" + HoraIngreso);
                                RegistroAsistencia tiempo = new RegistroAsistencia()
                                {
                                    EmpleadoId = emp.Identificacion,
                                    HoraIngreso = TimeSpan.Parse(HoraIngreso),
                                    Fecha = Convert.ToDateTime(Fecha)
                                };
                                contexto1.RegistroAsistencia.Add(tiempo);
                                contexto1.SaveChanges();
                                MakeReport("Su Hora de Ingreso se guardo con exito!");
                                Notificacion n = new Notificacion("¡Su Hora de Ingreso se guardo con exito!", emp.Nombres, Color.FromArgb(15, 202, 54), 1);
                                n.Show();
                            }
                            catch (Exception ex) { MessageBox.Show(ex.Message); }
                        }
                    }
                }
            }
        }
        public frmVerificar()
        {
            contexto = new BeOnTimeDBEntities();
            contexto1 = new BeOnTimeDBEntities();
            InitializeComponent();
        }
    }
}
