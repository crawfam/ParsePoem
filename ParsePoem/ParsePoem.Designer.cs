namespace ParsePoem
{
    partial class ParsePoem
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
            this.txtPoemBody = new System.Windows.Forms.TextBox();
            this.txtPoemTitle = new System.Windows.Forms.TextBox();
            this.btnPoemToHTML = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnMultipleStanzas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPoemBody
            // 
            this.txtPoemBody.Location = new System.Drawing.Point(126, 220);
            this.txtPoemBody.Margin = new System.Windows.Forms.Padding(5);
            this.txtPoemBody.Multiline = true;
            this.txtPoemBody.Name = "txtPoemBody";
            this.txtPoemBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPoemBody.Size = new System.Drawing.Size(1807, 736);
            this.txtPoemBody.TabIndex = 0;
            // 
            // txtPoemTitle
            // 
            this.txtPoemTitle.Location = new System.Drawing.Point(126, 149);
            this.txtPoemTitle.Margin = new System.Windows.Forms.Padding(5);
            this.txtPoemTitle.Name = "txtPoemTitle";
            this.txtPoemTitle.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPoemTitle.Size = new System.Drawing.Size(1807, 38);
            this.txtPoemTitle.TabIndex = 1;
            // 
            // btnPoemToHTML
            // 
            this.btnPoemToHTML.Location = new System.Drawing.Point(126, 46);
            this.btnPoemToHTML.Margin = new System.Windows.Forms.Padding(5);
            this.btnPoemToHTML.Name = "btnPoemToHTML";
            this.btnPoemToHTML.Size = new System.Drawing.Size(247, 74);
            this.btnPoemToHTML.TabIndex = 2;
            this.btnPoemToHTML.Text = "Poem To HTML";
            this.btnPoemToHTML.UseVisualStyleBackColor = true;
            this.btnPoemToHTML.Click += new System.EventHandler(this.btnPoemToHTML_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(680, 46);
            this.btnCopyToClipboard.Margin = new System.Windows.Forms.Padding(5);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(281, 74);
            this.btnCopyToClipboard.TabIndex = 3;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnMultipleStanzas
            // 
            this.btnMultipleStanzas.Location = new System.Drawing.Point(403, 46);
            this.btnMultipleStanzas.Name = "btnMultipleStanzas";
            this.btnMultipleStanzas.Size = new System.Drawing.Size(245, 74);
            this.btnMultipleStanzas.TabIndex = 4;
            this.btnMultipleStanzas.Text = "Multiple Stanzas";
            this.btnMultipleStanzas.UseVisualStyleBackColor = true;
            this.btnMultipleStanzas.Click += new System.EventHandler(this.btnMultipleStanzas_Click);
            // 
            // ParsePoem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2094, 1018);
            this.Controls.Add(this.btnMultipleStanzas);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.btnPoemToHTML);
            this.Controls.Add(this.txtPoemTitle);
            this.Controls.Add(this.txtPoemBody);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ParsePoem";
            this.Text = "Parse Poem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPoemBody;
        private System.Windows.Forms.TextBox txtPoemTitle;
        private System.Windows.Forms.Button btnPoemToHTML;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnMultipleStanzas;
    }
}

