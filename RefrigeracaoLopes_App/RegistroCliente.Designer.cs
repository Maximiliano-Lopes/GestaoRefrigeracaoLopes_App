namespace RefrigeracaoLopes_App
{
    partial class RegistroCliente
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
            this.inputNCPF = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputNEmail = new System.Windows.Forms.TextBox();
            this.btn_cancelarAlt = new System.Windows.Forms.Button();
            this.inputNNome = new System.Windows.Forms.TextBox();
            this.btn_confirmarAlt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickArea = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // inputNCPF
            // 
            this.inputNCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNCPF.Location = new System.Drawing.Point(147, 236);
            this.inputNCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNCPF.Name = "inputNCPF";
            this.inputNCPF.Size = new System.Drawing.Size(564, 38);
            this.inputNCPF.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(46, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 35;
            this.label7.Text = "CPF:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputNEmail
            // 
            this.inputNEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNEmail.Location = new System.Drawing.Point(147, 99);
            this.inputNEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNEmail.Name = "inputNEmail";
            this.inputNEmail.Size = new System.Drawing.Size(564, 38);
            this.inputNEmail.TabIndex = 23;
            // 
            // btn_cancelarAlt
            // 
            this.btn_cancelarAlt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelarAlt.BackColor = System.Drawing.Color.Maroon;
            this.btn_cancelarAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_cancelarAlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelarAlt.Location = new System.Drawing.Point(432, 396);
            this.btn_cancelarAlt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelarAlt.Name = "btn_cancelarAlt";
            this.btn_cancelarAlt.Size = new System.Drawing.Size(165, 37);
            this.btn_cancelarAlt.TabIndex = 33;
            this.btn_cancelarAlt.Text = "Cancelar criação";
            this.btn_cancelarAlt.UseVisualStyleBackColor = false;
            this.btn_cancelarAlt.Click += new System.EventHandler(this.btn_cancelarAlt_Click);
            // 
            // inputNNome
            // 
            this.inputNNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNNome.Location = new System.Drawing.Point(147, 55);
            this.inputNNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNNome.Name = "inputNNome";
            this.inputNNome.Size = new System.Drawing.Size(564, 38);
            this.inputNNome.TabIndex = 21;
            // 
            // btn_confirmarAlt
            // 
            this.btn_confirmarAlt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmarAlt.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_confirmarAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btn_confirmarAlt.Location = new System.Drawing.Point(248, 396);
            this.btn_confirmarAlt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_confirmarAlt.Name = "btn_confirmarAlt";
            this.btn_confirmarAlt.Size = new System.Drawing.Size(142, 37);
            this.btn_confirmarAlt.TabIndex = 32;
            this.btn_confirmarAlt.Text = "Criar cliente";
            this.btn_confirmarAlt.UseVisualStyleBackColor = false;
            this.btn_confirmarAlt.Click += new System.EventHandler(this.btn_confirmarAlt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(52, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tel:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputNEnd
            // 
            this.inputNEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNEnd.Location = new System.Drawing.Point(147, 190);
            this.inputNEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNEnd.Name = "inputNEnd";
            this.inputNEnd.Size = new System.Drawing.Size(564, 38);
            this.inputNEnd.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputNTelefone
            // 
            this.inputNTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputNTelefone.Location = new System.Drawing.Point(147, 143);
            this.inputNTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputNTelefone.Name = "inputNTelefone";
            this.inputNTelefone.Size = new System.Drawing.Size(564, 38);
            this.inputNTelefone.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(46, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 31);
            this.label6.TabIndex = 30;
            this.label6.Text = "End:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Data de Nascimento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // datePickArea
            // 
            this.datePickArea.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.datePickArea.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.datePickArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickArea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickArea.Location = new System.Drawing.Point(544, 285);
            this.datePickArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePickArea.Name = "datePickArea";
            this.datePickArea.Size = new System.Drawing.Size(166, 35);
            this.datePickArea.TabIndex = 38;
            this.datePickArea.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.datePickArea.ValueChanged += new System.EventHandler(this.datePickArea_ValueChanged);
            // 
            // RegistroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 544);
            this.Controls.Add(this.datePickArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputNCPF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputNEmail);
            this.Controls.Add(this.btn_cancelarAlt);
            this.Controls.Add(this.inputNNome);
            this.Controls.Add(this.btn_confirmarAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNTelefone);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(818, 583);
            this.MinimumSize = new System.Drawing.Size(818, 583);
            this.Name = "RegistroCliente";
            this.Text = "RegistroCliente";
            this.Load += new System.EventHandler(this.RegistroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputNEmail;
        private System.Windows.Forms.Button btn_cancelarAlt;
        private System.Windows.Forms.TextBox inputNNome;
        private System.Windows.Forms.Button btn_confirmarAlt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickArea;
    }
}