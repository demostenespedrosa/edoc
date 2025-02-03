namespace e_doc
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
            label1 = new Label();
            label2 = new Label();
            btnCriarDocumento = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(542, 223);
            label1.Name = "label1";
            label1.Size = new Size(223, 77);
            label1.TabIndex = 0;
            label1.Text = "E-DOC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(327, 300);
            label2.Name = "label2";
            label2.Size = new Size(654, 45);
            label2.TabIndex = 1;
            label2.Text = "Sistema de Unificação de Documentos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // btnCriarDocumento
            // 
            btnCriarDocumento.Anchor = AnchorStyles.None;
            btnCriarDocumento.Location = new Point(583, 426);
            btnCriarDocumento.Name = "btnCriarDocumento";
            btnCriarDocumento.Size = new Size(134, 21);
            btnCriarDocumento.TabIndex = 2;
            btnCriarDocumento.Text = "Criar Documento";
            btnCriarDocumento.TextAlign = ContentAlignment.BottomCenter;
            btnCriarDocumento.UseVisualStyleBackColor = true;
            btnCriarDocumento.Click += btnCriarDocumento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1283, 497);
            Controls.Add(btnCriarDocumento);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tela Inicial";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnCriarDocumento;
    }
}
