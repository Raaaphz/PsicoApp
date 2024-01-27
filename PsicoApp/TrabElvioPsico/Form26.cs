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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btocerto.Checked)
            {
                VariaveisGlobais.Acertos++;
                Form27 form27 = new Form27();
                form27.Show();
                this.Close();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                Form27 form27 = new Form27();
                form27.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
