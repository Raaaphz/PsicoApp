﻿namespace TrabElvioPsico
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(12, 133);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(816, 79);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(228, 236, 250);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 251);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(816, 93);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.setaesq;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(231, 403);
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
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(507, 54);
            label1.TabIndex = 14;
            label1.Text = "RAMOS DA PSICOLOGIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(336, 31);
            label2.TabIndex = 15;
            label2.Text = "PSICOLOGIA FORENSE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 217);
            label3.Name = "label3";
            label3.Size = new Size(353, 31);
            label3.TabIndex = 16;
            label3.Text = "PSICOLOGIA DA SAUDE:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}