namespace Funeraria_2._0.Menu
{
    partial class MenuPrincipal
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
            this.lblUserMenu = new System.Windows.Forms.Label();
            this.btnContratosMenu = new System.Windows.Forms.Button();
            this.btnServiciosMenu = new System.Windows.Forms.Button();
            this.btnAdminPerfilesMenu = new System.Windows.Forms.Button();
            this.lblCerrarSesionMenu = new System.Windows.Forms.LinkLabel();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserMenu
            // 
            this.lblUserMenu.AutoSize = true;
            this.lblUserMenu.Location = new System.Drawing.Point(600, 13);
            this.lblUserMenu.Name = "lblUserMenu";
            this.lblUserMenu.Size = new System.Drawing.Size(0, 13);
            this.lblUserMenu.TabIndex = 0;
            // 
            // btnContratosMenu
            // 
            this.btnContratosMenu.Location = new System.Drawing.Point(109, 184);
            this.btnContratosMenu.Name = "btnContratosMenu";
            this.btnContratosMenu.Size = new System.Drawing.Size(523, 70);
            this.btnContratosMenu.TabIndex = 1;
            this.btnContratosMenu.Text = "Contratos";
            this.btnContratosMenu.UseVisualStyleBackColor = true;
            this.btnContratosMenu.Click += new System.EventHandler(this.btnContratosMenu_Click);
            // 
            // btnServiciosMenu
            // 
            this.btnServiciosMenu.Location = new System.Drawing.Point(109, 260);
            this.btnServiciosMenu.Name = "btnServiciosMenu";
            this.btnServiciosMenu.Size = new System.Drawing.Size(523, 70);
            this.btnServiciosMenu.TabIndex = 2;
            this.btnServiciosMenu.Text = "Servicios";
            this.btnServiciosMenu.UseVisualStyleBackColor = true;
            this.btnServiciosMenu.Click += new System.EventHandler(this.btnServiciosMenu_Click);
            // 
            // btnAdminPerfilesMenu
            // 
            this.btnAdminPerfilesMenu.Location = new System.Drawing.Point(109, 336);
            this.btnAdminPerfilesMenu.Name = "btnAdminPerfilesMenu";
            this.btnAdminPerfilesMenu.Size = new System.Drawing.Size(523, 70);
            this.btnAdminPerfilesMenu.TabIndex = 3;
            this.btnAdminPerfilesMenu.Text = "Administrar perfil";
            this.btnAdminPerfilesMenu.UseVisualStyleBackColor = true;
            this.btnAdminPerfilesMenu.Click += new System.EventHandler(this.btnAdminPerfilesMenu_Click);
            // 
            // lblCerrarSesionMenu
            // 
            this.lblCerrarSesionMenu.AutoSize = true;
            this.lblCerrarSesionMenu.Location = new System.Drawing.Point(524, 13);
            this.lblCerrarSesionMenu.Name = "lblCerrarSesionMenu";
            this.lblCerrarSesionMenu.Size = new System.Drawing.Size(70, 13);
            this.lblCerrarSesionMenu.TabIndex = 5;
            this.lblCerrarSesionMenu.TabStop = true;
            this.lblCerrarSesionMenu.Text = "Cerrar Sesión";
            this.lblCerrarSesionMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.Image = global::Funeraria_2._0.Properties.Resources.salir;
            this.btnSalirMenu.Location = new System.Drawing.Point(697, 688);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(75, 62);
            this.btnSalirMenu.TabIndex = 4;
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            this.btnSalirMenu.Click += new System.EventHandler(this.btnSalirMenu_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.lblCerrarSesionMenu);
            this.Controls.Add(this.btnSalirMenu);
            this.Controls.Add(this.btnAdminPerfilesMenu);
            this.Controls.Add(this.btnServiciosMenu);
            this.Controls.Add(this.btnContratosMenu);
            this.Controls.Add(this.lblUserMenu);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Button btnContratosMenu;
        private System.Windows.Forms.Button btnServiciosMenu;
        private System.Windows.Forms.Button btnAdminPerfilesMenu;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.LinkLabel lblCerrarSesionMenu;
    }
}