namespace TrabElvioPsico
{
    partial class Form15
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            rodar = new ImageList(components);
            slideshow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)slideshow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 0);
            label1.Name = "label1";
            label1.Size = new Size(716, 41);
            label1.TabIndex = 0;
            label1.Text = "CONHECIMENTO DA PSICOLOGIA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 105);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(514, 88);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 199);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(514, 116);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(12, 321);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(816, 58);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.speaker1;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 48);
            button1.Name = "button1";
            button1.Size = new Size(88, 42);
            button1.TabIndex = 4;
            button1.Text = "LER";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.check;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(307, 382);
            button2.Name = "button2";
            button2.Size = new Size(219, 76);
            button2.TabIndex = 5;
            button2.Text = "CONCLUIR";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rodar
            // 
            rodar.ColorDepth = ColorDepth.Depth32Bit;
            rodar.ImageStream = (ImageListStreamer)resources.GetObject("rodar.ImageStream");
            rodar.TransparentColor = Color.Transparent;
            rodar.Images.SetKeyName(0, "WilhelmWundt-cropped-9aacabf9ba714732846d5ecdc26db066.jpg");
            rodar.Images.SetKeyName(1, "wundt-psicologia-ciencia.JPG");
            rodar.Images.SetKeyName(2, "socrates-min-e1493126161779.jpg");
            rodar.Images.SetKeyName(3, "culturaeepigenetica02.jpg");
            // 
            // slideshow
            // 
            slideshow.BorderStyle = BorderStyle.FixedSingle;
            slideshow.Location = new Point(532, 57);
            slideshow.Name = "slideshow";
            slideshow.Size = new Size(258, 258);
            slideshow.TabIndex = 6;
            slideshow.TabStop = false;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(slideshow);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form15";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ((System.ComponentModel.ISupportInitialize)slideshow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button1;
        private Button button2;
        private ImageList rodar;
        private PictureBox slideshow;
    }
}