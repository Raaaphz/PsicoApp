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
    public partial class Form46 : Form
    {
        public Form46()
        {
            InitializeComponent();
        }

        private void Form46_Load(object sender, EventArgs e)
        {
            acertoNum.Text = VariaveisGlobais.Acertos.ToString();
            erroNum.Text = VariaveisGlobais.Erros.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            form13.Show();
            this.Close();
        }
    }
}
