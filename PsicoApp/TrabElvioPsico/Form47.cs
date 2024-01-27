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
    public partial class Form47 : Form
    {
        public Form47()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Form48 form48 = new Form48();
            form48.Show();
            this.Close();
        }
    }
}
