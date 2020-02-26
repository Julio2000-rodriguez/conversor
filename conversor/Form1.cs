using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor
{
    public partial class Form1 : Form
    {
        Conversiones objconversiones = new Conversiones();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboEscoger.Items.AddRange(objconversiones.Tipo);

            cboEscoger.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
             lblR.Text = "Valor: " + objconversiones.convertir(cboD.SelectedIndex, cboW.SelectedIndex, double.Parse(txtCifra.Text), cboEscoger.SelectedIndex) + " " + objconversiones.etiquetas[cboEscoger.SelectedIndex][cboW.SelectedIndex];
            }
            catch 
            {
             MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            errorProvider1.SetError(txtCifra, "");
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboD.Items.Clear();

            cboW.Items.Clear();

            cboD.Items.AddRange(objconversiones.etiquetas[cboEscoger.SelectedIndex]);

            cboW.Items.AddRange(objconversiones.etiquetas[cboEscoger.SelectedIndex]);

            cboD.SelectedIndex = 0;

            cboW.SelectedIndex = 1;

            lblR.Text = "?";

            txtCifra.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
    
