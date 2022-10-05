namespace Role
{
    partial class Register
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
            this.signup_button = new System.Windows.Forms.Button();
            this.reg_passwd = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.Location = new System.Drawing.Point(524, 234);
            this.signup_button.Margin = new System.Windows.Forms.Padding(4);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(151, 53);
            this.signup_button.TabIndex = 16;
            this.signup_button.Text = "SIGN UP";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // reg_passwd
            // 
            this.reg_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_passwd.Location = new System.Drawing.Point(288, 155);
            this.reg_passwd.Margin = new System.Windows.Forms.Padding(4);
            this.reg_passwd.Name = "reg_passwd";
            this.reg_passwd.Size = new System.Drawing.Size(387, 37);
            this.reg_passwd.TabIndex = 14;
            // 
            // reg_username
            // 
            this.reg_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_username.Location = new System.Drawing.Point(288, 104);
            this.reg_username.Margin = new System.Windows.Forms.Padding(4);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(387, 37);
            this.reg_username.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "User Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.reg_passwd);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.TextBox reg_passwd;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}