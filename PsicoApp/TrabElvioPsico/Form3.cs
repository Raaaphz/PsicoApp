using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabElvioPsico
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Ramos1.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form4.Show();
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 45000, Timeout.Infinite);
        }
        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
