﻿namespace Sistema_de_Mercado
{
    partial class JanelaDeCadastro
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_NomeProduto = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Vencimento = new System.Windows.Forms.Label();
            this.lbl_CodBarras = new System.Windows.Forms.Label();
            this.tb_CodBarras = new System.Windows.Forms.TextBox();
            this.tb_Marca = new System.Windows.Forms.TextBox();
            this.tb_NomeProduto = new System.Windows.Forms.TextBox();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.dt_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lbl_NomeProduto
            // 
            this.lbl_NomeProduto.AutoSize = true;
            this.lbl_NomeProduto.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NomeProduto.Location = new System.Drawing.Point(23, 37);
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            this.lbl_NomeProduto.Size = new System.Drawing.Size(150, 22);
            this.lbl_NomeProduto.TabIndex = 7;
            this.lbl_NomeProduto.Text = "Nome do produto";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Marca.Location = new System.Drawing.Point(28, 110);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(56, 22);
            this.lbl_Marca.TabIndex = 8;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Vencimento
            // 
            this.lbl_Vencimento.AutoSize = true;
            this.lbl_Vencimento.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Vencimento.Location = new System.Drawing.Point(28, 175);
            this.lbl_Vencimento.Name = "lbl_Vencimento";
            this.lbl_Vencimento.Size = new System.Drawing.Size(167, 22);
            this.lbl_Vencimento.TabIndex = 9;
            this.lbl_Vencimento.Text = "Data de vencimento";
            // 
            // lbl_CodBarras
            // 
            this.lbl_CodBarras.AutoSize = true;
            this.lbl_CodBarras.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CodBarras.Location = new System.Drawing.Point(28, 246);
            this.lbl_CodBarras.Name = "lbl_CodBarras";
            this.lbl_CodBarras.Size = new System.Drawing.Size(145, 22);
            this.lbl_CodBarras.TabIndex = 10;
            this.lbl_CodBarras.Text = "Codigo de Barras";
            // 
            // tb_CodBarras
            // 
            this.tb_CodBarras.BackColor = System.Drawing.SystemColors.Control;
            this.tb_CodBarras.Location = new System.Drawing.Point(239, 244);
            this.tb_CodBarras.MaxLength = 13;
            this.tb_CodBarras.Name = "tb_CodBarras";
            this.tb_CodBarras.Size = new System.Drawing.Size(284, 27);
            this.tb_CodBarras.TabIndex = 4;
            this.tb_CodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CodBarras_KeyPress);
            // 
            // tb_Marca
            // 
            this.tb_Marca.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Marca.Location = new System.Drawing.Point(239, 105);
            this.tb_Marca.Name = "tb_Marca";
            this.tb_Marca.Size = new System.Drawing.Size(284, 27);
            this.tb_Marca.TabIndex = 2;
            // 
            // tb_NomeProduto
            // 
            this.tb_NomeProduto.BackColor = System.Drawing.SystemColors.Control;
            this.tb_NomeProduto.Location = new System.Drawing.Point(239, 36);
            this.tb_NomeProduto.Name = "tb_NomeProduto";
            this.tb_NomeProduto.Size = new System.Drawing.Size(284, 27);
            this.tb_NomeProduto.TabIndex = 1;
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Salvar.Location = new System.Drawing.Point(28, 321);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(114, 36);
            this.bt_Salvar.TabIndex = 5;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.AoClicarBotaoSalvar);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_Cancelar.Location = new System.Drawing.Point(181, 321);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(125, 36);
            this.bt_Cancelar.TabIndex = 6;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.AoClicarBotaoCancelar);
            // 
            // dt_Vencimento
            // 
            this.dt_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Vencimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Vencimento.Location = new System.Drawing.Point(239, 170);
            this.dt_Vencimento.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dt_Vencimento.MinDate = new System.DateTime(2023, 1, 16, 0, 0, 0, 0);
            this.dt_Vencimento.Name = "dt_Vencimento";
            this.dt_Vencimento.Size = new System.Drawing.Size(125, 27);
            this.dt_Vencimento.TabIndex = 3;
            this.dt_Vencimento.Value = new System.DateTime(2023, 1, 16, 13, 5, 33, 0);
            //this.dt_Vencimento.ValueChanged += new System.EventHandler(this.dt_Vencimento_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 20;
            // 
            // JanelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(588, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt_Vencimento);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.tb_NomeProduto);
            this.Controls.Add(this.tb_Marca);
            this.Controls.Add(this.tb_CodBarras);
            this.Controls.Add(this.lbl_CodBarras);
            this.Controls.Add(this.lbl_Vencimento);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_NomeProduto);
            this.Controls.Add(this.label1);
            this.Name = "JanelaDeCadastro";
            this.Text = "Novo Produto";
            this.Load += new System.EventHandler(this.Janela2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_NomeProduto;
        private Label lbl_Marca;
        //private Label lbl_DataCadastro;
        private Label lbl_Vencimento;
        private Label lbl_CodBarras;
        private Button bt_Salvar;
        private Button bt_Cancelar;
      //  private Label lbl_ID;
     //   private TextBox tb_ID;
     //   private DateTimePicker dt_Cadastro;
        private Label label2;
        public TextBox tb_CodBarras;
        public TextBox tb_Marca;
        public TextBox tb_NomeProduto;
        public DateTimePicker dt_Vencimento;
    }
}