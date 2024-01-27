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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrabElvioPsico
{
    public partial class Form7 : Form
    {
        private int currentIndex = -1;
        private System.Windows.Forms.Timer passar;
        public Form7()
        {
            InitializeComponent();

            passar = new System.Windows.Forms.Timer();
            passar.Interval = 5000;
            passar.Tick += new EventHandler(tempoimagem);
            passar.Start();

            tempoimagem(this, EventArgs.Empty);
        }
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\Epi.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private System.Threading.Timer timer;
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

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            passar.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form2.Show(); this.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 88000, Timeout.Infinite);
        }

        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }
    }
}
