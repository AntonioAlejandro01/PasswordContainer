﻿namespace PasswordContainer
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.sFileDial = new System.Windows.Forms.SaveFileDialog();
            this.menStMain = new System.Windows.Forms.MenuStrip();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarDocumentoDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblListado = new System.Windows.Forms.Label();
            this.listBoxCuentasApp = new System.Windows.Forms.ListBox();
            this.btnRecogerCuenta = new System.Windows.Forms.Button();
            this.lblNombreCuenta = new System.Windows.Forms.Label();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.lblPeligro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblPeligro2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.menStMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // sFileDial
            // 
            this.sFileDial.DefaultExt = "txt";
            this.sFileDial.FileName = "Cuentas";
            // 
            // menStMain
            // 
            this.menStMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menStMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menStMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.guardarCambiosToolStripMenuItem,
            this.generarDocumentoDeTextoToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menStMain.Location = new System.Drawing.Point(0, 0);
            this.menStMain.Name = "menStMain";
            this.menStMain.Size = new System.Drawing.Size(861, 29);
            this.menStMain.TabIndex = 0;
            this.menStMain.Text = "menuStrip1";
            this.menStMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenStMain_ItemClicked);
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.añadirToolStripMenuItem.Text = "Añadir";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.Aniadir);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.Eliminar);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // guardarCambiosToolStripMenuItem
            // 
            this.guardarCambiosToolStripMenuItem.Name = "guardarCambiosToolStripMenuItem";
            this.guardarCambiosToolStripMenuItem.Size = new System.Drawing.Size(144, 25);
            this.guardarCambiosToolStripMenuItem.Text = "Guardar Cambios";
            this.guardarCambiosToolStripMenuItem.Click += new System.EventHandler(this.SavesChanges);
            // 
            // generarDocumentoDeTextoToolStripMenuItem
            // 
            this.generarDocumentoDeTextoToolStripMenuItem.Name = "generarDocumentoDeTextoToolStripMenuItem";
            this.generarDocumentoDeTextoToolStripMenuItem.Size = new System.Drawing.Size(222, 25);
            this.generarDocumentoDeTextoToolStripMenuItem.Text = "Generar Documento de texto";
            this.generarDocumentoDeTextoToolStripMenuItem.Click += new System.EventHandler(this.generateTxt);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(21, 51);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(118, 25);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado de ";
            // 
            // listBoxCuentasApp
            // 
            this.listBoxCuentasApp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxCuentasApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCuentasApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCuentasApp.FormattingEnabled = true;
            this.listBoxCuentasApp.ItemHeight = 24;
            this.listBoxCuentasApp.Location = new System.Drawing.Point(26, 104);
            this.listBoxCuentasApp.Name = "listBoxCuentasApp";
            this.listBoxCuentasApp.Size = new System.Drawing.Size(221, 242);
            this.listBoxCuentasApp.TabIndex = 2;
            // 
            // btnRecogerCuenta
            // 
            this.btnRecogerCuenta.Location = new System.Drawing.Point(26, 352);
            this.btnRecogerCuenta.Name = "btnRecogerCuenta";
            this.btnRecogerCuenta.Size = new System.Drawing.Size(221, 32);
            this.btnRecogerCuenta.TabIndex = 3;
            this.btnRecogerCuenta.Text = "Seleccionar";
            this.btnRecogerCuenta.UseVisualStyleBackColor = true;
            this.btnRecogerCuenta.Click += new System.EventHandler(this.BtnRecogerCuenta_Click);
            // 
            // lblNombreCuenta
            // 
            this.lblNombreCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreCuenta.Location = new System.Drawing.Point(302, 51);
            this.lblNombreCuenta.Name = "lblNombreCuenta";
            this.lblNombreCuenta.Size = new System.Drawing.Size(479, 53);
            this.lblNombreCuenta.TabIndex = 4;
            this.lblNombreCuenta.Text = "Nombre de la cuenta";
            this.lblNombreCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(260, 288);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(282, 96);
            this.btnDesencriptar.TabIndex = 7;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.BtnDesencriptar_Click);
            // 
            // lblPeligro
            // 
            this.lblPeligro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPeligro.Image = ((System.Drawing.Image)(resources.GetObject("lblPeligro.Image")));
            this.lblPeligro.Location = new System.Drawing.Point(686, 136);
            this.lblPeligro.Name = "lblPeligro";
            this.lblPeligro.Size = new System.Drawing.Size(135, 112);
            this.lblPeligro.TabIndex = 8;
            this.lblPeligro.MouseHover += new System.EventHandler(this.LblPeligro_MouseHover);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(398, 136);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.ReadOnly = true;
            this.lblUsuario.Size = new System.Drawing.Size(282, 28);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "---------";
            this.lblUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblUsuario.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(398, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.ReadOnly = true;
            this.lblPassword.Size = new System.Drawing.Size(282, 28);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "---------";
            this.lblPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblPassword.UseSystemPasswordChar = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Peligro";
            // 
            // lblPeligro2
            // 
            this.lblPeligro2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPeligro2.Image = ((System.Drawing.Image)(resources.GetObject("lblPeligro2.Image")));
            this.lblPeligro2.Location = new System.Drawing.Point(257, 136);
            this.lblPeligro2.Name = "lblPeligro2";
            this.lblPeligro2.Size = new System.Drawing.Size(135, 112);
            this.lblPeligro2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(253, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 172);
            this.label1.TabIndex = 12;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(548, 288);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(282, 96);
            this.btnEncriptar.TabIndex = 13;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.BtnEncriptar_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 430);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.lblPeligro2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblPeligro);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.lblNombreCuenta);
            this.Controls.Add(this.btnRecogerCuenta);
            this.Controls.Add(this.listBoxCuentasApp);
            this.Controls.Add(this.lblListado);
            this.Controls.Add(this.menStMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menStMain;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baúl de Contraseñas";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menStMain.ResumeLayout(false);
            this.menStMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sFileDial;
        private System.Windows.Forms.MenuStrip menStMain;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.ListBox listBoxCuentasApp;
        private System.Windows.Forms.Button btnRecogerCuenta;
        private System.Windows.Forms.Label lblNombreCuenta;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Label lblPeligro;
        private System.Windows.Forms.ToolStripMenuItem generarDocumentoDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.TextBox lblUsuario;
        private System.Windows.Forms.TextBox lblPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPeligro2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncriptar;
    }
}

