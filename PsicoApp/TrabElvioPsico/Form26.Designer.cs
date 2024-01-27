namespace TrabElvioPsico
{
    partial class Form26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form26));
            button1 = new Button();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            btocerto = new RadioButton();
            richTextBox1 = new RichTextBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.setadir;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(325, 363);
            button1.Name = "button1";
            button1.Size = new Size(214, 100);
            button1.TabIndex = 0;
            button1.Text = "PRÓXIMO";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(12, 285);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(647, 29);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Uma teoria que descreve os cinco estágios do desenvolvimento infantil.";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(12, 247);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(444, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Uma teoria que descreve cinco estágios de luto.";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // btocerto
            // 
            btocerto.AutoSize = true;
            btocerto.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btocerto.Location = new Point(12, 171);
            btocerto.Name = "btocerto";
            btocerto.Size = new Size(700, 29);
            btocerto.TabIndex = 4;
            btocerto.TabStop = true;
            btocerto.Text = "Uma teoria que descreve cinco dimensões de personalidade e características.";
            btocerto.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 104);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(816, 38);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "2) O que é a teoria da pesonalidade dos \"Cinco Grandes Fatores\"?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(12, 209);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(557, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Uma teoria que descreve cinco tipos de transtornos mentais.";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 54);
            label1.TabIndex = 15;
            label1.Text = "QUIZ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form26
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(btocerto);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form26";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton btocerto;
        private RichTextBox richTextBox1;
        private RadioButton radioButton1;
        private Label label1;
    }
}