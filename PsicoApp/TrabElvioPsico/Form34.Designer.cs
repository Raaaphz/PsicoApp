﻿namespace TrabElvioPsico
{
    partial class Form34
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form34));
            button1 = new Button();
            radioButton4 = new RadioButton();
            btocerto = new RadioButton();
            radioButton2 = new RadioButton();
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
            button1.Location = new Point(325, 345);
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
            radioButton4.Location = new Point(12, 148);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(447, 29);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Amenizar a situação, falando sobre outras coisas";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btocerto
            // 
            btocerto.AutoSize = true;
            btocerto.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btocerto.Location = new Point(12, 262);
            btocerto.Name = "btocerto";
            btocerto.Size = new Size(328, 29);
            btocerto.TabIndex = 4;
            btocerto.TabStop = true;
            btocerto.Text = "Ter um bate papo sério e objetivo";
            btocerto.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(12, 224);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(387, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Culpa-lo pelo estado em que se encontra";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 93);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(776, 69);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "10) Qual forma é a mais adequada para ajudar um colega com quadro de depressão?";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(12, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(316, 29);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Expressar seus sentimentos a ele";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(360, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 54);
            label1.TabIndex = 22;
            label1.Text = "QUIZ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form34
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(btocerto);
            Controls.Add(radioButton2);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form34";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton4;
        private RadioButton btocerto;
        private RadioButton radioButton2;
        private RichTextBox richTextBox1;
        private RadioButton radioButton1;
        private Label label1;
    }
}