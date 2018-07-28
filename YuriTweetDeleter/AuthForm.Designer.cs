namespace YuriTweetDeleter
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.textBoxConfirmationCode = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.Location = new System.Drawing.Point(12, 12);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(233, 30);
            this.buttonAuthorize.TabIndex = 0;
            this.buttonAuthorize.Text = "Authorize with Twitter";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAuthorize_Click);
            // 
            // textBoxConfirmationCode
            // 
            this.textBoxConfirmationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmationCode.Location = new System.Drawing.Point(12, 48);
            this.textBoxConfirmationCode.MaxLength = 12;
            this.textBoxConfirmationCode.Name = "textBoxConfirmationCode";
            this.textBoxConfirmationCode.Size = new System.Drawing.Size(233, 31);
            this.textBoxConfirmationCode.TabIndex = 1;
            this.textBoxConfirmationCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 84);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(233, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reset credentials";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 157);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxConfirmationCode);
            this.Controls.Add(this.buttonAuthorize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Text = "Authentication";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.AuthForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAuthorize;
        private System.Windows.Forms.TextBox textBoxConfirmationCode;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button3;
    }
}