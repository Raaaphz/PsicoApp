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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Ramos2.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form5.Show();
            this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 57000, Timeout.Infinite);

        }
        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }
    }
}
