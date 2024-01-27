﻿using System;
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
    public partial class Form30 : Form
    {
        public Form30()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btocerto.Checked)
            {
                VariaveisGlobais.Acertos++;
                Form31 form31 = new Form31();
                form31.Show();
                this.Close();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                Form31 form31 = new Form31();
                form31.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
