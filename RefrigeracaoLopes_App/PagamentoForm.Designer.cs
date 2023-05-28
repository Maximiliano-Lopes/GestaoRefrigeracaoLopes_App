namespace RefrigeracaoLopes_App
{
    partial class PagamentoForm
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
            this.btn_confirmarInfo = new System.Windows.Forms.Button();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_place = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownPreco = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listMeioPagamento = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listEstadoPagamento = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickAreaEntrada = new System.Windows.Forms.DateTimePicker();
            this.inputNomeProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_confirmarAlteracoesPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_confirmarInfo
            // 
            this.btn_confirmarInfo.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_confirmarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_confirmarInfo.Location = new System.Drawing.Point(437, 580);
            this.btn_confirmarInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirmarInfo.Name = "btn_confirmarInfo";
            this.btn_confirmarInfo.Size = new System.Drawing.Size(136, 47);
            this.btn_confirmarInfo.TabIndex = 56;
            this.btn_confirmarInfo.Text = "Confirmar";
            this.btn_confirmarInfo.UseVisualStyleBackColor = false;
            this.btn_confirmarInfo.Click += new System.EventHandler(this.btn_confirmarInfo_Click);
            // 
            // inputNome
            // 
            this.inputNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNome.Location = new System.Drawing.Point(151, 48);
            this.inputNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNome.Name = "inputNome";
            this.inputNome.ReadOnly = true;
            this.inputNome.Size = new System.Drawing.Size(621, 38);
            this.inputNome.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputCPF
            // 
            this.inputCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputCPF.Location = new System.Drawing.Point(151, 100);
            this.inputCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.ReadOnly = true;
            this.inputCPF.Size = new System.Drawing.Size(621, 38);
            this.inputCPF.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(33, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 60;
            this.label7.Text = "CPF:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 61;
            this.label4.Text = "Serviço ID:";
            // 
            // id_place
            // 
            this.id_place.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.id_place.AutoSize = true;
            this.id_place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.id_place.Location = new System.Drawing.Point(171, 9);
            this.id_place.Name = "id_place";
            this.id_place.Size = new System.Drawing.Size(115, 31);
            this.id_place.TabIndex = 62;
            this.id_place.Text = "id_place";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.Location = new System.Drawing.Point(13, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(286, 31);
            this.label13.TabIndex = 63;
            this.label13.Text = "Estado do pagamento:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownPreco
            // 
            this.numericUpDownPreco.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numericUpDownPreco.DecimalPlaces = 2;
            this.numericUpDownPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.numericUpDownPreco.Location = new System.Drawing.Point(138, 514);
            this.numericUpDownPreco.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPreco.Name = "numericUpDownPreco";
            this.numericUpDownPreco.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownPreco.Size = new System.Drawing.Size(105, 35);
            this.numericUpDownPreco.TabIndex = 66;
            this.numericUpDownPreco.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(14, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 65;
            this.label5.Text = "TOTAL:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputDescricaoProduto
            // 
            this.inputDescricaoProduto.Font = new System.Drawing.Font("Roboto", 12F);
            this.inputDescricaoProduto.Location = new System.Drawing.Point(390, 272);
            this.inputDescricaoProduto.MaximumSize = new System.Drawing.Size(382, 257);
            this.inputDescricaoProduto.MinimumSize = new System.Drawing.Size(382, 257);
            this.inputDescricaoProduto.Multiline = true;
            this.inputDescricaoProduto.Name = "inputDescricaoProduto";
            this.inputDescricaoProduto.Size = new System.Drawing.Size(382, 257);
            this.inputDescricaoProduto.TabIndex = 67;
            this.inputDescricaoProduto.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(384, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "Descrição:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listMeioPagamento
            // 
            this.listMeioPagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listMeioPagamento.FormattingEnabled = true;
            this.listMeioPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão_de_débito",
            "Boleto_bancário",
            "Carteira_digital",
            "Contactless",
            "PIX",
            "Cartão_de_crédit"});
            this.listMeioPagamento.Location = new System.Drawing.Point(18, 274);
            this.listMeioPagamento.Name = "listMeioPagamento";
            this.listMeioPagamento.Size = new System.Drawing.Size(224, 95);
            this.listMeioPagamento.TabIndex = 70;
            this.listMeioPagamento.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listMeioPagamento_DrawItem);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "Meio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listEstadoPagamento
            // 
            this.listEstadoPagamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listEstadoPagamento.FormattingEnabled = true;
            this.listEstadoPagamento.Items.AddRange(new object[] {
            "Concluido",
            "Pendente"});
            this.listEstadoPagamento.Location = new System.Drawing.Point(19, 194);
            this.listEstadoPagamento.Name = "listEstadoPagamento";
            this.listEstadoPagamento.Size = new System.Drawing.Size(224, 30);
            this.listEstadoPagamento.TabIndex = 71;
            this.listEstadoPagamento.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listEstadoPagamento_DrawItem);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(13, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 31);
            this.label8.TabIndex = 73;
            this.label8.Text = "Data do pagamento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // datePickAreaEntrada
            // 
            this.datePickAreaEntrada.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datePickAreaEntrada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.datePickAreaEntrada.Checked = false;
            this.datePickAreaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickAreaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickAreaEntrada.Location = new System.Drawing.Point(19, 427);
            this.datePickAreaEntrada.Name = "datePickAreaEntrada";
            this.datePickAreaEntrada.Size = new System.Drawing.Size(220, 35);
            this.datePickAreaEntrada.TabIndex = 72;
            this.datePickAreaEntrada.Value = new System.DateTime(2023, 5, 12, 0, 0, 0, 0);
            // 
            // inputNomeProduto
            // 
            this.inputNomeProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNomeProduto.Location = new System.Drawing.Point(390, 183);
            this.inputNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputNomeProduto.Name = "inputNomeProduto";
            this.inputNomeProduto.ReadOnly = true;
            this.inputNomeProduto.Size = new System.Drawing.Size(382, 38);
            this.inputNomeProduto.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(384, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 31);
            this.label6.TabIndex = 75;
            this.label6.Text = "Produto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_confirmarAlteracoesPag
            // 
            this.btn_confirmarAlteracoesPag.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirmarAlteracoesPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_confirmarAlteracoesPag.Location = new System.Drawing.Point(120, 580);
            this.btn_confirmarAlteracoesPag.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirmarAlteracoesPag.Name = "btn_confirmarAlteracoesPag";
            this.btn_confirmarAlteracoesPag.Size = new System.Drawing.Size(262, 47);
            this.btn_confirmarAlteracoesPag.TabIndex = 76;
            this.btn_confirmarAlteracoesPag.Text = "Confirmar Alterações";
            this.btn_confirmarAlteracoesPag.UseVisualStyleBackColor = false;
            this.btn_confirmarAlteracoesPag.Visible = false;
            this.btn_confirmarAlteracoesPag.Click += new System.EventHandler(this.button1_Click);
            // 
            // PagamentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.btn_confirmarAlteracoesPag);
            this.Controls.Add(this.inputNomeProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datePickAreaEntrada);
            this.Controls.Add(this.listEstadoPagamento);
            this.Controls.Add(this.listMeioPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDescricaoProduto);
            this.Controls.Add(this.numericUpDownPreco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_place);
            this.Controls.Add(this.inputCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_confirmarInfo);
            this.Name = "PagamentoForm";
            this.Text = "PagamentoForm";
            this.Load += new System.EventHandler(this.PagamentoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputDescricaoProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePickAreaEntrada;
        private System.Windows.Forms.TextBox inputNomeProduto;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox listEstadoPagamento;
        public System.Windows.Forms.Button btn_confirmarInfo;
        public System.Windows.Forms.Button btn_confirmarAlteracoesPag;
        public System.Windows.Forms.Label id_place;
        public System.Windows.Forms.ListBox listMeioPagamento;
    }
}