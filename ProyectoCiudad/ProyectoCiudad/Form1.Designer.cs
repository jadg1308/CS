namespace ProyectoCiudad
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaFund = new System.Windows.Forms.DateTimePicker();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.bVerEdad = new System.Windows.Forms.Button();
            this.bMayuscula = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Fundaciòn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Población:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(167, 49);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(167, 87);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // dtpFechaFund
            // 
            this.dtpFechaFund.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFund.Location = new System.Drawing.Point(167, 126);
            this.dtpFechaFund.Name = "dtpFechaFund";
            this.dtpFechaFund.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaFund.TabIndex = 6;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(167, 164);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 20);
            this.tbPoblacion.TabIndex = 7;
            // 
            // bVerEdad
            // 
            this.bVerEdad.Location = new System.Drawing.Point(146, 212);
            this.bVerEdad.Name = "bVerEdad";
            this.bVerEdad.Size = new System.Drawing.Size(101, 54);
            this.bVerEdad.TabIndex = 8;
            this.bVerEdad.Text = "Ver Edad";
            this.bVerEdad.UseVisualStyleBackColor = true;
            this.bVerEdad.Click += new System.EventHandler(this.bVerEdad_Click);
            // 
            // bMayuscula
            // 
            this.bMayuscula.Location = new System.Drawing.Point(253, 212);
            this.bMayuscula.Name = "bMayuscula";
            this.bMayuscula.Size = new System.Drawing.Size(96, 54);
            this.bMayuscula.TabIndex = 9;
            this.bMayuscula.Text = "Mostrar nombre en Mayuscula";
            this.bMayuscula.UseVisualStyleBackColor = true;
            this.bMayuscula.Click += new System.EventHandler(this.bMayuscula_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(42, 212);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(98, 54);
            this.bAgregar.TabIndex = 10;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 325);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bMayuscula);
            this.Controls.Add(this.bVerEdad);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.dtpFechaFund);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaFund;
        private System.Windows.Forms.TextBox tbPoblacion;
        private System.Windows.Forms.Button bVerEdad;
        private System.Windows.Forms.Button bMayuscula;
        private System.Windows.Forms.Button bAgregar;
    }
}

