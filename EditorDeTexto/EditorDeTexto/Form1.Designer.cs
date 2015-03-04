namespace EditorDeTexto
{
    partial class Form1
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
            this.textBoxConteudo = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.groupBoxFindReplace = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelReplace = new System.Windows.Forms.Label();
            this.groupBoxFindReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConteudo
            // 
            this.textBoxConteudo.Location = new System.Drawing.Point(13, 13);
            this.textBoxConteudo.Multiline = true;
            this.textBoxConteudo.Name = "textBoxConteudo";
            this.textBoxConteudo.Size = new System.Drawing.Size(340, 136);
            this.textBoxConteudo.TabIndex = 0;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(13, 208);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 1;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // groupBoxFindReplace
            // 
            this.groupBoxFindReplace.Controls.Add(this.buttonReplace);
            this.groupBoxFindReplace.Controls.Add(this.textBoxReplace);
            this.groupBoxFindReplace.Controls.Add(this.labelReplace);
            this.groupBoxFindReplace.Controls.Add(this.buttonFind);
            this.groupBoxFindReplace.Controls.Add(this.textBoxBusca);
            this.groupBoxFindReplace.Controls.Add(this.labelFind);
            this.groupBoxFindReplace.Location = new System.Drawing.Point(94, 155);
            this.groupBoxFindReplace.Name = "groupBoxFindReplace";
            this.groupBoxFindReplace.Size = new System.Drawing.Size(259, 89);
            this.groupBoxFindReplace.TabIndex = 2;
            this.groupBoxFindReplace.TabStop = false;
            this.groupBoxFindReplace.Text = "Find and Replace";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(176, 20);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.Location = new System.Drawing.Point(55, 22);
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(115, 20);
            this.textBoxBusca.TabIndex = 1;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Location = new System.Drawing.Point(7, 25);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(27, 13);
            this.labelFind.TabIndex = 0;
            this.labelFind.Text = "Find";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(176, 53);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(55, 55);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(115, 20);
            this.textBoxReplace.TabIndex = 5;
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(7, 58);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(47, 13);
            this.labelReplace.TabIndex = 4;
            this.labelReplace.Text = "Replace";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.groupBoxFindReplace);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFindReplace.ResumeLayout(false);
            this.groupBoxFindReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConteudo;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.GroupBox groupBoxFindReplace;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelReplace;
    }
}

