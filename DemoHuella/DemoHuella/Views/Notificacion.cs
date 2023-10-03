using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoHuella
{
    public partial class Notificacion : Form
    {
        public Notificacion()
        {
            InitializeComponent();
        }
        public Notificacion(string pMensaje, string pNombre, Color pColor, int tipo)
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;
            lblNombre.Text = pNombre;
            lblMensaje.ForeColor = pColor;
            pTop.BackColor = pColor;
            if (tipo == 1)
            {
                pictureError.Visible = false;
            }
            if (tipo == 2) 
            {
                pictureSuccess.Visible = false;
            }
        }
        private int conteo;

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo == 30) {
                this.Close();
            }
        }

        private void Notificacion_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            timer1.Start();
        }

        private void Notificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
