namespace RefrigeracaoLopes_App
{
    partial class MecanismoDeBusca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textPesq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refrigeracaoDBDataSet3 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet3();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RefrigeracaoLopes_App.refrigeracaoDBDataSet3TableAdapters.ClientesTableAdapter();
            this.dataGridViewMecBusc = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDEREÇODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATACRIACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSet4 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet4();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatórioDaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emAbertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verConcluídosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet4TableAdapters.ClientesTableAdapter();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMecBusc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textPesq
            // 
            this.textPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPesq.Location = new System.Drawing.Point(658, 33);
            this.textPesq.Margin = new System.Windows.Forms.Padding(2);
            this.textPesq.Name = "textPesq";
            this.textPesq.Size = new System.Drawing.Size(383, 35);
            this.textPesq.TabIndex = 0;
            this.textPesq.TextChanged += new System.EventHandler(this.textPesq_TextChanged);
            this.textPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPesq_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1045, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refrigeracaoDBDataSet3
            // 
            this.refrigeracaoDBDataSet3.DataSetName = "refrigeracaoDBDataSet3";
            this.refrigeracaoDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.refrigeracaoDBDataSet3;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewMecBusc
            // 
            this.dataGridViewMecBusc.AllowUserToAddRows = false;
            this.dataGridViewMecBusc.AllowUserToDeleteRows = false;
            this.dataGridViewMecBusc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMecBusc.AutoGenerateColumns = false;
            this.dataGridViewMecBusc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMecBusc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMecBusc.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridViewMecBusc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMecBusc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMecBusc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMecBusc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMecBusc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cPFCNPJDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.eNDEREÇODataGridViewTextBoxColumn,
            this.dATANSCDataGridViewTextBoxColumn,
            this.dATACRIACAODataGridViewTextBoxColumn});
            this.dataGridViewMecBusc.DataSource = this.clientesBindingSource3;
            this.dataGridViewMecBusc.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewMecBusc.Location = new System.Drawing.Point(-1, 76);
            this.dataGridViewMecBusc.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.dataGridViewMecBusc.Name = "dataGridViewMecBusc";
            this.dataGridViewMecBusc.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMecBusc.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMecBusc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMecBusc.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewMecBusc.RowTemplate.Height = 24;
            this.dataGridViewMecBusc.Size = new System.Drawing.Size(1210, 490);
            this.dataGridViewMecBusc.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPFCNPJDataGridViewTextBoxColumn
            // 
            this.cPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPF_CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF_CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.Name = "cPFCNPJDataGridViewTextBoxColumn";
            this.cPFCNPJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDEREÇODataGridViewTextBoxColumn
            // 
            this.eNDEREÇODataGridViewTextBoxColumn.DataPropertyName = "ENDEREÇO";
            this.eNDEREÇODataGridViewTextBoxColumn.HeaderText = "ENDEREÇO";
            this.eNDEREÇODataGridViewTextBoxColumn.Name = "eNDEREÇODataGridViewTextBoxColumn";
            this.eNDEREÇODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATANSCDataGridViewTextBoxColumn
            // 
            this.dATANSCDataGridViewTextBoxColumn.DataPropertyName = "DATA_NSC";
            this.dATANSCDataGridViewTextBoxColumn.HeaderText = "DATA_NSC";
            this.dATANSCDataGridViewTextBoxColumn.Name = "dATANSCDataGridViewTextBoxColumn";
            this.dATANSCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATACRIACAODataGridViewTextBoxColumn
            // 
            this.dATACRIACAODataGridViewTextBoxColumn.DataPropertyName = "DATA_CRIACAO";
            this.dATACRIACAODataGridViewTextBoxColumn.HeaderText = "DATA_CRIACAO";
            this.dATACRIACAODataGridViewTextBoxColumn.Name = "dATACRIACAODataGridViewTextBoxColumn";
            this.dATACRIACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "Clientes";
            this.clientesBindingSource3.DataSource = this.refrigeracaoDBDataSet4BindingSource;
            // 
            // refrigeracaoDBDataSet4BindingSource
            // 
            this.refrigeracaoDBDataSet4BindingSource.DataSource = this.refrigeracaoDBDataSet4;
            this.refrigeracaoDBDataSet4BindingSource.Position = 0;
            // 
            // refrigeracaoDBDataSet4
            // 
            this.refrigeracaoDBDataSet4.DataSetName = "refrigeracaoDBDataSet4";
            this.refrigeracaoDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDaSemanaToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 29);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatórioDaSemanaToolStripMenuItem
            // 
            this.relatórioDaSemanaToolStripMenuItem.Name = "relatórioDaSemanaToolStripMenuItem";
            this.relatórioDaSemanaToolStripMenuItem.Size = new System.Drawing.Size(176, 25);
            this.relatórioDaSemanaToolStripMenuItem.Text = "Relatório em intervalo";
            this.relatórioDaSemanaToolStripMenuItem.Click += new System.EventHandler(this.relatórioDaSemanaToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emAbertoToolStripMenuItem,
            this.verPagosToolStripMenuItem});
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // emAbertoToolStripMenuItem
            // 
            this.emAbertoToolStripMenuItem.Name = "emAbertoToolStripMenuItem";
            this.emAbertoToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.emAbertoToolStripMenuItem.Text = "Ver pendentes";
            this.emAbertoToolStripMenuItem.Click += new System.EventHandler(this.emAbertoToolStripMenuItem_Click);
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.verPagosToolStripMenuItem.Text = "Ver pagos";
            this.verPagosToolStripMenuItem.Click += new System.EventHandler(this.verPagosToolStripMenuItem_Click);
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPendentesToolStripMenuItem,
            this.verConcluídosToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // verPendentesToolStripMenuItem
            // 
            this.verPendentesToolStripMenuItem.Name = "verPendentesToolStripMenuItem";
            this.verPendentesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verPendentesToolStripMenuItem.Text = "Ver pendentes";
            this.verPendentesToolStripMenuItem.Click += new System.EventHandler(this.verPendentesToolStripMenuItem_Click);
            // 
            // verConcluídosToolStripMenuItem
            // 
            this.verConcluídosToolStripMenuItem.Name = "verConcluídosToolStripMenuItem";
            this.verConcluídosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.verConcluídosToolStripMenuItem.Text = "Ver concluídos";
            this.verConcluídosToolStripMenuItem.Click += new System.EventHandler(this.verConcluídosToolStripMenuItem_Click);
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.refrigeracaoDBDataSet4;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.refrigeracaoDBDataSet4;
            // 
            // MecanismoDeBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1211, 559);
            this.Controls.Add(this.dataGridViewMecBusc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPesq);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MecanismoDeBusca";
            this.Text = "mecanismoDeBusca";
            this.Load += new System.EventHandler(this.mecanismoDeBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMecBusc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPesq;
        private System.Windows.Forms.Button button1;
        private refrigeracaoDBDataSet3 refrigeracaoDBDataSet3;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private refrigeracaoDBDataSet3TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatórioDaSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emAbertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verConcluídosToolStripMenuItem;
        private refrigeracaoDBDataSet4 refrigeracaoDBDataSet4;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private refrigeracaoDBDataSet4TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDEREÇODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATACRIACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private System.Windows.Forms.BindingSource refrigeracaoDBDataSet4BindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        public System.Windows.Forms.DataGridView dataGridViewMecBusc;
    }
}