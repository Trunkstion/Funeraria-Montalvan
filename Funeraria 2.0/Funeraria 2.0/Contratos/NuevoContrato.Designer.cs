namespace Funeraria_2._0.Contratos
{
    partial class NuevoContrato
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
            this.serviciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funerariaBD = new Funeraria_2._0.FunerariaBD();
            this.serviciosTableAdapter = new Funeraria_2._0.FunerariaBDTableAdapters.ServiciosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxServicioNuevoContrato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreUrnaNuevoContrato = new System.Windows.Forms.TextBox();
            this.txtModeloUrnaNuevoContrato = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMarcarTodosNuevoContrato = new System.Windows.Forms.Button();
            this.btnDesmarcarTodosNuevoContrato = new System.Windows.Forms.Button();
            this.clbAgregados = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalNuevoContrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbRebajaNuevoContrato = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIvaNuevoContrato = new System.Windows.Forms.TextBox();
            this.txtNetoNuevoContrato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblErrorTotal = new System.Windows.Forms.Label();
            this.btnSalirNuevoContrato = new System.Windows.Forms.Button();
            this.btnAgregarNuevoContrato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funerariaBD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviciosBindingSource
            // 
            this.serviciosBindingSource.DataMember = "Servicios";
            this.serviciosBindingSource.DataSource = this.funerariaBD;
            // 
            // funerariaBD
            // 
            this.funerariaBD.DataSetName = "FunerariaBD";
            this.funerariaBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviciosTableAdapter
            // 
            this.serviciosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicio";
            // 
            // cbxServicioNuevoContrato
            // 
            this.cbxServicioNuevoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxServicioNuevoContrato.FormattingEnabled = true;
            this.cbxServicioNuevoContrato.Location = new System.Drawing.Point(320, 42);
            this.cbxServicioNuevoContrato.Name = "cbxServicioNuevoContrato";
            this.cbxServicioNuevoContrato.Size = new System.Drawing.Size(86, 21);
            this.cbxServicioNuevoContrato.TabIndex = 2;
            this.cbxServicioNuevoContrato.SelectedValueChanged += new System.EventHandler(this.cbxServicioNuevoContrato_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Urna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo de Urna";
            // 
            // txtNombreUrnaNuevoContrato
            // 
            this.txtNombreUrnaNuevoContrato.Location = new System.Drawing.Point(97, 120);
            this.txtNombreUrnaNuevoContrato.Name = "txtNombreUrnaNuevoContrato";
            this.txtNombreUrnaNuevoContrato.ReadOnly = true;
            this.txtNombreUrnaNuevoContrato.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUrnaNuevoContrato.TabIndex = 5;
            // 
            // txtModeloUrnaNuevoContrato
            // 
            this.txtModeloUrnaNuevoContrato.Location = new System.Drawing.Point(306, 123);
            this.txtModeloUrnaNuevoContrato.Name = "txtModeloUrnaNuevoContrato";
            this.txtModeloUrnaNuevoContrato.ReadOnly = true;
            this.txtModeloUrnaNuevoContrato.Size = new System.Drawing.Size(100, 20);
            this.txtModeloUrnaNuevoContrato.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMarcarTodosNuevoContrato);
            this.groupBox3.Controls.Add(this.btnDesmarcarTodosNuevoContrato);
            this.groupBox3.Controls.Add(this.clbAgregados);
            this.groupBox3.Location = new System.Drawing.Point(460, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 278);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregados";
            // 
            // btnMarcarTodosNuevoContrato
            // 
            this.btnMarcarTodosNuevoContrato.Location = new System.Drawing.Point(21, 241);
            this.btnMarcarTodosNuevoContrato.Name = "btnMarcarTodosNuevoContrato";
            this.btnMarcarTodosNuevoContrato.Size = new System.Drawing.Size(95, 23);
            this.btnMarcarTodosNuevoContrato.TabIndex = 3;
            this.btnMarcarTodosNuevoContrato.Text = "Marcar Todos";
            this.btnMarcarTodosNuevoContrato.UseVisualStyleBackColor = true;
            this.btnMarcarTodosNuevoContrato.Click += new System.EventHandler(this.btnMarcarTodosNuevoContrato_Click);
            // 
            // btnDesmarcarTodosNuevoContrato
            // 
            this.btnDesmarcarTodosNuevoContrato.Location = new System.Drawing.Point(173, 241);
            this.btnDesmarcarTodosNuevoContrato.Name = "btnDesmarcarTodosNuevoContrato";
            this.btnDesmarcarTodosNuevoContrato.Size = new System.Drawing.Size(100, 23);
            this.btnDesmarcarTodosNuevoContrato.TabIndex = 2;
            this.btnDesmarcarTodosNuevoContrato.Text = "Desmarcar Todos";
            this.btnDesmarcarTodosNuevoContrato.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodosNuevoContrato.Click += new System.EventHandler(this.btnDesmarcarTodosNuevoContrato_Click);
            // 
            // clbAgregados
            // 
            this.clbAgregados.BackColor = System.Drawing.SystemColors.Info;
            this.clbAgregados.CheckOnClick = true;
            this.clbAgregados.FormattingEnabled = true;
            this.clbAgregados.Items.AddRange(new object[] {
            "Arreglo floral",
            "Libro de condolencia",
            "Trámite legal interno (registro civil)",
            "Mini bus de acompañamiento",
            "Auto de acompañamiento",
            "Capilla electrónica o capilla ardiente",
            "Capilla con vela",
            "Tarjetero",
            "Cafetería",
            "Carroza Panorámica",
            "Tarjeta de agradecimiento ",
            "Coro polifónico",
            "Aviso de defunción en Prensa"});
            this.clbAgregados.Location = new System.Drawing.Point(21, 21);
            this.clbAgregados.Name = "clbAgregados";
            this.clbAgregados.Size = new System.Drawing.Size(253, 199);
            this.clbAgregados.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtModeloUrnaNuevoContrato);
            this.groupBox1.Controls.Add(this.txtNombreUrnaNuevoContrato);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxServicioNuevoContrato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio principal";
            // 
            // txtTotalNuevoContrato
            // 
            this.txtTotalNuevoContrato.Location = new System.Drawing.Point(101, 46);
            this.txtTotalNuevoContrato.Name = "txtTotalNuevoContrato";
            this.txtTotalNuevoContrato.ReadOnly = true;
            this.txtTotalNuevoContrato.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNuevoContrato.TabIndex = 0;
            this.txtTotalNuevoContrato.TextChanged += new System.EventHandler(this.txtTotalNuevoContrato_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor del servicio";
            // 
            // ckbRebajaNuevoContrato
            // 
            this.ckbRebajaNuevoContrato.AutoSize = true;
            this.ckbRebajaNuevoContrato.Location = new System.Drawing.Point(207, 48);
            this.ckbRebajaNuevoContrato.Name = "ckbRebajaNuevoContrato";
            this.ckbRebajaNuevoContrato.Size = new System.Drawing.Size(77, 17);
            this.ckbRebajaNuevoContrato.TabIndex = 2;
            this.ckbRebajaNuevoContrato.Text = "Con rebaja";
            this.ckbRebajaNuevoContrato.UseVisualStyleBackColor = true;
            this.ckbRebajaNuevoContrato.CheckedChanged += new System.EventHandler(this.ckbRebajaNuevoContrato_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Valor neto";
            // 
            // txtIvaNuevoContrato
            // 
            this.txtIvaNuevoContrato.Location = new System.Drawing.Point(101, 108);
            this.txtIvaNuevoContrato.Name = "txtIvaNuevoContrato";
            this.txtIvaNuevoContrato.ReadOnly = true;
            this.txtIvaNuevoContrato.Size = new System.Drawing.Size(100, 20);
            this.txtIvaNuevoContrato.TabIndex = 5;
            // 
            // txtNetoNuevoContrato
            // 
            this.txtNetoNuevoContrato.Location = new System.Drawing.Point(101, 167);
            this.txtNetoNuevoContrato.Name = "txtNetoNuevoContrato";
            this.txtNetoNuevoContrato.ReadOnly = true;
            this.txtNetoNuevoContrato.Size = new System.Drawing.Size(100, 20);
            this.txtNetoNuevoContrato.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(101, 233);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            this.txtTotal.Leave += new System.EventHandler(this.txtTotal_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblErrorTotal);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNetoNuevoContrato);
            this.groupBox2.Controls.Add(this.txtIvaNuevoContrato);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ckbRebajaNuevoContrato);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotalNuevoContrato);
            this.groupBox2.Location = new System.Drawing.Point(13, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores";
            // 
            // lblErrorTotal
            // 
            this.lblErrorTotal.AutoSize = true;
            this.lblErrorTotal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTotal.Location = new System.Drawing.Point(98, 217);
            this.lblErrorTotal.Name = "lblErrorTotal";
            this.lblErrorTotal.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTotal.TabIndex = 9;
            // 
            // btnSalirNuevoContrato
            // 
            this.btnSalirNuevoContrato.Location = new System.Drawing.Point(493, 645);
            this.btnSalirNuevoContrato.Name = "btnSalirNuevoContrato";
            this.btnSalirNuevoContrato.Size = new System.Drawing.Size(75, 23);
            this.btnSalirNuevoContrato.TabIndex = 2;
            this.btnSalirNuevoContrato.Text = "Cancelar";
            this.btnSalirNuevoContrato.UseVisualStyleBackColor = true;
            this.btnSalirNuevoContrato.Click += new System.EventHandler(this.btnSalirNuevoContrato_Click);
            // 
            // btnAgregarNuevoContrato
            // 
            this.btnAgregarNuevoContrato.Location = new System.Drawing.Point(397, 645);
            this.btnAgregarNuevoContrato.Name = "btnAgregarNuevoContrato";
            this.btnAgregarNuevoContrato.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNuevoContrato.TabIndex = 3;
            this.btnAgregarNuevoContrato.Text = "Agregar";
            this.btnAgregarNuevoContrato.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoContrato.Click += new System.EventHandler(this.btnAgregarNuevoContrato_Click);
            // 
            // NuevoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.btnAgregarNuevoContrato);
            this.Controls.Add(this.btnSalirNuevoContrato);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "NuevoContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Contrato";
            this.Load += new System.EventHandler(this.NuevoContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.serviciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funerariaBD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FunerariaBD funerariaBD;
        private System.Windows.Forms.BindingSource serviciosBindingSource;
        private FunerariaBDTableAdapters.ServiciosTableAdapter serviciosTableAdapter;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cbxServicioNuevoContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreUrnaNuevoContrato;
        private System.Windows.Forms.TextBox txtModeloUrnaNuevoContrato;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMarcarTodosNuevoContrato;
        private System.Windows.Forms.Button btnDesmarcarTodosNuevoContrato;
        private System.Windows.Forms.CheckedListBox clbAgregados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalNuevoContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbRebajaNuevoContrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIvaNuevoContrato;
        private System.Windows.Forms.TextBox txtNetoNuevoContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalirNuevoContrato;
        private System.Windows.Forms.Button btnAgregarNuevoContrato;
        private System.Windows.Forms.Label lblErrorTotal;
    }
}