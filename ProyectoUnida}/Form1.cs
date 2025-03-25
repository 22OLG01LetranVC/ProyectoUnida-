using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProyectoUnida_
{
    public partial class Converiones : Form
    {
        public Converiones()
        {
            InitializeComponent();
        }

        private void Medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (double.TryParse(Datos.Text, out double valor))
            {
                double[] factores = { 1000, 0.001, 2, 0.5, 0.5, 2, 0.0283168, 35.3147, 764.555, 0.00130795 };
                double resultado = valor * factores[Medidas.SelectedIndex];
                MessageBox.Show($"Resultado: {resultado}", "Conversión Exitosa", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido", "Error", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
