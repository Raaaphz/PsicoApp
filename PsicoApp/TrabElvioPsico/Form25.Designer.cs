namespace TrabElvioPsico
{
    partial class Form25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form25));
            label1 = new Label();
            radioButton1 = new RadioButton();
            richTextBox1 = new RichTextBox();
            radioButton2 = new RadioButton();
            btocerto = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 54);
            label1.TabIndex = 0;
            label1.Text = "QUIZ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(217, 190);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(171, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sigmund Freud.";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 84);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(816, 61);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "1) Quem é frequentemente considerado o pai da psicologia moderna e estabeleceu o primeiro laboratório de psicologia em Leipzig, Alemanha?";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(482, 190);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(176, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "John B. Watson.";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // btocerto
            // 
            btocerto.AutoSize = true;
            btocerto.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btocerto.Location = new Point(482, 267);
            btocerto.Name = "btocerto";
            btocerto.Size = new Size(182, 29);
            btocerto.TabIndex = 4;
            btocerto.TabStop = true;
            btocerto.Text = "Wilhelm Wundt.";
            btocerto.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton4.Location = new Point(217, 267);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(134, 29);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Ivan Pavlov.";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.setadir;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(325, 353);
            button1.Name = "button1";
            button1.Size = new Size(214, 100);
            button1.TabIndex = 0;
            button1.Text = "PRÓXIMO";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form25
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(btocerto);
            Controls.Add(radioButton2);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form25";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RichTextBox richTextBox1;
        private RadioButton radioButton2;
        private RadioButton btocerto;
        private RadioButton radioButton4;
        private Button button1;
    }
}