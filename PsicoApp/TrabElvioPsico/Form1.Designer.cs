namespace TrabElvioPsico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            iniciar = new Button();
            sair = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // iniciar
            // 
            iniciar.BackColor = Color.White;
            iniciar.Cursor = Cursors.Hand;
            iniciar.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            iniciar.Location = new Point(315, 125);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(220, 86);
            iniciar.TabIndex = 0;
            iniciar.Text = "INICIAR";
            iniciar.UseVisualStyleBackColor = false;
            iniciar.Click += iniciar_Click;
            // 
            // sair
            // 
            sair.Cursor = Cursors.Hand;
            sair.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            sair.Location = new Point(315, 375);
            sair.Name = "sair";
            sair.Size = new Size(220, 86);
            sair.TabIndex = 1;
            sair.Text = "FECHAR";
            sair.UseVisualStyleBackColor = true;
            sair.Click += sair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logousc;
            pictureBox1.Location = new Point(553, 350);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 111);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logopsico_resized;
            pictureBox3.Location = new Point(66, 350);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 170);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Baskerville Old Face", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 9);
            label2.Name = "label2";
            label2.Size = new Size(536, 71);
            label2.TabIndex = 7;
            label2.Text = "CENTRAL DE PSICOLOGIA";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(315, 250);
            button1.Name = "button1";
            button1.Size = new Size(220, 86);
            button1.TabIndex = 8;
            button1.Text = "CRÉDITOS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 236, 250);
            ClientSize = new Size(840, 484);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(sair);
            Controls.Add(iniciar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button iniciar;
        private Button sair;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label2;
        private Button button1;
    }
}