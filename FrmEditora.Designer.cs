namespace AulaAEDB01.Windows
{
    partial class FrmEditora
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
            LblNomeE = new Label();
            LblCodigoE = new Label();
            TxtNomeE = new TextBox();
            TxtCodigoE = new TextBox();
            GrdItensE = new DataGridView();
            CodigoE = new DataGridViewTextBoxColumn();
            NomeE = new DataGridViewTextBoxColumn();
            BtnAlterarE = new DataGridViewButtonColumn();
            BtnExcluirE = new DataGridViewButtonColumn();
            BtnFecharE = new Button();
            BtnSalvarE = new Button();
            ((System.ComponentModel.ISupportInitialize)GrdItensE).BeginInit();
            SuspendLayout();
            // 
            // LblNomeE
            // 
            LblNomeE.AutoSize = true;
            LblNomeE.Location = new Point(177, 23);
            LblNomeE.Name = "LblNomeE";
            LblNomeE.Size = new Size(50, 20);
            LblNomeE.TabIndex = 13;
            LblNomeE.Text = "Nome";
            // 
            // LblCodigoE
            // 
            LblCodigoE.AutoSize = true;
            LblCodigoE.Location = new Point(36, 23);
            LblCodigoE.Name = "LblCodigoE";
            LblCodigoE.Size = new Size(58, 20);
            LblCodigoE.TabIndex = 12;
            LblCodigoE.Text = "Código";
            // 
            // TxtNomeE
            // 
            TxtNomeE.Location = new Point(177, 59);
            TxtNomeE.MaxLength = 100;
            TxtNomeE.Name = "TxtNomeE";
            TxtNomeE.Size = new Size(566, 27);
            TxtNomeE.TabIndex = 11;
            // 
            // TxtCodigoE
            // 
            TxtCodigoE.Enabled = false;
            TxtCodigoE.Location = new Point(36, 59);
            TxtCodigoE.MaxLength = 4;
            TxtCodigoE.Name = "TxtCodigoE";
            TxtCodigoE.Size = new Size(125, 27);
            TxtCodigoE.TabIndex = 10;
            // 
            // GrdItensE
            // 
            GrdItensE.AllowUserToAddRows = false;
            GrdItensE.AllowUserToDeleteRows = false;
            GrdItensE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensE.Columns.AddRange(new DataGridViewColumn[] { CodigoE, NomeE, BtnAlterarE, BtnExcluirE });
            GrdItensE.Location = new Point(3, 161);
            GrdItensE.Name = "GrdItensE";
            GrdItensE.RowHeadersWidth = 51;
            GrdItensE.Size = new Size(794, 266);
            GrdItensE.TabIndex = 9;
            GrdItensE.CellContentClick += GrdItens_CellClick;
            // 
            // CodigoE
            // 
            CodigoE.DataPropertyName = "CodigoE";
            CodigoE.HeaderText = "Codigo";
            CodigoE.MinimumWidth = 6;
            CodigoE.Name = "CodigoE";
            CodigoE.Width = 125;
            // 
            // NomeE
            // 
            NomeE.DataPropertyName = "NomeE";
            NomeE.HeaderText = "Nome";
            NomeE.MinimumWidth = 6;
            NomeE.Name = "NomeE";
            NomeE.Width = 125;
            // 
            // BtnAlterarE
            // 
            BtnAlterarE.DataPropertyName = "BtnAlterarE";
            BtnAlterarE.HeaderText = "Alterar";
            BtnAlterarE.MinimumWidth = 6;
            BtnAlterarE.Name = "BtnAlterarE";
            BtnAlterarE.Width = 125;
            // 
            // BtnExcluirE
            // 
            BtnExcluirE.DataPropertyName = "BtnExcluirE";
            BtnExcluirE.HeaderText = "Excluir";
            BtnExcluirE.MinimumWidth = 6;
            BtnExcluirE.Name = "BtnExcluirE";
            BtnExcluirE.Width = 125;
            // 
            // BtnFecharE
            // 
            BtnFecharE.Location = new Point(227, 110);
            BtnFecharE.Name = "BtnFecharE";
            BtnFecharE.Size = new Size(156, 34);
            BtnFecharE.TabIndex = 8;
            BtnFecharE.Text = "&Fechar";
            BtnFecharE.UseVisualStyleBackColor = true;
            BtnFecharE.Click += BtnFecharE_Click;
            // 
            // BtnSalvarE
            // 
            BtnSalvarE.Location = new Point(36, 110);
            BtnSalvarE.Name = "BtnSalvarE";
            BtnSalvarE.Size = new Size(156, 34);
            BtnSalvarE.TabIndex = 7;
            BtnSalvarE.Text = "&Salvar";
            BtnSalvarE.UseVisualStyleBackColor = true;
            BtnSalvarE.Click += BtnSalvarE_Click;
            // 
            // FrmEditora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblNomeE);
            Controls.Add(LblCodigoE);
            Controls.Add(TxtNomeE);
            Controls.Add(TxtCodigoE);
            Controls.Add(GrdItensE);
            Controls.Add(BtnFecharE);
            Controls.Add(BtnSalvarE);
            Name = "FrmEditora";
            Text = "FrmEditora";
            Activated += FrmEditora_Activated;
            FormClosed += FrmEditora_FormClosed;
            Load += FrmEditora_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeE;
        private Label LblCodigoE;
        private TextBox TxtNomeE;
        private TextBox TxtCodigoE;
        private DataGridView GrdItensE;
        private DataGridViewTextBoxColumn CodigoE;
        private DataGridViewTextBoxColumn NomeE;
        private DataGridViewButtonColumn BtnAlterarE;
        private DataGridViewButtonColumn BtnExcluirE;
        private Button BtnFecharE;
        private Button BtnSalvarE;
    }
}