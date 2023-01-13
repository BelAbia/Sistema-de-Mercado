namespace Sistema_de_Mercado
{
    partial class Janela1
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
            this.bt_Deletar = new System.Windows.Forms.Button();
            this.bt_Atualizar = new System.Windows.Forms.Button();
            this.bt_Novo = new System.Windows.Forms.Button();
            this.bt_Cancelar1 = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.dgv_Produto = new System.Windows.Forms.DataGridView();
            this.dgv_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DataVencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Deletar
            // 
            this.bt_Deletar.Location = new System.Drawing.Point(665, 478);
            this.bt_Deletar.Name = "bt_Deletar";
            this.bt_Deletar.Size = new System.Drawing.Size(113, 38);
            this.bt_Deletar.TabIndex = 0;
            this.bt_Deletar.Text = "Deletar";
            this.bt_Deletar.UseVisualStyleBackColor = true;
            // 
            // bt_Atualizar
            // 
            this.bt_Atualizar.Location = new System.Drawing.Point(546, 478);
            this.bt_Atualizar.Name = "bt_Atualizar";
            this.bt_Atualizar.Size = new System.Drawing.Size(113, 38);
            this.bt_Atualizar.TabIndex = 2;
            this.bt_Atualizar.Text = "Atualizar";
            this.bt_Atualizar.UseVisualStyleBackColor = true;
            // 
            // bt_Novo
            // 
            this.bt_Novo.Location = new System.Drawing.Point(427, 478);
            this.bt_Novo.Name = "bt_Novo";
            this.bt_Novo.Size = new System.Drawing.Size(113, 38);
            this.bt_Novo.TabIndex = 3;
            this.bt_Novo.Text = "Novo";
            this.bt_Novo.UseVisualStyleBackColor = true;
            this.bt_Novo.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Cancelar1
            // 
            this.bt_Cancelar1.Location = new System.Drawing.Point(131, 478);
            this.bt_Cancelar1.Name = "bt_Cancelar1";
            this.bt_Cancelar1.Size = new System.Drawing.Size(113, 38);
            this.bt_Cancelar1.TabIndex = 4;
            this.bt_Cancelar1.Text = "Cancelar";
            this.bt_Cancelar1.UseVisualStyleBackColor = true;
            this.bt_Cancelar1.Click += new System.EventHandler(this.bt_Cancelar1_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(12, 478);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(113, 38);
            this.bt_OK.TabIndex = 5;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_ID,
            this.dgv_Nome,
            this.dgv_Marca,
            this.dgv_DataCadastro,
            this.dgv_DataVencimento,
            this.dgv_CodBarras});
            this.dgv_Produto.Location = new System.Drawing.Point(0, 2);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.RowHeadersWidth = 51;
            this.dgv_Produto.RowTemplate.Height = 29;
            this.dgv_Produto.Size = new System.Drawing.Size(803, 458);
            this.dgv_Produto.TabIndex = 6;
            this.dgv_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_ID
            // 
            this.dgv_ID.HeaderText = "ID";
            this.dgv_ID.MinimumWidth = 6;
            this.dgv_ID.Name = "dgv_ID";
            this.dgv_ID.Width = 125;
            // 
            // dgv_Nome
            // 
            this.dgv_Nome.HeaderText = "Nome";
            this.dgv_Nome.MinimumWidth = 6;
            this.dgv_Nome.Name = "dgv_Nome";
            this.dgv_Nome.Width = 125;
            // 
            // dgv_Marca
            // 
            this.dgv_Marca.HeaderText = "Marca";
            this.dgv_Marca.MinimumWidth = 6;
            this.dgv_Marca.Name = "dgv_Marca";
            this.dgv_Marca.Width = 125;
            // 
            // dgv_DataCadastro
            // 
            this.dgv_DataCadastro.HeaderText = "Data de Cadastro";
            this.dgv_DataCadastro.MinimumWidth = 6;
            this.dgv_DataCadastro.Name = "dgv_DataCadastro";
            this.dgv_DataCadastro.Width = 125;
            // 
            // dgv_DataVencimento
            // 
            this.dgv_DataVencimento.HeaderText = "Data de Vencimento";
            this.dgv_DataVencimento.MinimumWidth = 6;
            this.dgv_DataVencimento.Name = "dgv_DataVencimento";
            this.dgv_DataVencimento.Width = 125;
            // 
            // dgv_CodBarras
            // 
            this.dgv_CodBarras.HeaderText = "Código de Barras";
            this.dgv_CodBarras.MaxInputLength = 7;
            this.dgv_CodBarras.MinimumWidth = 6;
            this.dgv_CodBarras.Name = "dgv_CodBarras";
            this.dgv_CodBarras.Width = 125;
            // 
            // Janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 528);
            this.Controls.Add(this.dgv_Produto);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_Cancelar1);
            this.Controls.Add(this.bt_Novo);
            this.Controls.Add(this.bt_Atualizar);
            this.Controls.Add(this.bt_Deletar);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Janela1";
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_Deletar;
        private Button bt_Atualizar;
        private Button bt_Novo;
        private Button bt_Cancelar1;
        private Button bt_OK;
        private DataGridView dgv_Produto;
        private DataGridViewTextBoxColumn dgv_ID;
        private DataGridViewTextBoxColumn dgv_Nome;
        private DataGridViewTextBoxColumn dgv_Marca;
        private DataGridViewTextBoxColumn dgv_DataCadastro;
        private DataGridViewTextBoxColumn dgv_DataVencimento;
        private DataGridViewTextBoxColumn dgv_CodBarras;
    }
}