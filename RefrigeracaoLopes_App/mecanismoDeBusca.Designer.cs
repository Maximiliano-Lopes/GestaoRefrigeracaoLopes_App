namespace RefrigeracaoLopes_App
{
    partial class mecanismoDeBusca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textPesq = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refrigeracaoDBDataSet3 = new RefrigeracaoLopes_App.refrigeracaoDBDataSet3();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new RefrigeracaoLopes_App.refrigeracaoDBDataSet3TableAdapters.ClientesTableAdapter();
            this.dataGridViewPesq = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatórioDaSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emAbertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPendentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verConcluídosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textPesq
            // 
            this.textPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPesq.Location = new System.Drawing.Point(350, 37);
            this.textPesq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Location = new System.Drawing.Point(748, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // dataGridViewPesq
            // 
            this.dataGridViewPesq.AllowUserToAddRows = false;
            this.dataGridViewPesq.AllowUserToDeleteRows = false;
            this.dataGridViewPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPesq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPesq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPesq.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridViewPesq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPesq.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesq.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewPesq.Location = new System.Drawing.Point(-1, 76);
            this.dataGridViewPesq.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.dataGridViewPesq.Name = "dataGridViewPesq";
            this.dataGridViewPesq.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPesq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPesq.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPesq.RowTemplate.Height = 24;
            this.dataGridViewPesq.Size = new System.Drawing.Size(915, 490);
            this.dataGridViewPesq.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDaSemanaToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.serviçosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(290, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatórioDaSemanaToolStripMenuItem
            // 
            this.relatórioDaSemanaToolStripMenuItem.Name = "relatórioDaSemanaToolStripMenuItem";
            this.relatórioDaSemanaToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.relatórioDaSemanaToolStripMenuItem.Text = "Relatório em intervalo";
            this.relatórioDaSemanaToolStripMenuItem.Click += new System.EventHandler(this.relatórioDaSemanaToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emAbertoToolStripMenuItem,
            this.verPagosToolStripMenuItem});
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPendentesToolStripMenuItem,
            this.verConcluídosToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // emAbertoToolStripMenuItem
            // 
            this.emAbertoToolStripMenuItem.Name = "emAbertoToolStripMenuItem";
            this.emAbertoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.emAbertoToolStripMenuItem.Text = "Ver pendentes";
            // 
            // verPendentesToolStripMenuItem
            // 
            this.verPendentesToolStripMenuItem.Name = "verPendentesToolStripMenuItem";
            this.verPendentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPendentesToolStripMenuItem.Text = "Ver pendentes";
            // 
            // verConcluídosToolStripMenuItem
            // 
            this.verConcluídosToolStripMenuItem.Name = "verConcluídosToolStripMenuItem";
            this.verConcluídosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verConcluídosToolStripMenuItem.Text = "Ver concluídos";
            // 
            // verPagosToolStripMenuItem
            // 
            this.verPagosToolStripMenuItem.Name = "verPagosToolStripMenuItem";
            this.verPagosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verPagosToolStripMenuItem.Text = "Ver pagos";
            // 
            // mecanismoDeBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 559);
            this.Controls.Add(this.dataGridViewPesq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPesq);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mecanismoDeBusca";
            this.Text = "mecanismoDeBusca";
            this.Load += new System.EventHandler(this.mecanismoDeBusca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refrigeracaoDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textPesq;
        private System.Windows.Forms.Button button1;
        private refrigeracaoDBDataSet3 refrigeracaoDBDataSet3;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private refrigeracaoDBDataSet3TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewPesq;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatórioDaSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emAbertoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPendentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verConcluídosToolStripMenuItem;
    }
}