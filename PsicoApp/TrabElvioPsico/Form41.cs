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
    public partial class Form41 : Form
    {
        public Form41()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btocerto.Checked)
            {
                VariaveisGlobais.Acertos++;
                Form42 form42 = new Form42();
                form42.Show();
                this.Close();
            }
            else if (radioButton1.Checked || radioButton2.Checked || radioButton4.Checked)
            {
                VariaveisGlobais.Erros++;
                Form42 form42 = new Form42();
                form42.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
