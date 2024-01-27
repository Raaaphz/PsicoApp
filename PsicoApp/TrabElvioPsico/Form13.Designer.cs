namespace TrabElvioPsico
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(543, 54);
            label1.TabIndex = 1;
            label1.Text = "LEITURA PARA CRIANÇAS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(311, 199);
            button1.Name = "button1";
            button1.Size = new Size(236, 115);
            button1.TabIndex = 3;
            button1.Text = "QUIZ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(354, 395);
            button2.Name = "button2";
            button2.Size = new Size(146, 64);
            button2.TabIndex = 4;
            button2.Text = "VOLTAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(592, 106);
            button3.Name = "button3";
            button3.Size = new Size(236, 115);
            button3.TabIndex = 5;
            button3.Text = "SAÚDE MENTAL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(41, 297);
            button4.Name = "button4";
            button4.Size = new Size(236, 115);
            button4.TabIndex = 6;
            button4.Text = "RAMOS DA PSICOLOGIA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(592, 297);
            button5.Name = "button5";
            button5.Size = new Size(236, 115);
            button5.TabIndex = 7;
            button5.Text = "COMO AJUDAR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(41, 106);
            button6.Name = "button6";
            button6.Size = new Size(236, 115);
            button6.TabIndex = 8;
            button6.Text = "CONHECIMENTO DA PSICOLOGIA\r\n";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}