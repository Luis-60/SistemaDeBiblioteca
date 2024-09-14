namespace AulaAEDB01.Windows
{
    partial class FrmAula01
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
            btnMensagem = new Button();
            lblMensagem = new Label();
            btnMudarCorFundoForm = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btnMensagem
            // 
            btnMensagem.BackColor = Color.Bisque;
            btnMensagem.Location = new Point(12, 107);
            btnMensagem.Name = "btnMensagem";
            btnMensagem.Size = new Size(776, 70);
            btnMensagem.TabIndex = 0;
            btnMensagem.Text = "Minha primeira mensagem";
            btnMensagem.UseVisualStyleBackColor = false;
            btnMensagem.Click += BtnMensagem_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.BackColor = SystemColors.InactiveBorder;
            lblMensagem.FlatStyle = FlatStyle.Flat;
            lblMensagem.Location = new Point(12, 26);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(776, 66);
            lblMensagem.TabIndex = 1;
            // 
            // btnMudarCorFundoForm
            // 
            btnMudarCorFundoForm.BackColor = Color.Bisque;
            btnMudarCorFundoForm.Location = new Point(12, 190);
            btnMudarCorFundoForm.Name = "btnMudarCorFundoForm";
            btnMudarCorFundoForm.Size = new Size(776, 70);
            btnMudarCorFundoForm.TabIndex = 2;
            btnMudarCorFundoForm.Text = "Mudar cor de fundo";
            btnMudarCorFundoForm.UseVisualStyleBackColor = false;
            btnMudarCorFundoForm.Click += btnMudarCorFundoForm_Click;
            // 
            // FrmAula01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMudarCorFundoForm);
            Controls.Add(lblMensagem);
            Controls.Add(btnMensagem);
            Name = "FrmAula01";
            Text = "Meu primeiro formulário";
            Activated += FrmAula01_Activated;
            FormClosed += FrmAula01_FormClosed;
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensagem;
        private Label lblMensagem;
        private Button btnMudarCorFundoForm;
        private ColorDialog colorDialog1;
    }
}
