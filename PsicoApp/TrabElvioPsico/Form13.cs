using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabElvioPsico
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form48 form48 = new Form48();
            form48.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            form15.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            form16.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form20 form20 = new Form20();
            form20.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.Acertos = 0;
            VariaveisGlobais.Erros = 0;

            Form36 form36 = new Form36(); form36.Show(); this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
