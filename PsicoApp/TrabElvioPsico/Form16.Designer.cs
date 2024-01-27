namespace TrabElvioPsico
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(511, 54);
            label1.TabIndex = 0;
            label1.Text = "RAMOS DA PSICOLOGIA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(325, 31);
            label2.TabIndex = 1;
            label2.Text = "PSICOLOGIA CLÍNICA:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 146);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 52);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "São os psicólogos que ajudam as pessoas que estão se sentindo tristes, preocupadas ou com problemas na cabeça. Eles usam técnicas especiais para ajudar essas pessoas a se sentirem melhor.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 211);
            label3.Name = "label3";
            label3.Size = new Size(372, 31);
            label3.TabIndex = 3;
            label3.Text = "PSICOLOGIA COGNITIVA:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 245);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(776, 58);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "Esses psicólogos estudam como nossa mente funciona, como guardamos informações, como resolvemos problemas e até como falamos e entendemos as coisas.";
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.speaker1;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 48);
            button1.Name = "button1";
            button1.Size = new Size(88, 42);
            button1.TabIndex = 5;
            button1.Text = "LER";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.setadir;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(433, 359);
            button2.Name = "button2";
            button2.Size = new Size(181, 69);
            button2.TabIndex = 6;
            button2.Text = "PRÓXIMO";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.setaesq;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(246, 359);
            button3.Name = "button3";
            button3.Size = new Size(181, 69);
            button3.TabIndex = 7;
            button3.Text = "VOLTAR";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form16";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}