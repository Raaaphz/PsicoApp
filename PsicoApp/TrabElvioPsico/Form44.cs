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
    public partial class Form44 : Form
    {
        public Form44()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btocerto.Checked)
            {
                VariaveisGlobais.Acertos++;
                Form45 form45 = new Form45();
                form45.Show();
                this.Close();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                Form45 form45 = new Form45();
                form45.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
