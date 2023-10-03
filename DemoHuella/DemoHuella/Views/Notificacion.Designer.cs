namespace DemoHuella
{
    partial class Notificacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacion));
            this.pTop = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureSuccess = new System.Windows.Forms.PictureBox();
            this.pictureError = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureError)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.Controls.Add(this.lblMensaje);
            this.pTop.Controls.Add(this.lblNombre);
            this.pTop.Controls.Add(this.pictureSuccess);
            this.pTop.Controls.Add(this.pictureError);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(452, 104);
            this.pTop.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMensaje.Location = new System.Drawing.Point(97, 57);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(58, 28);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "label1";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.lblNombre.Location = new System.Drawing.Point(97, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 28);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "label1";
            // 
            // pictureSuccess
            // 
            this.pictureSuccess.Image = ((System.Drawing.Image)(resources.GetObject("pictureSuccess.Image")));
            this.pictureSuccess.Location = new System.Drawing.Point(28, 26);
            this.pictureSuccess.Name = "pictureSuccess";
            this.pictureSuccess.Size = new System.Drawing.Size(50, 50);
            this.pictureSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSuccess.TabIndex = 2;
            this.pictureSuccess.TabStop = false;
            // 
            // pictureError
            // 
            this.pictureError.Image = ((System.Drawing.Image)(resources.GetObject("pictureError.Image")));
            this.pictureError.Location = new System.Drawing.Point(28, 26);
            this.pictureError.Name = "pictureError";
            this.pictureError.Size = new System.Drawing.Size(50, 50);
            this.pictureError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureError.TabIndex = 1;
            this.pictureError.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 104);
            this.Controls.Add(this.pTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notificacion_FormClosed);
            this.Load += new System.EventHandler(this.Notificacion_Load);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.PictureBox pictureError;
        private System.Windows.Forms.PictureBox pictureSuccess;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNombre;
    }
}