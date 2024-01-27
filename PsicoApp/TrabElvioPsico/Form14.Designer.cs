namespace TrabElvioPsico
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            label6 = new Label();
            richTextBox2 = new RichTextBox();
            save = new Button();
            volt = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Arial Black", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(583, 46);
            label1.TabIndex = 1;
            label1.Text = "FICHA DO PACIENTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(197, 26);
            label2.TabIndex = 2;
            label2.Text = "Nome do paciente:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(205, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(397, 29);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(185, 26);
            label3.TabIndex = 4;
            label3.Text = "Data da consulta:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(196, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 32);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(369, 127);
            label4.Name = "label4";
            label4.Size = new Size(65, 26);
            label4.TabIndex = 6;
            label4.Text = "Hora:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(434, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 32);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 184);
            label5.Name = "label5";
            label5.Size = new Size(149, 28);
            label5.TabIndex = 8;
            label5.Text = "RELATÓRIO:";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(12, 215);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(590, 132);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 363);
            label6.Name = "label6";
            label6.Size = new Size(327, 28);
            label6.TabIndex = 10;
            label6.Text = "CONCLUSÃO/DIAGNÓSTICO:";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(12, 404);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(590, 132);
            richTextBox2.TabIndex = 11;
            richTextBox2.Text = "";
            // 
            // save
            // 
            save.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            save.Location = new Point(327, 637);
            save.Name = "save";
            save.Size = new Size(256, 113);
            save.TabIndex = 12;
            save.Text = "Salvar em PDF";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // volt
            // 
            volt.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            volt.Image = Properties.Resources.setaesq;
            volt.ImageAlign = ContentAlignment.BottomCenter;
            volt.Location = new Point(19, 637);
            volt.Name = "volt";
            volt.Size = new Size(256, 113);
            volt.TabIndex = 13;
            volt.Text = "VOLTAR";
            volt.TextAlign = ContentAlignment.TopCenter;
            volt.UseVisualStyleBackColor = true;
            volt.Click += volt_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 861);
            Controls.Add(volt);
            Controls.Add(save);
            Controls.Add(richTextBox2);
            Controls.Add(label6);
            Controls.Add(richTextBox1);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form14";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label6;
        private RichTextBox richTextBox2;
        private Button save;
        private Button volt;
    }
}