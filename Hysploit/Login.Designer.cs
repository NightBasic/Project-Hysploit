namespace Hysploit
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonregister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonlogin.BackgroundImage")));
            this.buttonlogin.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(14, 118);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(118, 41);
            this.buttonlogin.TabIndex = 37;
            this.buttonlogin.Text = "Login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonregister
            // 
            this.buttonregister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonregister.BackgroundImage")));
            this.buttonregister.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonregister.ForeColor = System.Drawing.Color.White;
            this.buttonregister.Location = new System.Drawing.Point(136, 118);
            this.buttonregister.Margin = new System.Windows.Forms.Padding(2);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(118, 41);
            this.buttonregister.TabIndex = 38;
            this.buttonregister.Text = "Register";
            this.buttonregister.UseVisualStyleBackColor = true;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 27);
            this.label1.TabIndex = 39;
            this.label1.Text = "PROJECT HYSPLOIT";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 48);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(245, 20);
            this.username.TabIndex = 40;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 83);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(245, 20);
            this.password.TabIndex = 41;
            this.password.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(268, 173);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.buttonlogin);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}