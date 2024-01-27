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
    public partial class Form20 : Form
    {
        private int currentIndex = -1;
        private System.Windows.Forms.Timer passar;
        public Form20()
        {
            InitializeComponent();

            passar = new System.Windows.Forms.Timer();
            passar.Interval = 5000;
            passar.Tick += new EventHandler(tempoimagem);
            passar.Start();

            tempoimagem(this, EventArgs.Empty);
        }

        private void tempoimagem(object sender, EventArgs e)
        {
            if (rodar.Images.Count > 0)
            {
                if (currentIndex < rodar.Images.Count - 1)
                {
                    currentIndex++;
                }
                else
                {
                    currentIndex = 0;
                }
                slideshow.Image = rodar.Images[currentIndex];
            }

        }
        private void Form20_FormClosing(object sender, FormClosingEventArgs e)
        {
            passar.Stop();
        }
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\saudecri.wav");
        private System.Threading.Timer timer;
        private void button1_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 69000, Timeout.Infinite);
        }

        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form13 form13 = new Form13();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form13.Show();
            this.Close();
        }
    }
}
