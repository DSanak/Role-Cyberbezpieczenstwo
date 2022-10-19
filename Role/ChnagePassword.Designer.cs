namespace Role
{
    partial class ChnagePassword
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
            this.txtAdminPass2 = new System.Windows.Forms.TextBox();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdminPass2
            // 
            this.txtAdminPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass2.Location = new System.Drawing.Point(242, 86);
            this.txtAdminPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPass2.Name = "txtAdminPass2";
            this.txtAdminPass2.Size = new System.Drawing.Size(254, 37);
            this.txtAdminPass2.TabIndex = 12;
            this.txtAdminPass2.UseSystemPasswordChar = true;
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPass.Location = new System.Drawing.Point(242, 41);
            this.txtAdminPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.Size = new System.Drawing.Size(254, 37);
            this.txtAdminPass.TabIndex = 11;
            this.txtAdminPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repet password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // btnConfirmPass
            // 
            this.btnConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPass.Location = new System.Drawing.Point(139, 170);
            this.btnConfirmPass.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmPass.Name = "btnConfirmPass";
            this.btnConfirmPass.Size = new System.Drawing.Size(190, 56);
            this.btnConfirmPass.TabIndex = 13;
            this.btnConfirmPass.Text = "GO!";
            this.btnConfirmPass.UseVisualStyleBackColor = true;
            this.btnConfirmPass.Click += new System.EventHandler(this.btnConfirmPass_Click);
            // 
            // ChnagePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 271);
            this.Controls.Add(this.btnConfirmPass);
            this.Controls.Add(this.txtAdminPass2);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChnagePassword";
            this.Text = "ChnagePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdminPass2;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmPass;
    }
}