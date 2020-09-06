namespace CSharpRSACryptography
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
            this.TxtPlainText = new System.Windows.Forms.TextBox();
            this.TxtEncryptedText = new System.Windows.Forms.TextBox();
            this.TxtDecrytedText = new System.Windows.Forms.TextBox();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPlainText
            // 
            this.TxtPlainText.Location = new System.Drawing.Point(12, 29);
            this.TxtPlainText.Multiline = true;
            this.TxtPlainText.Name = "TxtPlainText";
            this.TxtPlainText.Size = new System.Drawing.Size(665, 66);
            this.TxtPlainText.TabIndex = 0;
            // 
            // TxtEncryptedText
            // 
            this.TxtEncryptedText.Location = new System.Drawing.Point(12, 135);
            this.TxtEncryptedText.Multiline = true;
            this.TxtEncryptedText.Name = "TxtEncryptedText";
            this.TxtEncryptedText.ReadOnly = true;
            this.TxtEncryptedText.Size = new System.Drawing.Size(665, 191);
            this.TxtEncryptedText.TabIndex = 1;
            // 
            // TxtDecrytedText
            // 
            this.TxtDecrytedText.Location = new System.Drawing.Point(12, 362);
            this.TxtDecrytedText.Multiline = true;
            this.TxtDecrytedText.Name = "TxtDecrytedText";
            this.TxtDecrytedText.ReadOnly = true;
            this.TxtDecrytedText.Size = new System.Drawing.Size(665, 66);
            this.TxtDecrytedText.TabIndex = 2;
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(518, 434);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(159, 63);
            this.BtnDecrypt.TabIndex = 3;
            this.BtnDecrypt.Text = "رمزگشایی";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(12, 434);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(159, 63);
            this.BtnEncrypt.TabIndex = 4;
            this.BtnEncrypt.Text = "رمزگذاری";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(257, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "متنی که میخواهید رمزگذاری شود";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(420, 341);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(257, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "متن رمزگشایی شده";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(420, 114);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(257, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "متن رمزگذاری شده";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.TxtDecrytedText);
            this.Controls.Add(this.TxtEncryptedText);
            this.Controls.Add(this.TxtPlainText);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SourceSara.Com | C# RSA Cryptography";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPlainText;
        private System.Windows.Forms.TextBox TxtEncryptedText;
        private System.Windows.Forms.TextBox TxtDecrytedText;
        private System.Windows.Forms.Button BtnDecrypt;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

