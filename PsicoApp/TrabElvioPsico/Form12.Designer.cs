namespace TrabElvioPsico
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.adulto;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(157, 174);
            button1.Name = "button1";
            button1.Size = new Size(179, 76);
            button1.TabIndex = 0;
            button1.Text = "ADULTOS";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.criança;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(519, 174);
            button2.Name = "button2";
            button2.Size = new Size(179, 76);
            button2.TabIndex = 1;
            button2.Text = "CRIANÇAS";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = Properties.Resources.livro;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(331, 328);
            button3.Name = "button3";
            button3.Size = new Size(179, 76);
            button3.TabIndex = 2;
            button3.Text = "PSICÓLOGO";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 27);
            label1.Name = "label1";
            label1.Size = new Size(453, 54);
            label1.TabIndex = 4;
            label1.Text = "ESCOLHA SEU MODO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
    }
}