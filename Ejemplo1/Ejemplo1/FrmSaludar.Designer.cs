namespace Ejemplo1
{
    partial class FrmSaludar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bSaludar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.bCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce tu nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(136, 35);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // bSaludar
            // 
            this.bSaludar.Location = new System.Drawing.Point(317, 33);
            this.bSaludar.Name = "bSaludar";
            this.bSaludar.Size = new System.Drawing.Size(75, 23);
            this.bSaludar.TabIndex = 2;
            this.bSaludar.Text = "Saludar";
            this.bSaludar.UseVisualStyleBackColor = true;
            this.bSaludar.Click += new System.EventHandler(this.bSaludar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecciona la fecha de Nacimiento:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(206, 80);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(105, 20);
            this.dtpFechaNac.TabIndex = 4;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(317, 80);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(75, 23);
            this.bCalcular.TabIndex = 5;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número 2:";
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(104, 148);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(100, 20);
            this.tbNum1.TabIndex = 8;
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(104, 179);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(100, 20);
            this.tbNum2.TabIndex = 9;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(104, 212);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 20);
            this.tbResultado.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Resultado:";
            // 
            // bSumar
            // 
            this.bSumar.Location = new System.Drawing.Point(233, 146);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(34, 22);
            this.bSumar.TabIndex = 12;
            this.bSumar.Text = "+";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.bSumar_Click);
            // 
            // FrmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 287);
            this.Controls.Add(this.bSumar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbNum2);
            this.Controls.Add(this.tbNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSaludar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmSaludar";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button bSaludar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bSumar;
    }
}

