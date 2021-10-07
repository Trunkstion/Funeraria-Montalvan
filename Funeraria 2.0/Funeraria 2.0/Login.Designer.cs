namespace Funeraria_2._0
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserLogin = new System.Windows.Forms.TextBox();
            this.txtPassLogin = new System.Windows.Forms.TextBox();
            this.lblFechaLogin = new System.Windows.Forms.Label();
            this.lblErrorUserLogin = new System.Windows.Forms.Label();
            this.lblErrorPassLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.Location = new System.Drawing.Point(30, 219);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarLogin.TabIndex = 0;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = true;
            this.btnIngresarLogin.Click += new System.EventHandler(this.btnIngresarLogin_Click);
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.Location = new System.Drawing.Point(148, 219);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSalirLogin.TabIndex = 1;
            this.btnSalirLogin.Text = "Salir";
            this.btnSalirLogin.UseVisualStyleBackColor = true;
            this.btnSalirLogin.Click += new System.EventHandler(this.btnSalirLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rut usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtUserLogin
            // 
            this.txtUserLogin.Location = new System.Drawing.Point(96, 71);
            this.txtUserLogin.MaxLength = 9;
            this.txtUserLogin.Name = "txtUserLogin";
            this.txtUserLogin.Size = new System.Drawing.Size(127, 20);
            this.txtUserLogin.TabIndex = 4;
            this.txtUserLogin.Leave += new System.EventHandler(this.txtUserLogin_Leave);
            this.txtUserLogin.MouseHover += new System.EventHandler(this.txtUserLogin_MouseHover);
            // 
            // txtPassLogin
            // 
            this.txtPassLogin.Location = new System.Drawing.Point(96, 130);
            this.txtPassLogin.Name = "txtPassLogin";
            this.txtPassLogin.PasswordChar = '*';
            this.txtPassLogin.Size = new System.Drawing.Size(127, 20);
            this.txtPassLogin.TabIndex = 5;
            this.txtPassLogin.Leave += new System.EventHandler(this.txtPassLogin_Leave);
            // 
            // lblFechaLogin
            // 
            this.lblFechaLogin.AutoSize = true;
            this.lblFechaLogin.Location = new System.Drawing.Point(96, 303);
            this.lblFechaLogin.Name = "lblFechaLogin";
            this.lblFechaLogin.Size = new System.Drawing.Size(0, 13);
            this.lblFechaLogin.TabIndex = 6;
            // 
            // lblErrorUserLogin
            // 
            this.lblErrorUserLogin.AutoSize = true;
            this.lblErrorUserLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserLogin.Location = new System.Drawing.Point(96, 52);
            this.lblErrorUserLogin.Name = "lblErrorUserLogin";
            this.lblErrorUserLogin.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUserLogin.TabIndex = 7;
            // 
            // lblErrorPassLogin
            // 
            this.lblErrorPassLogin.AutoSize = true;
            this.lblErrorPassLogin.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassLogin.Location = new System.Drawing.Point(96, 111);
            this.lblErrorPassLogin.Name = "lblErrorPassLogin";
            this.lblErrorPassLogin.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPassLogin.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(255, 328);
            this.Controls.Add(this.lblErrorPassLogin);
            this.Controls.Add(this.lblErrorUserLogin);
            this.Controls.Add(this.lblFechaLogin);
            this.Controls.Add(this.txtPassLogin);
            this.Controls.Add(this.txtUserLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.btnIngresarLogin);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.Button btnSalirLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserLogin;
        private System.Windows.Forms.TextBox txtPassLogin;
        private System.Windows.Forms.Label lblFechaLogin;
        private System.Windows.Forms.Label lblErrorUserLogin;
        private System.Windows.Forms.Label lblErrorPassLogin;
    }
}

