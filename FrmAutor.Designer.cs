namespace AulaAEDB01.Windows
{
    partial class FrmAutor
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
            BtnSalvarA = new Button();
            BtnFecharA = new Button();
            GrdItensA = new DataGridView();
            CodigoA = new DataGridViewTextBoxColumn();
            NomeA = new DataGridViewTextBoxColumn();
            BtnAlterarA = new DataGridViewButtonColumn();
            BtnExcluirA = new DataGridViewButtonColumn();
            TxtCodigoA = new TextBox();
            TxtNomeA = new TextBox();
            LblCodigoA = new Label();
            LblNomeA = new Label();
            ((System.ComponentModel.ISupportInitialize)GrdItensA).BeginInit();
            SuspendLayout();
            // 
            // BtnSalvarA
            // 
            BtnSalvarA.Location = new Point(35, 105);
            BtnSalvarA.Name = "BtnSalvarA";
            BtnSalvarA.Size = new Size(156, 34);
            BtnSalvarA.TabIndex = 0;
            BtnSalvarA.Text = "&Salvar";
            BtnSalvarA.UseVisualStyleBackColor = true;
            BtnSalvarA.Click += btnSalvarA_Click;
            // 
            // BtnFecharA
            // 
            BtnFecharA.Location = new Point(226, 105);
            BtnFecharA.Name = "BtnFecharA";
            BtnFecharA.Size = new Size(156, 34);
            BtnFecharA.TabIndex = 1;
            BtnFecharA.Text = "&Fechar";
            BtnFecharA.UseVisualStyleBackColor = true;
            BtnFecharA.Click += BtnFecharA_Click;
            // 
            // GrdItensA
            // 
            GrdItensA.AllowUserToAddRows = false;
            GrdItensA.AllowUserToDeleteRows = false;
            GrdItensA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdItensA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdItensA.Columns.AddRange(new DataGridViewColumn[] { CodigoA, NomeA, BtnAlterarA, BtnExcluirA });
            GrdItensA.Location = new Point(2, 156);
            GrdItensA.Name = "GrdItensA";
            GrdItensA.RowHeadersWidth = 51;
            GrdItensA.Size = new Size(794, 266);
            GrdItensA.TabIndex = 2;
            GrdItensA.CellContentClick += GrdItensA_CellClick;
            // 
            // CodigoA
            // 
            CodigoA.DataPropertyName = "CodigoA";
            CodigoA.HeaderText = "Codigo";
            CodigoA.MinimumWidth = 6;
            CodigoA.Name = "CodigoA";
            CodigoA.Width = 125;
            // 
            // NomeA
            // 
            NomeA.DataPropertyName = "NomeA";
            NomeA.HeaderText = "Nome";
            NomeA.MinimumWidth = 6;
            NomeA.Name = "NomeA";
            NomeA.Width = 125;
            // 
            // BtnAlterarA
            // 
            BtnAlterarA.DataPropertyName = "BtnAlterarA";
            BtnAlterarA.HeaderText = "Alterar";
            BtnAlterarA.MinimumWidth = 6;
            BtnAlterarA.Name = "BtnAlterarA";
            BtnAlterarA.Width = 125;
            // 
            // BtnExcluirA
            // 
            BtnExcluirA.DataPropertyName = "BtnExcluirA";
            BtnExcluirA.HeaderText = "Excluir";
            BtnExcluirA.MinimumWidth = 6;
            BtnExcluirA.Name = "BtnExcluirA";
            BtnExcluirA.Width = 125;
            // 
            // TxtCodigoA
            // 
            TxtCodigoA.Enabled = false;
            TxtCodigoA.Location = new Point(35, 54);
            TxtCodigoA.MaxLength = 4;
            TxtCodigoA.Name = "TxtCodigoA";
            TxtCodigoA.Size = new Size(125, 27);
            TxtCodigoA.TabIndex = 3;
            // 
            // TxtNomeA
            // 
            TxtNomeA.Location = new Point(176, 54);
            TxtNomeA.MaxLength = 100;
            TxtNomeA.Name = "TxtNomeA";
            TxtNomeA.Size = new Size(566, 27);
            TxtNomeA.TabIndex = 4;
            // 
            // LblCodigoA
            // 
            LblCodigoA.AutoSize = true;
            LblCodigoA.Location = new Point(35, 18);
            LblCodigoA.Name = "LblCodigoA";
            LblCodigoA.Size = new Size(58, 20);
            LblCodigoA.TabIndex = 5;
            LblCodigoA.Text = "Código";
            // 
            // LblNomeA
            // 
            LblNomeA.AutoSize = true;
            LblNomeA.Location = new Point(176, 18);
            LblNomeA.Name = "LblNomeA";
            LblNomeA.Size = new Size(50, 20);
            LblNomeA.TabIndex = 6;
            LblNomeA.Text = "Nome";
            // 
            // FrmAutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(LblNomeA);
            Controls.Add(LblCodigoA);
            Controls.Add(TxtNomeA);
            Controls.Add(TxtCodigoA);
            Controls.Add(GrdItensA);
            Controls.Add(BtnFecharA);
            Controls.Add(BtnSalvarA);
            Name = "FrmAutor";
            Text = "Cadastrar Autor";
            Activated += FrmAutor_Activated_1;
            FormClosed += FrmAutor_FormClosed_1;
            Load += FrmAutor_Load;
            ((System.ComponentModel.ISupportInitialize)GrdItensA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSalvarA;
        private Button BtnFecharA;
        private DataGridView GrdItensA;
        private TextBox TxtCodigoA;
        private TextBox TxtNomeA;
        private Label LblCodigoA;
        private Label LblNomeA;
        private DataGridViewTextBoxColumn CodigoA;
        private DataGridViewTextBoxColumn NomeA;
        private DataGridViewButtonColumn BtnAlterarA;
        private DataGridViewButtonColumn BtnExcluirA;
    }
}