using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class FrmSaludar : Form
    {
        private int num1, num2, resultado;
        public FrmSaludar()
        {
            InitializeComponent();
        }

        private void bSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + tbNombre.Text + ", mucho gusto...");
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            //tipo de variable nombre ;
            int añoNac, añoAct = DateTime.Now.Year, edad;
            añoNac = dtpFechaNac.Value.Year;
            edad = añoAct - añoNac;
            MessageBox.Show("Usted tiene: " + edad + " años.");
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            num1 = int.Parse( tbNum1.Text);
            num2 = int.Parse(tbNum2.Text);
            resultado = num1 + num2;
            tbResultado.Text = ""+resultado;
        }
    }
}
