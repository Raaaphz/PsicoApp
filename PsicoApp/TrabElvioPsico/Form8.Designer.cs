namespace TrabElvioPsico
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            slideshow = new PictureBox();
            rodar = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)slideshow).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 13F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 96);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(600, 73);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 13F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 175);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(600, 118);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Baskerville Old Face", 13F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(12, 303);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(806, 96);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.setaesq;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(231, 405);
            button2.Name = "button2";
            button2.Size = new Size(181, 69);
            button2.TabIndex = 11;
            button2.Text = "VOLTAR";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.setadir;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(418, 403);
            button1.Name = "button1";
            button1.Size = new Size(181, 69);
            button1.TabIndex = 12;
            button1.Text = "PRÓXIMO";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.speaker1;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(12, 48);
            button3.Name = "button3";
            button3.Size = new Size(88, 42);
            button3.TabIndex = 13;
            button3.Text = "LER";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 54);
            label1.TabIndex = 18;
            label1.Text = "SAÚDE MENTAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // slideshow
            // 
            slideshow.BorderStyle = BorderStyle.FixedSingle;
            slideshow.Location = new Point(607, 93);
            slideshow.Name = "slideshow";
            slideshow.Size = new Size(200, 200);
            slideshow.TabIndex = 19;
            slideshow.TabStop = false;
            // 
            // rodar
            // 
            rodar.ColorDepth = ColorDepth.Depth16Bit;
            rodar.ImageStream = (ImageListStreamer)resources.GetObject("rodar.ImageStream");
            rodar.TransparentColor = Color.Transparent;
            rodar.Images.SetKeyName(0, "WHO_logo.svg.png");
            rodar.Images.SetKeyName(1, "CVV_-_logo_azul.jpg");
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(slideshow);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ((System.ComponentModel.ISupportInitialize)slideshow).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label1;
        private PictureBox slideshow;
        private ImageList rodar;
    }
}