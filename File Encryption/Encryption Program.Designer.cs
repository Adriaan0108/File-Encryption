namespace File_Encryption
{
    partial class Encryption_Program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption_Program));
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.tbpasswordDecrypt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.tbFilePathDecrypt = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(429, 110);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(372, 51);
            this.btnDecrypt.TabIndex = 44;
            this.btnDecrypt.Text = "Save decrypted file (encrypted file will be deleted)";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecrypt.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypt.Location = new System.Drawing.Point(476, 22);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(160, 19);
            this.lblDecrypt.TabIndex = 50;
            this.lblDecrypt.Text = "Select file to DECRYPT:";
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEncrypt.Cursor = System.Windows.Forms.Cursors.No;
            this.lblEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypt.Location = new System.Drawing.Point(59, 19);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(160, 19);
            this.lblEncrypt.TabIndex = 49;
            this.lblEncrypt.Text = "Select file to ENCRYPT:";
            // 
            // tbpasswordDecrypt
            // 
            this.tbpasswordDecrypt.Location = new System.Drawing.Point(562, 64);
            this.tbpasswordDecrypt.Name = "tbpasswordDecrypt";
            this.tbpasswordDecrypt.PasswordChar = '*';
            this.tbpasswordDecrypt.Size = new System.Drawing.Size(207, 20);
            this.tbpasswordDecrypt.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Password:";
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.AllowDrop = true;
            this.btnBrowseDecrypt.BackColor = System.Drawing.SystemColors.Window;
            this.btnBrowseDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(669, 19);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(73, 25);
            this.btnBrowseDecrypt.TabIndex = 46;
            this.btnBrowseDecrypt.Text = "Browse";
            this.btnBrowseDecrypt.UseVisualStyleBackColor = false;
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            this.btnBrowseDecrypt.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnBrowseDecrypt_DragDrop);
            this.btnBrowseDecrypt.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnBrowseDecrypt_DragEnter);
            // 
            // tbFilePathDecrypt
            // 
            this.tbFilePathDecrypt.Location = new System.Drawing.Point(462, 126);
            this.tbFilePathDecrypt.Name = "tbFilePathDecrypt";
            this.tbFilePathDecrypt.ReadOnly = true;
            this.tbFilePathDecrypt.Size = new System.Drawing.Size(291, 20);
            this.tbFilePathDecrypt.TabIndex = 45;
            this.tbFilePathDecrypt.Visible = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 110);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(372, 51);
            this.btnEncrypt.TabIndex = 43;
            this.btnEncrypt.Text = "Save encrypted file (origional file will be deleted)";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(145, 65);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(207, 20);
            this.tbPassword.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(39, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 41;
            this.lblPassword.Text = "Password:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AllowDrop = true;
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Window;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(243, 14);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(73, 26);
            this.btnBrowse.TabIndex = 40;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnBrowse_DragDrop);
            this.btnBrowse.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnBrowse_DragEnter);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(25, 126);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(291, 20);
            this.tbPath.TabIndex = 39;
            this.tbPath.Visible = false;
            // 
            // Encryption_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::File_Encryption.Properties.Resources.Backgorund;
            this.ClientSize = new System.Drawing.Size(817, 180);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.tbpasswordDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseDecrypt);
            this.Controls.Add(this.tbFilePathDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encryption_Program";
            this.Text = "Encryption_Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.TextBox tbpasswordDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseDecrypt;
        private System.Windows.Forms.TextBox tbFilePathDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbPath;
    }
}