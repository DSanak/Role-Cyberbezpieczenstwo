namespace Role
{
    partial class Managment
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
            this.bt_userList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_blockUser = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_restrictionOff = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.list_day = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_userList
            // 
            this.bt_userList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_userList.Location = new System.Drawing.Point(514, 12);
            this.bt_userList.Margin = new System.Windows.Forms.Padding(4);
            this.bt_userList.Name = "bt_userList";
            this.bt_userList.Size = new System.Drawing.Size(185, 56);
            this.bt_userList.TabIndex = 5;
            this.bt_userList.Text = "User list";
            this.bt_userList.UseVisualStyleBackColor = true;
            this.bt_userList.Click += new System.EventHandler(this.bt_userList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(481, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_blockUser
            // 
            this.btn_blockUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_blockUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blockUser.Location = new System.Drawing.Point(12, 273);
            this.btn_blockUser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_blockUser.Name = "btn_blockUser";
            this.btn_blockUser.Size = new System.Drawing.Size(151, 56);
            this.btn_blockUser.TabIndex = 13;
            this.btn_blockUser.Text = "Block";
            this.btn_blockUser.UseVisualStyleBackColor = true;
            this.btn_blockUser.Click += new System.EventHandler(this.btn_blockUser_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(171, 273);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 56);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_restrictionOff
            // 
            this.btn_restrictionOff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_restrictionOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restrictionOff.Location = new System.Drawing.Point(330, 273);
            this.btn_restrictionOff.Margin = new System.Windows.Forms.Padding(4);
            this.btn_restrictionOff.Name = "btn_restrictionOff";
            this.btn_restrictionOff.Size = new System.Drawing.Size(177, 56);
            this.btn_restrictionOff.TabIndex = 15;
            this.btn_restrictionOff.Text = "Off restriction";
            this.btn_restrictionOff.UseVisualStyleBackColor = true;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(171, 178);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(59, 22);
            this.idtxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type ID user to modify";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 77);
            this.button1.TabIndex = 18;
            this.button1.Text = "Set day to password expires";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list_day
            // 
            this.list_day.FormattingEnabled = true;
            this.list_day.ItemHeight = 16;
            this.list_day.Items.AddRange(new object[] {
            "5",
            "10",
            "30"});
            this.list_day.Location = new System.Drawing.Point(290, 353);
            this.list_day.Name = "list_day";
            this.list_day.Size = new System.Drawing.Size(120, 84);
            this.list_day.TabIndex = 19;
            // 
            // Managment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_day);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.btn_restrictionOff);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_blockUser);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_userList);
            this.Name = "Managment";
            this.Text = "Managment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_userList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_blockUser;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_restrictionOff;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list_day;
    }
}