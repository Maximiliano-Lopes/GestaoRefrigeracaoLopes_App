namespace RefrigeracaoLopes_App
{
    partial class ShowInformation
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
            this.dataGridViewPesq = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textPesq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesq.GridColor = System.Drawing.Color.Brown;
            this.dataGridViewPesq.Location = new System.Drawing.Point(-1, 137);
            this.dataGridViewPesq.Margin = new System.Windows.Forms.Padding(8, 2, 2, 2);
            this.dataGridViewPesq.Name = "dataGridViewPesq";
            this.dataGridViewPesq.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPesq.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPesq.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPesq.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPesq.RowTemplate.Height = 24;
            this.dataGridViewPesq.Size = new System.Drawing.Size(1167, 666);
            this.dataGridViewPesq.TabIndex = 5;
            this.dataGridViewPesq.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(1005, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textPesq
            // 
            this.textPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textPesq.Location = new System.Drawing.Point(607, 98);
            this.textPesq.Margin = new System.Windows.Forms.Padding(2);
            this.textPesq.Name = "textPesq";
            this.textPesq.Size = new System.Drawing.Size(383, 35);
            this.textPesq.TabIndex = 3;
            // 
            // ShowInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 690);
            this.Controls.Add(this.dataGridViewPesq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPesq);
            this.Name = "ShowInformation";
            this.Text = "ShowInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPesq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textPesq;
    }
}