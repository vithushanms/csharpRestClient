namespace CSharpRestClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetRes = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GetRes
            // 
            this.GetRes.Location = new System.Drawing.Point(35, 143);
            this.GetRes.Name = "GetRes";
            this.GetRes.Size = new System.Drawing.Size(112, 34);
            this.GetRes.TabIndex = 0;
            this.GetRes.Text = "Get";
            this.GetRes.UseVisualStyleBackColor = true;
            this.GetRes.Click += new System.EventHandler(this.GetRes_Click);
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(130, 60);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(635, 31);
            this.urlText.TabIndex = 1;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Location = new System.Drawing.Point(35, 60);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(43, 25);
            this.URL.TabIndex = 2;
            this.URL.Text = "URL";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(35, 196);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputText.Size = new System.Drawing.Size(730, 214);
            this.outputText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.GetRes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetRes;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.TextBox outputText;
    }
}

