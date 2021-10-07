namespace Funeraria_2._0.Contratos
{
    partial class SeleccionarContrato
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
            this.lbxRutFall = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbxNombrefall = new System.Windows.Forms.ListBox();
            this.lbxNombreContr = new System.Windows.Forms.ListBox();
            this.lbxRutContra = new System.Windows.Forms.ListBox();
            this.lbxVendedor = new System.Windows.Forms.ListBox();
            this.lbxFechaContr = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalirSeleccionarContrato = new System.Windows.Forms.Button();
            this.btnModificarSeleccionarContrato = new System.Windows.Forms.Button();
            this.btnEliminarSeleccionarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxRutFall
            // 
            this.lbxRutFall.FormattingEnabled = true;
            this.lbxRutFall.Location = new System.Drawing.Point(38, 81);
            this.lbxRutFall.Name = "lbxRutFall";
            this.lbxRutFall.Size = new System.Drawing.Size(99, 381);
            this.lbxRutFall.TabIndex = 0;
            this.lbxRutFall.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rut fallecido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rut contratante";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Nombre contratante";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Nombre fallecido";
            // 
            // lbxNombrefall
            // 
            this.lbxNombrefall.FormattingEnabled = true;
            this.lbxNombrefall.Location = new System.Drawing.Point(143, 81);
            this.lbxNombrefall.Name = "lbxNombrefall";
            this.lbxNombrefall.Size = new System.Drawing.Size(99, 381);
            this.lbxNombrefall.TabIndex = 14;
            this.lbxNombrefall.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // lbxNombreContr
            // 
            this.lbxNombreContr.FormattingEnabled = true;
            this.lbxNombreContr.Location = new System.Drawing.Point(353, 81);
            this.lbxNombreContr.Name = "lbxNombreContr";
            this.lbxNombreContr.Size = new System.Drawing.Size(110, 381);
            this.lbxNombreContr.TabIndex = 18;
            this.lbxNombreContr.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // lbxRutContra
            // 
            this.lbxRutContra.FormattingEnabled = true;
            this.lbxRutContra.Location = new System.Drawing.Point(248, 81);
            this.lbxRutContra.Name = "lbxRutContra";
            this.lbxRutContra.Size = new System.Drawing.Size(99, 381);
            this.lbxRutContra.TabIndex = 17;
            this.lbxRutContra.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // lbxVendedor
            // 
            this.lbxVendedor.FormattingEnabled = true;
            this.lbxVendedor.Location = new System.Drawing.Point(581, 81);
            this.lbxVendedor.Name = "lbxVendedor";
            this.lbxVendedor.Size = new System.Drawing.Size(99, 381);
            this.lbxVendedor.TabIndex = 25;
            this.lbxVendedor.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // lbxFechaContr
            // 
            this.lbxFechaContr.FormattingEnabled = true;
            this.lbxFechaContr.Location = new System.Drawing.Point(469, 81);
            this.lbxFechaContr.Name = "lbxFechaContr";
            this.lbxFechaContr.Size = new System.Drawing.Size(106, 381);
            this.lbxFechaContr.TabIndex = 21;
            this.lbxFechaContr.Click += new System.EventHandler(this.seleccionarLbx);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Fecha Contratacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(578, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Vendedor";
            // 
            // btnSalirSeleccionarContrato
            // 
            this.btnSalirSeleccionarContrato.Location = new System.Drawing.Point(717, 438);
            this.btnSalirSeleccionarContrato.Name = "btnSalirSeleccionarContrato";
            this.btnSalirSeleccionarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnSalirSeleccionarContrato.TabIndex = 32;
            this.btnSalirSeleccionarContrato.Text = "Salir";
            this.btnSalirSeleccionarContrato.UseVisualStyleBackColor = true;
            this.btnSalirSeleccionarContrato.Click += new System.EventHandler(this.btnSalirSeleccionarContrato_Click);
            // 
            // btnModificarSeleccionarContrato
            // 
            this.btnModificarSeleccionarContrato.Location = new System.Drawing.Point(717, 81);
            this.btnModificarSeleccionarContrato.Name = "btnModificarSeleccionarContrato";
            this.btnModificarSeleccionarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnModificarSeleccionarContrato.TabIndex = 33;
            this.btnModificarSeleccionarContrato.Text = "Modificar";
            this.btnModificarSeleccionarContrato.UseVisualStyleBackColor = true;
            this.btnModificarSeleccionarContrato.Click += new System.EventHandler(this.btnModificarSeleccionarContrato_Click);
            // 
            // btnEliminarSeleccionarContrato
            // 
            this.btnEliminarSeleccionarContrato.Location = new System.Drawing.Point(717, 131);
            this.btnEliminarSeleccionarContrato.Name = "btnEliminarSeleccionarContrato";
            this.btnEliminarSeleccionarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarSeleccionarContrato.TabIndex = 34;
            this.btnEliminarSeleccionarContrato.Text = "Eliminar";
            this.btnEliminarSeleccionarContrato.UseVisualStyleBackColor = true;
            this.btnEliminarSeleccionarContrato.Click += new System.EventHandler(this.btnEliminarSeleccionarContrato_Click);
            // 
            // SeleccionarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.btnEliminarSeleccionarContrato);
            this.Controls.Add(this.btnModificarSeleccionarContrato);
            this.Controls.Add(this.btnSalirSeleccionarContrato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxVendedor);
            this.Controls.Add(this.lbxFechaContr);
            this.Controls.Add(this.lbxNombreContr);
            this.Controls.Add(this.lbxRutContra);
            this.Controls.Add(this.lbxNombrefall);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRutFall);
            this.MaximizeBox = false;
            this.Name = "SeleccionarContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Contrato";
            this.Load += new System.EventHandler(this.SeleccionarContrato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRutFall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbxNombrefall;
        private System.Windows.Forms.ListBox lbxNombreContr;
        private System.Windows.Forms.ListBox lbxRutContra;
        private System.Windows.Forms.ListBox lbxVendedor;
        private System.Windows.Forms.ListBox lbxFechaContr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalirSeleccionarContrato;
        private System.Windows.Forms.Button btnModificarSeleccionarContrato;
        private System.Windows.Forms.Button btnEliminarSeleccionarContrato;



    }
}