﻿namespace EditorDeTexto
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
            this.SuspendLayout();
            // 
            // textBoxConteudo
            // 
            this.textBoxConteudo.Location = new System.Drawing.Point(13, 13);
            this.textBoxConteudo.Multiline = true;
            this.textBoxConteudo.Name = "textBoxConteudo";
            this.textBoxConteudo.Size = new System.Drawing.Size(259, 201);
            this.textBoxConteudo.TabIndex = 0;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(13, 221);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 1;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConteudo;
        private System.Windows.Forms.Button buttonGravar;
    }
}

