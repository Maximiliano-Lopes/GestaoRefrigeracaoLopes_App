namespace RefrigeracaoLopes_App
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.paginacao = new System.Windows.Forms.TabControl();
            this.clienteArea = new System.Windows.Forms.TabPage();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnPesq = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDEREÇODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSet2 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPesqToService = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textPesq = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSet1 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrigeracaoDBDataSet = new RefrigeracaoLopes_App.refrigeracaoDBDataSet();
            this.clientesTableAdapter = new RefrigeracaoLopes_App.refrigeracaoDBDataSetTableAdapters.ClientesTableAdapter();
            this.refrigeracaoDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter1 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet1TableAdapters.ClientesTableAdapter();
            this.serviçosTableAdapter = new RefrigeracaoLopes_App.refrigeracaoDBDataSet1TableAdapters.ServiçosTableAdapter();
            this.refrigeracaoDBDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter2 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet2TableAdapters.ClientesTableAdapter();
            this.fKServiçosClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paginacao.SuspendLayout();
            this.clienteArea.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqToService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiçosClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // paginacao
            // 
            this.paginacao.Controls.Add(this.clienteArea);
            this.paginacao.Controls.Add(this.tabPage2);
            this.paginacao.Controls.Add(this.tabPage1);
            this.paginacao.Controls.Add(this.tabPage3);
            this.paginacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paginacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paginacao.Location = new System.Drawing.Point(0, 0);
            this.paginacao.Name = "paginacao";
            this.paginacao.SelectedIndex = 0;
            this.paginacao.Size = new System.Drawing.Size(1189, 684);
            this.paginacao.TabIndex = 1;
            // 
            // clienteArea
            // 
            this.clienteArea.AutoScroll = true;
            this.clienteArea.BackColor = System.Drawing.Color.Silver;
            this.clienteArea.Controls.Add(this.fillByToolStrip);
            this.clienteArea.Controls.Add(this.btnPesq);
            this.clienteArea.Controls.Add(this.button1);
            this.clienteArea.Controls.Add(this.dataGridView1);
            this.clienteArea.Location = new System.Drawing.Point(4, 22);
            this.clienteArea.Name = "clienteArea";
            this.clienteArea.Padding = new System.Windows.Forms.Padding(3);
            this.clienteArea.Size = new System.Drawing.Size(1181, 658);
            this.clienteArea.TabIndex = 0;
            this.clienteArea.Text = "Clientes";
            this.clienteArea.Click += new System.EventHandler(this.clienteArea_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(871, 13);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(35, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fillByToolStripButton.BackgroundImage")));
            this.fillByToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesq.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPesq.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnPesq.Location = new System.Drawing.Point(1037, 9);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(123, 32);
            this.btnPesq.TabIndex = 2;
            this.btnPesq.Text = "Pesquisar Cliente";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(910, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novo Cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.cPFCNPJDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.eNDEREÇODataGridViewTextBoxColumn,
            this.dATANSCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource4;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 611);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // clientesBindingSource4
            // 
            this.clientesBindingSource4.DataMember = "Clientes";
            this.clientesBindingSource4.DataSource = this.refrigeracaoDBDataSet2;
            // 
            // refrigeracaoDBDataSet2
            // 
            this.refrigeracaoDBDataSet2.DataSetName = "refrigeracaoDBDataSet2";
            this.refrigeracaoDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewPesqToService);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textPesq);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1181, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Serviços";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPesqToService
            // 
            this.dataGridViewPesqToService.AllowUserToAddRows = false;
            this.dataGridViewPesqToService.AllowUserToDeleteRows = false;
            this.dataGridViewPesqToService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesqToService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesqToService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPesqToService.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridViewPesqToService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesqToService.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesqToService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPesqToService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesqToService.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewPesqToService.Location = new System.Drawing.Point(-33, 79);
            this.dataGridViewPesqToService.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridViewPesqToService.Name = "dataGridViewPesqToService";
            this.dataGridViewPesqToService.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesqToService.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewPesqToService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPesqToService.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewPesqToService.RowTemplate.Height = 24;
            this.dataGridViewPesqToService.Size = new System.Drawing.Size(1397, 647);
            this.dataGridViewPesqToService.TabIndex = 5;
            this.dataGridViewPesqToService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPesqToService_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encontrar cliente:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button2.Location = new System.Drawing.Point(999, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textPesq
            // 
            this.textPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPesq.Location = new System.Drawing.Point(450, 13);
            this.textPesq.Name = "textPesq";
            this.textPesq.Size = new System.Drawing.Size(527, 35);
            this.textPesq.TabIndex = 2;
            this.textPesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPesq_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1181, 658);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Venda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1181, 658);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Compra";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "Clientes";
            this.clientesBindingSource2.DataSource = this.refrigeracaoDBDataSet1;
            // 
            // refrigeracaoDBDataSet1
            // 
            this.refrigeracaoDBDataSet1.DataSetName = "refrigeracaoDBDataSet1";
            this.refrigeracaoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.refrigeracaoDBDataSetBindingSource;
            // 
            // refrigeracaoDBDataSetBindingSource
            // 
            this.refrigeracaoDBDataSetBindingSource.DataSource = this.refrigeracaoDBDataSet;
            this.refrigeracaoDBDataSetBindingSource.Position = 0;
            // 
            // refrigeracaoDBDataSet
            // 
            this.refrigeracaoDBDataSet.DataSetName = "refrigeracaoDBDataSet";
            this.refrigeracaoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // refrigeracaoDBDataSet1BindingSource
            // 
            this.refrigeracaoDBDataSet1BindingSource.DataSource = this.refrigeracaoDBDataSet1;
            this.refrigeracaoDBDataSet1BindingSource.Position = 0;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "Clientes";
            this.clientesBindingSource1.DataSource = this.refrigeracaoDBDataSet1;
            // 
            // clientesTableAdapter1
            // 
            this.clientesTableAdapter1.ClearBeforeFill = true;
            // 
            // serviçosTableAdapter
            // 
            this.serviçosTableAdapter.ClearBeforeFill = true;
            // 
            // refrigeracaoDBDataSet1BindingSource1
            // 
            this.refrigeracaoDBDataSet1BindingSource1.DataSource = this.refrigeracaoDBDataSet1;
            this.refrigeracaoDBDataSet1BindingSource1.Position = 0;
            // 
            // clientesBindingSource3
            // 
            this.clientesBindingSource3.DataMember = "Clientes";
            this.clientesBindingSource3.DataSource = this.refrigeracaoDBDataSet1BindingSource1;
            // 
            // clientesTableAdapter2
            // 
            this.clientesTableAdapter2.ClearBeforeFill = true;
            // 
            // fKServiçosClientesBindingSource
            // 
            this.fKServiçosClientesBindingSource.DataMember = "FK_Serviços_Clientes";
            this.fKServiçosClientesBindingSource.DataSource = this.clientesBindingSource2;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1189, 684);
            this.Controls.Add(this.paginacao);
            this.Name = "Principal";
            this.Text = "App Refrigeração Lopes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.paginacao.ResumeLayout(false);
            this.clienteArea.ResumeLayout(false);
            this.clienteArea.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesqToService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKServiçosClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl paginacao;
        private System.Windows.Forms.TabPage clienteArea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource refrigeracaoDBDataSetBindingSource;
        private refrigeracaoDBDataSet refrigeracaoDBDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private refrigeracaoDBDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource refrigeracaoDBDataSet1BindingSource;
        private refrigeracaoDBDataSet1 refrigeracaoDBDataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private refrigeracaoDBDataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.BindingSource fKServiçosClientesBindingSource;
        private refrigeracaoDBDataSet1TableAdapters.ServiçosTableAdapter serviçosTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource3;
        private System.Windows.Forms.BindingSource refrigeracaoDBDataSet1BindingSource1;
        private refrigeracaoDBDataSet2 refrigeracaoDBDataSet2;
        private System.Windows.Forms.BindingSource clientesBindingSource4;
        private refrigeracaoDBDataSet2TableAdapters.ClientesTableAdapter clientesTableAdapter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textPesq;
        private System.Windows.Forms.DataGridView dataGridViewPesqToService;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDEREÇODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANSCDataGridViewTextBoxColumn;
    }
}

