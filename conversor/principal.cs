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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conversoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1   fmconversor = new Form1 ();
            fmconversor.Show();
            fmconversor.MdiParent = this;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            lblStatusFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 fmconversor = new Form1();
            fmconversor.Show();
            fmconversor.MdiParent = this;

            lblFormularioActivo.Text = fmconversor.Text;
        }
    }
}
