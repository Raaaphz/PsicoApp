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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Ajuda1.wav");
        private System.Threading.Timer timer;
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
            Form11 form11 = new Form11();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form11.Show();
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
        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
