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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\ramoscri3.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 27000, Timeout.Infinite);
        }

        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form17.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 form19 = new Form19();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form19.Show();
            this.Close();
        }
    }
}
