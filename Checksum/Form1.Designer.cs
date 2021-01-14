namespace Checksum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MD5 = new System.Windows.Forms.TextBox();
            this.txt_SHA1 = new System.Windows.Forms.TextBox();
            this.txt_SHA256 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHA1";
            // 
            // txt_MD5
            // 
            this.txt_MD5.Location = new System.Drawing.Point(66, 10);
            this.txt_MD5.Name = "txt_MD5";
            this.txt_MD5.ReadOnly = true;
            this.txt_MD5.Size = new System.Drawing.Size(407, 20);
            this.txt_MD5.TabIndex = 3;
            // 
            // txt_SHA1
            // 
            this.txt_SHA1.Location = new System.Drawing.Point(66, 36);
            this.txt_SHA1.Name = "txt_SHA1";
            this.txt_SHA1.ReadOnly = true;
            this.txt_SHA1.Size = new System.Drawing.Size(407, 20);
            this.txt_SHA1.TabIndex = 4;
            // 
            // txt_SHA256
            // 
            this.txt_SHA256.Location = new System.Drawing.Point(66, 62);
            this.txt_SHA256.Name = "txt_SHA256";
            this.txt_SHA256.ReadOnly = true;
            this.txt_SHA256.Size = new System.Drawing.Size(407, 20);
            this.txt_SHA256.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SHA256";
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(63, 87);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(0, 13);
            this.lbl_file.TabIndex = 7;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 109);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.txt_SHA256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SHA1);
            this.Controls.Add(this.txt_MD5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Checksum by share424";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MD5;
        private System.Windows.Forms.TextBox txt_SHA1;
        private System.Windows.Forms.TextBox txt_SHA256;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_file;
    }
}

