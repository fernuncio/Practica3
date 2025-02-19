using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 data = new Form1();
            data.ShowDialog();
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fechas fechas = new Fechas();
            fechas.ShowDialog();
        }
    }
}
