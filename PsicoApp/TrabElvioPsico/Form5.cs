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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Ramos3.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form4.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form6.Show();
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
    }
}
