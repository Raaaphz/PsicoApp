using System.Media;

namespace TrabElvioPsico
{
    public partial class Form1 : Form
    {
        private SoundPlayer sound;
        public Form1()
        {        
            InitializeComponent();
            sound = new SoundPlayer("C:\\PsicoApp\\BancoAudio\\musica.wav");
            sound.PlayLooping();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();

            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sound.Stop();
            Application.Exit();          
        }

        private void titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form47 form47 = new Form47();
            form47.Show();
            this.Hide();
        }
    }
}