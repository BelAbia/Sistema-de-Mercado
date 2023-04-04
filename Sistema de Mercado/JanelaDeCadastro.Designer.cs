namespace Sistema_de_Mercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaDeCadastro));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbl_NomeProduto
            // 
            resources.ApplyResources(this.lbl_NomeProduto, "lbl_NomeProduto");
            this.lbl_NomeProduto.Name = "lbl_NomeProduto";
            // 
            // lbl_Marca
            // 
            resources.ApplyResources(this.lbl_Marca, "lbl_Marca");
            this.lbl_Marca.Name = "lbl_Marca";
            // 
            // lbl_Vencimento
            // 
            resources.ApplyResources(this.lbl_Vencimento, "lbl_Vencimento");
            this.lbl_Vencimento.Name = "lbl_Vencimento";
            // 
            // lbl_CodBarras
            // 
            resources.ApplyResources(this.lbl_CodBarras, "lbl_CodBarras");
            this.lbl_CodBarras.Name = "lbl_CodBarras";
            // 
            // tb_CodBarras
            // 
            this.tb_CodBarras.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tb_CodBarras, "tb_CodBarras");
            this.tb_CodBarras.Name = "tb_CodBarras";
            this.tb_CodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AoDigitarCodigoDeBarras);
            // 
            // tb_Marca
            // 
            this.tb_Marca.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tb_Marca, "tb_Marca");
            this.tb_Marca.Name = "tb_Marca";
            // 
            // tb_NomeProduto
            // 
            this.tb_NomeProduto.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.tb_NomeProduto, "tb_NomeProduto");
            this.tb_NomeProduto.Name = "tb_NomeProduto";
            // 
            // bt_Salvar
            // 
            resources.ApplyResources(this.bt_Salvar, "bt_Salvar");
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.AoClicarBotaoSalvar);
            // 
            // bt_Cancelar
            // 
            resources.ApplyResources(this.bt_Cancelar, "bt_Cancelar");
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.AoClicarBotaoCancelar);
            // 
            // dt_Vencimento
            // 
            this.dt_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dt_Vencimento, "dt_Vencimento");
            this.dt_Vencimento.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dt_Vencimento.MinDate = new System.DateTime(2023, 1, 16, 0, 0, 0, 0);
            this.dt_Vencimento.Name = "dt_Vencimento";
            this.dt_Vencimento.Value = new System.DateTime(2023, 1, 16, 13, 5, 33, 0);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // JanelaDeCadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.Load += new System.EventHandler(this.AoCarregarJanelaDeCadastro);
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