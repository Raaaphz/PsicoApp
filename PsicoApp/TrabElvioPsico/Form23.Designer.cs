namespace TrabElvioPsico
{
    partial class Form23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Baskerville Old Face", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(569, 54);
            label1.TabIndex = 0;
            label1.Text = "CENTRAL DO PSICOLOGO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(313, 76);
            button1.Name = "button1";
            button1.Size = new Size(226, 129);
            button1.TabIndex = 1;
            button1.Text = "CADASTRAR NOVO PACIENTE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(313, 211);
            button2.Name = "button2";
            button2.Size = new Size(226, 130);
            button2.TabIndex = 2;
            button2.Text = "RELATORIO DA CONSULTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial Black", 16.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(313, 347);
            button3.Name = "button3";
            button3.Size = new Size(226, 130);
            button3.TabIndex = 3;
            button3.Text = "VOLTAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 484);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form23";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CENTRALPSICO";
            Load += Form23_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}