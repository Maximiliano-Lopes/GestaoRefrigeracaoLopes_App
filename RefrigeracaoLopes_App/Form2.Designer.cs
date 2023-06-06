namespace RefrigeracaoLopes_App
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.id_Place = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputEnd = new System.Windows.Forms.TextBox();
            this.inputTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editarInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirmarAlt = new System.Windows.Forms.Button();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.btn_cancelarAlt = new System.Windows.Forms.Button();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.refrigeracaoDBDataSet = new RefrigeracaoLopes_App.refrigeracaoDBDataSet();
            this.serviçosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviçosTableAdapter = new RefrigeracaoLopes_App.refrigeracaoDBDataSetTableAdapters.ServiçosTableAdapter();
            this.listServicos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.inputCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickAreaNasc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeClienteDesde = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // id_Place
            // 
            this.id_Place.AutoSize = true;
            this.id_Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.id_Place.Location = new System.Drawing.Point(76, 9);
            this.id_Place.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_Place.Name = "id_Place";
            this.id_Place.Size = new System.Drawing.Size(115, 31);
            this.id_Place.TabIndex = 10;
            this.id_Place.Text = "id_place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(76, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputEnd
            // 
            this.inputEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputEnd.Location = new System.Drawing.Point(172, 187);
            this.inputEnd.Margin = new System.Windows.Forms.Padding(2);
            this.inputEnd.Name = "inputEnd";
            this.inputEnd.ReadOnly = true;
            this.inputEnd.Size = new System.Drawing.Size(270, 38);
            this.inputEnd.TabIndex = 11;
            // 
            // inputTelefone
            // 
            this.inputTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputTelefone.Location = new System.Drawing.Point(172, 145);
            this.inputTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.inputTelefone.Name = "inputTelefone";
            this.inputTelefone.ReadOnly = true;
            this.inputTelefone.Size = new System.Drawing.Size(270, 38);
            this.inputTelefone.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(70, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "End:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(64, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_editarInfo
            // 
            this.btn_editarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_editarInfo.Location = new System.Drawing.Point(41, 342);
            this.btn_editarInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_editarInfo.Name = "btn_editarInfo";
            this.btn_editarInfo.Size = new System.Drawing.Size(92, 44);
            this.btn_editarInfo.TabIndex = 13;
            this.btn_editarInfo.Text = "Editar";
            this.btn_editarInfo.UseVisualStyleBackColor = true;
            this.btn_editarInfo.Click += new System.EventHandler(this.btn_editarInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_confirmarAlt
            // 
            this.btn_confirmarAlt.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_confirmarAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_confirmarAlt.Location = new System.Drawing.Point(196, 342);
            this.btn_confirmarAlt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirmarAlt.Name = "btn_confirmarAlt";
            this.btn_confirmarAlt.Size = new System.Drawing.Size(133, 44);
            this.btn_confirmarAlt.TabIndex = 14;
            this.btn_confirmarAlt.Text = "Confirmar";
            this.btn_confirmarAlt.UseVisualStyleBackColor = false;
            this.btn_confirmarAlt.Visible = false;
            this.btn_confirmarAlt.Click += new System.EventHandler(this.btn_confirmarAlt_Click);
            // 
            // inputNome
            // 
            this.inputNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNome.Location = new System.Drawing.Point(172, 67);
            this.inputNome.Margin = new System.Windows.Forms.Padding(2);
            this.inputNome.Name = "inputNome";
            this.inputNome.ReadOnly = true;
            this.inputNome.Size = new System.Drawing.Size(270, 38);
            this.inputNome.TabIndex = 2;
            // 
            // btn_cancelarAlt
            // 
            this.btn_cancelarAlt.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancelarAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_cancelarAlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelarAlt.Location = new System.Drawing.Point(344, 342);
            this.btn_cancelarAlt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelarAlt.Name = "btn_cancelarAlt";
            this.btn_cancelarAlt.Size = new System.Drawing.Size(134, 44);
            this.btn_cancelarAlt.TabIndex = 15;
            this.btn_cancelarAlt.Text = "Cancelar";
            this.btn_cancelarAlt.UseVisualStyleBackColor = false;
            this.btn_cancelarAlt.Visible = false;
            this.btn_cancelarAlt.Click += new System.EventHandler(this.btn_cancelarAlt_Click);
            // 
            // inputEmail
            // 
            this.inputEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputEmail.Location = new System.Drawing.Point(172, 106);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(2);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.ReadOnly = true;
            this.inputEmail.Size = new System.Drawing.Size(270, 38);
            this.inputEmail.TabIndex = 4;
            // 
            // refrigeracaoDBDataSet
            // 
            this.refrigeracaoDBDataSet.DataSetName = "refrigeracaoDBDataSet";
            this.refrigeracaoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviçosBindingSource
            // 
            this.serviçosBindingSource.DataMember = "Serviços";
            this.serviçosBindingSource.DataSource = this.refrigeracaoDBDataSet;
            // 
            // serviçosTableAdapter
            // 
            this.serviçosTableAdapter.ClearBeforeFill = true;
            // 
            // listServicos
            // 
            this.listServicos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listServicos.BackColor = System.Drawing.SystemColors.Info;
            this.listServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listServicos.FormattingEnabled = true;
            this.listServicos.ItemHeight = 16;
            this.listServicos.Location = new System.Drawing.Point(536, 50);
            this.listServicos.Margin = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.listServicos.MaximumSize = new System.Drawing.Size(1126, 488);
            this.listServicos.Name = "listServicos";
            this.listServicos.Size = new System.Drawing.Size(566, 292);
            this.listServicos.TabIndex = 16;
            this.listServicos.SelectedIndexChanged += new System.EventHandler(this.listServicos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(767, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Serviços";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(631, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.MaximumSize = new System.Drawing.Size(375, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Novo serviço";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputCPF
            // 
            this.inputCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputCPF.Location = new System.Drawing.Point(172, 228);
            this.inputCPF.Margin = new System.Windows.Forms.Padding(2);
            this.inputCPF.Name = "inputCPF";
            this.inputCPF.ReadOnly = true;
            this.inputCPF.Size = new System.Drawing.Size(270, 38);
            this.inputCPF.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(70, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "CPF:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datePickAreaNasc
            // 
            this.datePickAreaNasc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.datePickAreaNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickAreaNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickAreaNasc.Location = new System.Drawing.Point(309, 273);
            this.datePickAreaNasc.Margin = new System.Windows.Forms.Padding(2);
            this.datePickAreaNasc.Name = "datePickAreaNasc";
            this.datePickAreaNasc.Size = new System.Drawing.Size(155, 35);
            this.datePickAreaNasc.TabIndex = 40;
            this.datePickAreaNasc.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(9, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 31);
            this.label8.TabIndex = 39;
            this.label8.Text = "Data de Nascimento:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimeClienteDesde
            // 
            this.dateTimeClienteDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dateTimeClienteDesde.Enabled = false;
            this.dateTimeClienteDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeClienteDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeClienteDesde.Location = new System.Drawing.Point(431, 7);
            this.dateTimeClienteDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeClienteDesde.Name = "dateTimeClienteDesde";
            this.dateTimeClienteDesde.Size = new System.Drawing.Size(155, 35);
            this.dateTimeClienteDesde.TabIndex = 42;
            this.dateTimeClienteDesde.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(239, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 31);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cliente desde:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.Maroon;
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExcluirCliente.Location = new System.Drawing.Point(955, 376);
            this.btnExcluirCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(147, 39);
            this.btnExcluirCliente.TabIndex = 43;
            this.btnExcluirCliente.Text = "Excluir cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1113, 426);
            this.Controls.Add(this.btnExcluirCliente);
            this.Controls.Add(this.dateTimeClienteDesde);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datePickAreaNasc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inputCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listServicos);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.btn_cancelarAlt);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_confirmarAlt);
            this.Controls.Add(this.id_Place);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_editarInfo);
            this.Controls.Add(this.inputEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTelefone);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1129, 657);
            this.MinimumSize = new System.Drawing.Size(1129, 357);
            this.Name = "Form2";
            this.Text = "Informações Detalhadas do Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id_Place;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputEnd;
        private System.Windows.Forms.TextBox inputTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editarInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirmarAlt;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.Button btn_cancelarAlt;
        private System.Windows.Forms.TextBox inputEmail;
        private refrigeracaoDBDataSet refrigeracaoDBDataSet;
        private System.Windows.Forms.BindingSource serviçosBindingSource;
        private refrigeracaoDBDataSetTableAdapters.ServiçosTableAdapter serviçosTableAdapter;
        private System.Windows.Forms.ListBox listServicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickAreaNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeClienteDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExcluirCliente;
    }
}