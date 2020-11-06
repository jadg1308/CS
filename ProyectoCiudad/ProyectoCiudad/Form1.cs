using ProyectoCiudad.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCiudad
{
    public partial class Form1 : Form
    {
        Ciudad ciudad = new Ciudad();

        public Form1()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            ciudad.Id = int.Parse(tbId.Text);
            ciudad.Nombre = tbNombre.Text;
            ciudad.FechaFund = dtpFechaFund.Value;
            ciudad.Poblacion = int.Parse(tbPoblacion.Text);

            String msn = "" + ciudad.Id + "\n " + ciudad.Nombre + "\n" + ciudad.FechaFund +
                "\n" + ciudad.Poblacion + "\n";

            MessageBox.Show(msn);

        }

        private void bVerEdad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La ciudad de " + ciudad.Nombre + " tiene " + ciudad.mostrarEdad() + " Años");
        }

        private void bMayuscula_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ciudad.mostrarNombreEnMayuscula());
        }
    }
}
