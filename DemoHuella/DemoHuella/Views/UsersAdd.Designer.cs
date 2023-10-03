﻿namespace DemoHuella.Views
{
    partial class UsersAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersAdd));
            this.btnRegistraHuella = new System.Windows.Forms.Button();
            this.txtHuella = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellidos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNombres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TxtIdentificacion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistraHuella
            // 
            this.btnRegistraHuella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistraHuella.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegistraHuella.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraHuella.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRegistraHuella.Location = new System.Drawing.Point(339, 116);
            this.btnRegistraHuella.Name = "btnRegistraHuella";
            this.btnRegistraHuella.Size = new System.Drawing.Size(154, 31);
            this.btnRegistraHuella.TabIndex = 31;
            this.btnRegistraHuella.Text = "Registrar Huella";
            this.btnRegistraHuella.UseVisualStyleBackColor = true;
            this.btnRegistraHuella.Click += new System.EventHandler(this.btnRegistraHuella_Click);
            // 
            // txtHuella
            // 
            this.txtHuella.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHuella.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtHuella.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHuella.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtHuella.BorderThickness = 1;
            this.txtHuella.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHuella.Enabled = false;
            this.txtHuella.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuella.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHuella.isPassword = false;
            this.txtHuella.Location = new System.Drawing.Point(511, 116);
            this.txtHuella.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHuella.Name = "txtHuella";
            this.txtHuella.Size = new System.Drawing.Size(101, 31);
            this.txtHuella.TabIndex = 32;
            this.txtHuella.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // comboArea
            // 
            this.comboArea.Font = new System.Drawing.Font("Poppins", 8F);
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(35, 344);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(577, 27);
            this.comboArea.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 23);
            this.label8.TabIndex = 45;
            this.label8.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtCorreo.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtCorreo.BorderThickness = 1;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo.isPassword = false;
            this.txtCorreo.Location = new System.Drawing.Point(339, 269);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 29);
            this.txtCorreo.TabIndex = 44;
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtCelular.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtCelular.BorderThickness = 1;
            this.txtCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCelular.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCelular.isPassword = false;
            this.txtCelular.Location = new System.Drawing.Point(35, 269);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(271, 29);
            this.txtCelular.TabIndex = 42;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Area:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Identificación:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtApellidos.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtApellidos.BorderThickness = 1;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellidos.isPassword = false;
            this.txtApellidos.Location = new System.Drawing.Point(339, 189);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(272, 29);
            this.txtApellidos.TabIndex = 37;
            this.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.txtNombres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.txtNombres.BorderThickness = 1;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombres.isPassword = false;
            this.txtNombres.Location = new System.Drawing.Point(35, 189);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(271, 29);
            this.txtNombres.TabIndex = 36;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.BackColor = System.Drawing.Color.White;
            this.TxtIdentificacion.BorderColorFocused = System.Drawing.Color.DodgerBlue;
            this.TxtIdentificacion.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtIdentificacion.BorderColorMouseHover = System.Drawing.Color.DodgerBlue;
            this.TxtIdentificacion.BorderThickness = 1;
            this.TxtIdentificacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIdentificacion.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtIdentificacion.isPassword = false;
            this.TxtIdentificacion.Location = new System.Drawing.Point(34, 116);
            this.TxtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(272, 29);
            this.TxtIdentificacion.TabIndex = 35;
            this.TxtIdentificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 34);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nuevo Usuario";
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarEmp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregarEmp.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregarEmp.Location = new System.Drawing.Point(216, 409);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(210, 35);
            this.btnAgregarEmp.TabIndex = 33;
            this.btnAgregarEmp.Text = "Registrar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            // 
            // UsersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(667, 502);
            this.Controls.Add(this.btnRegistraHuella);
            this.Controls.Add(this.txtHuella);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.UsersAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistraHuella;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtHuella;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCorreo;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtApellidos;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNombres;
        private Bunifu.Framework.UI.BunifuMetroTextbox TxtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarEmp;
    }
}