namespace RefrigeracaoLopes_App
{
    partial class ResultadoPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridResultadoPesquisa = new System.Windows.Forms.DataGridView();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultadoPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResultadoPesquisa
            // 
            this.dataGridResultadoPesquisa.AllowUserToAddRows = false;
            this.dataGridResultadoPesquisa.AllowUserToDeleteRows = false;
            this.dataGridResultadoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResultadoPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResultadoPesquisa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridResultadoPesquisa.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dataGridResultadoPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridResultadoPesquisa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResultadoPesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridResultadoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultadoPesquisa.GridColor = System.Drawing.Color.Brown;
            this.dataGridResultadoPesquisa.Location = new System.Drawing.Point(0, 1);
            this.dataGridResultadoPesquisa.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.dataGridResultadoPesquisa.Name = "dataGridResultadoPesquisa";
            this.dataGridResultadoPesquisa.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridResultadoPesquisa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridResultadoPesquisa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridResultadoPesquisa.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridResultadoPesquisa.RowTemplate.Height = 24;
            this.dataGridResultadoPesquisa.Size = new System.Drawing.Size(939, 501);
            this.dataGridResultadoPesquisa.TabIndex = 3;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_imprimir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_imprimir.Location = new System.Drawing.Point(759, 506);
            this.btn_imprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(168, 30);
            this.btn_imprimir.TabIndex = 56;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // ResultadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 540);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.dataGridResultadoPesquisa);
            this.Name = "ResultadoPesquisa";
            this.Text = "ResultadoPesquisa";
            this.Load += new System.EventHandler(this.ResultadoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultadoPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridResultadoPesquisa;
        private System.Windows.Forms.Button btn_imprimir;
    }
}