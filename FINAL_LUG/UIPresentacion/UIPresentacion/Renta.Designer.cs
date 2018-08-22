namespace UIPresentacion
{
    partial class Renta
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lbVehiculos = new System.Windows.Forms.ListBox();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnAlquilar = new System.Windows.Forms.Button();
            this.btnCalcularImporte = new System.Windows.Forms.Button();
            this.grillaRentas = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(81, 43);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(121, 21);
            this.cbClientes.TabIndex = 1;
            // 
            // lbVehiculos
            // 
            this.lbVehiculos.FormattingEnabled = true;
            this.lbVehiculos.Location = new System.Drawing.Point(81, 97);
            this.lbVehiculos.Name = "lbVehiculos";
            this.lbVehiculos.Size = new System.Drawing.Size(254, 108);
            this.lbVehiculos.TabIndex = 2;
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Location = new System.Drawing.Point(12, 97);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(53, 13);
            this.lblVehiculos.TabIndex = 3;
            this.lblVehiculos.Text = "Vehiculos";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(81, 231);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 4;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(81, 269);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 5;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(12, 234);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 6;
            this.lblDias.Text = "Dias";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(12, 272);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 7;
            this.lblImporte.Text = "Importe";
            // 
            // btnAlquilar
            // 
            this.btnAlquilar.Location = new System.Drawing.Point(81, 314);
            this.btnAlquilar.Name = "btnAlquilar";
            this.btnAlquilar.Size = new System.Drawing.Size(75, 23);
            this.btnAlquilar.TabIndex = 8;
            this.btnAlquilar.Text = "Alquilar";
            this.btnAlquilar.UseVisualStyleBackColor = true;
            this.btnAlquilar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalcularImporte
            // 
            this.btnCalcularImporte.Location = new System.Drawing.Point(215, 314);
            this.btnCalcularImporte.Name = "btnCalcularImporte";
            this.btnCalcularImporte.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularImporte.TabIndex = 9;
            this.btnCalcularImporte.Text = "Calcular IMP";
            this.btnCalcularImporte.UseVisualStyleBackColor = true;
            this.btnCalcularImporte.Click += new System.EventHandler(this.button2_Click);
            // 
            // grillaRentas
            // 
            this.grillaRentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRentas.Location = new System.Drawing.Point(15, 353);
            this.grillaRentas.Name = "grillaRentas";
            this.grillaRentas.Size = new System.Drawing.Size(320, 151);
            this.grillaRentas.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(703, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Español";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(703, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ingles";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.grillaRentas);
            this.Controls.Add(this.btnCalcularImporte);
            this.Controls.Add(this.btnAlquilar);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lblVehiculos);
            this.Controls.Add(this.lbVehiculos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.lblCliente);
            this.Name = "Renta";
            this.Text = "Renta";
            this.Load += new System.EventHandler(this.Renta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.ListBox lbVehiculos;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button btnAlquilar;
        private System.Windows.Forms.Button btnCalcularImporte;
        private System.Windows.Forms.DataGridView grillaRentas;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}