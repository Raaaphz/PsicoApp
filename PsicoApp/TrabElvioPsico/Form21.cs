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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Ajuda1.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form13.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form22.Show();
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 54000, Timeout.Infinite);
        }

        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }


    }
}
