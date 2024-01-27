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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\ramoscri1.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private System.Threading.Timer timer;
        private void button3_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form13.Show();
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            som.Play();
            timer = new System.Threading.Timer(voltarmusica, null, 26000, Timeout.Infinite);
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
    }
}
