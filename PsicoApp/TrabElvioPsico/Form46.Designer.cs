namespace TrabElvioPsico
{
    partial class Form46
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form46));
            button1 = new Button();
            erroNum = new Label();
            acertoNum = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.check;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(303, 336);
            button1.Name = "button1";
            button1.Size = new Size(244, 107);
            button1.TabIndex = 13;
            button1.Text = "TERMINAR";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // erroNum
            // 
            erroNum.AutoSize = true;
            erroNum.Font = new Font("Baskerville Old Face", 22F, FontStyle.Regular, GraphicsUnit.Point);
            erroNum.ForeColor = Color.Red;
            erroNum.Location = new Point(125, 271);
            erroNum.Name = "erroNum";
            erroNum.Size = new Size(41, 34);
            erroNum.TabIndex = 12;
            erroNum.Text = "xx";
            // 
            // acertoNum
            // 
            acertoNum.AutoSize = true;
            acertoNum.Font = new Font("Baskerville Old Face", 22F, FontStyle.Regular, GraphicsUnit.Point);
            acertoNum.ForeColor = Color.MediumSeaGreen;
            acertoNum.Location = new Point(172, 185);
            acertoNum.Name = "acertoNum";
            acertoNum.Size = new Size(41, 34);
            acertoNum.TabIndex = 10;
            acertoNum.Text = "xx";
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(293, 9);
            label1.Name = "label1";
            label1.Size = new Size(263, 54);
            label1.TabIndex = 14;
            label1.Text = "PARABÉNS!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(413, 34);
            label2.TabIndex = 15;
            label2.Text = "VOCÊ TERMINOU O QUIZ!!!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(4, 275);
            label5.Name = "label5";
            label5.Size = new Size(127, 34);
            label5.TabIndex = 17;
            label5.Text = "ERROS: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(4, 189);
            label3.Name = "label3";
            label3.Size = new Size(162, 34);
            label3.TabIndex = 16;
            label3.Text = "ACERTOS:";
            // 
            // Form46
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(erroNum);
            Controls.Add(acertoNum);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form46";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            Load += Form46_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label erroNum;
        private Label acertoNum;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
    }
}