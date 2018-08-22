namespace UIPresentacion
{
    partial class Reporte
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
            this.btnMasRentados = new System.Windows.Forms.Button();
            this.btnMenosRentados = new System.Windows.Forms.Button();
            this.grillaResultados = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grillaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMasRentados
            // 
            this.btnMasRentados.Location = new System.Drawing.Point(25, 46);
            this.btnMasRentados.Name = "btnMasRentados";
            this.btnMasRentados.Size = new System.Drawing.Size(111, 46);
            this.btnMasRentados.TabIndex = 0;
            this.btnMasRentados.Text = "Vehiculos mas rentados";
            this.btnMasRentados.UseVisualStyleBackColor = true;
            this.btnMasRentados.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenosRentados
            // 
            this.btnMenosRentados.Location = new System.Drawing.Point(25, 154);
            this.btnMenosRentados.Name = "btnMenosRentados";
            this.btnMenosRentados.Size = new System.Drawing.Size(111, 44);
            this.btnMenosRentados.TabIndex = 1;
            this.btnMenosRentados.Text = "Vehiculos menos rentados";
            this.btnMenosRentados.UseVisualStyleBackColor = true;
            this.btnMenosRentados.Click += new System.EventHandler(this.button2_Click);
            // 
            // grillaResultados
            // 
            this.grillaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaResultados.Location = new System.Drawing.Point(191, 26);
            this.grillaResultados.Name = "grillaResultados";
            this.grillaResultados.Size = new System.Drawing.Size(378, 207);
            this.grillaResultados.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(516, 249);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Español";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(516, 272);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ingles";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 290);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.grillaResultados);
            this.Controls.Add(this.btnMenosRentados);
            this.Controls.Add(this.btnMasRentados);
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMasRentados;
        private System.Windows.Forms.Button btnMenosRentados;
        private System.Windows.Forms.DataGridView grillaResultados;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}