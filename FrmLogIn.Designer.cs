using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace AulaAEDB01.Windows
{
    partial class FrmLogIn
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtUser = new TextBox();
            TxtSenha = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 33);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Biblioteca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 23);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 236);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // TxtUser
            // 
            TxtUser.Location = new Point(43, 141);
            TxtUser.Margin = new Padding(3, 4, 3, 4);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(222, 27);
            TxtUser.TabIndex = 3;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(43, 263);
            TxtSenha.Margin = new Padding(3, 4, 3, 4);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(222, 27);
            TxtSenha.TabIndex = 4;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(96, 345);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 43);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log-In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 425);
            Controls.Add(btnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
            FormClosed += FrmLogIn_FormClosed;
            Load += FrmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtUser;
        private TextBox TxtSenha;
        private Button btnLogin;
    }
}