using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TrabElvioPsico
{
    public partial class Form27 : Form
    {
        public Form27()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btocerto.Checked)
            {
                VariaveisGlobais.Acertos++;
                Form28 form28 = new Form28();
                form28.Show();
                this.Close();
            }
            else if (radioButton3.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                Form28 form28 = new Form28();
                form28.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
