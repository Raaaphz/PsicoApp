namespace TrabElvioPsico
{
    partial class Form20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form20));
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            slideshow = new PictureBox();
            rodar = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)slideshow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(348, 54);
            label1.TabIndex = 0;
            label1.Text = "SAÚDE MENTAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 89);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(488, 89);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.Location = new Point(12, 175);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(488, 94);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox4.Location = new Point(12, 263);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(816, 70);
            richTextBox4.TabIndex = 4;
            richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox5.Location = new Point(12, 327);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(816, 94);
            richTextBox5.TabIndex = 5;
            richTextBox5.Text = resources.GetString("richTextBox5.Text");
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.speaker1;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 48);
            button1.Name = "button1";
            button1.Size = new Size(88, 42);
            button1.TabIndex = 6;
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
            button2.Location = new Point(316, 406);
            button2.Name = "button2";
            button2.Size = new Size(219, 76);
            button2.TabIndex = 7;
            button2.Text = "CONCLUIR";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // slideshow
            // 
            slideshow.BorderStyle = BorderStyle.FixedSingle;
            slideshow.Location = new Point(552, 57);
            slideshow.Name = "slideshow";
            slideshow.Size = new Size(200, 200);
            slideshow.TabIndex = 8;
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
            // Form20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(slideshow);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form20";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ((System.ComponentModel.ISupportInitialize)slideshow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Button button1;
        private Button button2;
        private PictureBox slideshow;
        private ImageList rodar;
    }
}