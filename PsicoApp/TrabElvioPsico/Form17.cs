﻿using System;
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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        private System.Threading.Timer timer;
        SoundPlayer som = new SoundPlayer(@"C:\PsicoApp\BancoAudio\ramoscri2.wav");
        SoundPlayer musica = new SoundPlayer(@"C:\PsicoApp\BancoAudio\musica.wav");
        private void button1_Click(object sender, EventArgs e)
        {
            
            som.Play();

            timer = new System.Threading.Timer(voltarmusica, null, 28000, Timeout.Infinite);
        }
        private void voltarmusica(object state)
        {
            
            musica.PlayLooping();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 form16 = new Form16();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form16.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form18 form18 = new Form18();
            som.Stop();
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            musica.PlayLooping();
            form18.Show();
            this.Close();
        }
    }
}