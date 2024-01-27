namespace TrabElvioPsico
{
    partial class Form19
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form19));
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(300, 31);
            label2.TabIndex = 7;
            label2.Text = "NEUROPSICOLOGIA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(418, 31);
            label3.TabIndex = 8;
            label3.Text = "PSICOLOGIA OCUPACIONAL:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 144);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 61);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "Esses psicólogos entendem muito sobre como o cérebro funciona. Eles ajudam quando alguém tem um problema no cérebro e isso afeta como a pessoa pensa ou se lembra de coisas.";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 254);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(776, 64);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "Esses psicólogos pensam sobre como o trabalho que fazemos pode influenciar como nos sentimos. Eles ajudam as empresas a criar ambientes de trabalho bons para as pessoas.";
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.setaesq;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(246, 359);
            button2.Name = "button2";
            button2.Size = new Size(181, 69);
            button2.TabIndex = 11;
            button2.Text = "VOLTAR";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 13.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.check;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(433, 359);
            button3.Name = "button3";
            button3.Size = new Size(181, 69);
            button3.TabIndex = 12;
            button3.Text = "CONCLUIR";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(511, 54);
            label1.TabIndex = 13;
            label1.Text = "RAMOS DA PSICOLOGIA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form19";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}