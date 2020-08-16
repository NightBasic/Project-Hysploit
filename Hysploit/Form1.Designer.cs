namespace Exploit_Template_with_WRDAPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.inputScript = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.btnBtools = new System.Windows.Forms.Button();
            this.inputTPTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTPTo = new System.Windows.Forms.Button();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.txtIsInjected = new System.Windows.Forms.Label();
            this.InjectedChecker = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.8209F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROJECT HYSPLOIT";
            // 
            // inputScript
            // 
            this.inputScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.inputScript.Font = new System.Drawing.Font("Arial", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputScript.ForeColor = System.Drawing.SystemColors.Window;
            this.inputScript.Location = new System.Drawing.Point(10, 80);
            this.inputScript.Margin = new System.Windows.Forms.Padding(2);
            this.inputScript.Name = "inputScript";
            this.inputScript.Size = new System.Drawing.Size(505, 255);
            this.inputScript.TabIndex = 1;
            this.inputScript.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExecute.BackgroundImage")));
            this.btnExecute.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecute.ForeColor = System.Drawing.Color.White;
            this.btnExecute.Location = new System.Drawing.Point(10, 340);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(119, 41);
            this.btnExecute.TabIndex = 2;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // btnInject
            // 
            this.btnInject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInject.BackgroundImage")));
            this.btnInject.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInject.ForeColor = System.Drawing.Color.White;
            this.btnInject.Location = new System.Drawing.Point(689, 338);
            this.btnInject.Margin = new System.Windows.Forms.Padding(2);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(118, 41);
            this.btnInject.TabIndex = 3;
            this.btnInject.Text = "Attach";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.BtnInject_Click);
            // 
            // btnBtools
            // 
            this.btnBtools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBtools.BackgroundImage")));
            this.btnBtools.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBtools.ForeColor = System.Drawing.Color.White;
            this.btnBtools.Location = new System.Drawing.Point(534, 80);
            this.btnBtools.Margin = new System.Windows.Forms.Padding(2);
            this.btnBtools.Name = "btnBtools";
            this.btnBtools.Size = new System.Drawing.Size(118, 34);
            this.btnBtools.TabIndex = 4;
            this.btnBtools.Text = "BTools";
            this.btnBtools.UseVisualStyleBackColor = true;
            this.btnBtools.Click += new System.EventHandler(this.BtnBtools_Click);
            // 
            // inputTPTo
            // 
            this.inputTPTo.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTPTo.ForeColor = System.Drawing.Color.Gray;
            this.inputTPTo.Location = new System.Drawing.Point(298, 348);
            this.inputTPTo.Margin = new System.Windows.Forms.Padding(2);
            this.inputTPTo.Name = "inputTPTo";
            this.inputTPTo.Size = new System.Drawing.Size(118, 24);
            this.inputTPTo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(231, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Teleport";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTPTo
            // 
            this.btnTPTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTPTo.BackgroundImage")));
            this.btnTPTo.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTPTo.ForeColor = System.Drawing.Color.White;
            this.btnTPTo.Location = new System.Drawing.Point(419, 348);
            this.btnTPTo.Margin = new System.Windows.Forms.Padding(2);
            this.btnTPTo.Name = "btnTPTo";
            this.btnTPTo.Size = new System.Drawing.Size(40, 24);
            this.btnTPTo.TabIndex = 7;
            this.btnTPTo.Text = "GO";
            this.btnTPTo.UseVisualStyleBackColor = true;
            this.btnTPTo.Click += new System.EventHandler(this.BtnTPTo_Click);
            // 
            // btnSpeed
            // 
            this.btnSpeed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeed.BackgroundImage")));
            this.btnSpeed.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeed.ForeColor = System.Drawing.Color.White;
            this.btnSpeed.Location = new System.Drawing.Point(534, 118);
            this.btnSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(118, 34);
            this.btnSpeed.TabIndex = 8;
            this.btnSpeed.Text = "Fast Walk";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.BtnSpeed_Click);
            // 
            // txtIsInjected
            // 
            this.txtIsInjected.AutoSize = true;
            this.txtIsInjected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsInjected.ForeColor = System.Drawing.Color.White;
            this.txtIsInjected.Location = new System.Drawing.Point(682, 10);
            this.txtIsInjected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIsInjected.Name = "txtIsInjected";
            this.txtIsInjected.Size = new System.Drawing.Size(125, 20);
            this.txtIsInjected.TabIndex = 9;
            this.txtIsInjected.Text = "Is Injected: false";
            this.txtIsInjected.Click += new System.EventHandler(this.txtIsInjected_Click);
            // 
            // InjectedChecker
            // 
            this.InjectedChecker.Enabled = true;
            this.InjectedChecker.Interval = 3000;
            this.InjectedChecker.Tick += new System.EventHandler(this.InjectedChecker_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8209F);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(293, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Made By: Yutsuソ®™#8391";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.8209F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(560, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "TOOLS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(534, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Suicide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(534, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "ESP On/Off";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(534, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Float off";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(534, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 34);
            this.button4.TabIndex = 17;
            this.button4.Text = "Float on";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(685, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 34);
            this.button5.TabIndex = 18;
            this.button5.Text = "WeAreDevs";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(686, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 34);
            this.button6.TabIndex = 19;
            this.button6.Text = "Join the discord";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.8209F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(717, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "LINKS";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(685, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 34);
            this.button7.TabIndex = 21;
            this.button7.Text = "FAQ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(815, 383);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsInjected);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.btnTPTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTPTo);
            this.Controls.Add(this.btnBtools);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.inputScript);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Project Hyploit 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputScript;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnBtools;
        private System.Windows.Forms.TextBox inputTPTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTPTo;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Label txtIsInjected;
        private System.Windows.Forms.Timer InjectedChecker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
    }
}

