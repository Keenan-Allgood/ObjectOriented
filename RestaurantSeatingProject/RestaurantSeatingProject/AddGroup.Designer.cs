namespace RestaurantSeatingProject
{
    partial class AddGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.lblGroupWait = new System.Windows.Forms.Label();
            this.cboWaitlistGroup = new System.Windows.Forms.ComboBox();
            this.cboServerWaitlist = new System.Windows.Forms.ComboBox();
            this.lblServerWaitlist = new System.Windows.Forms.Label();
            this.btnAddWaitgroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name:";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(327, 105);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(100, 29);
            this.txtGroupName.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(133, 191);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(57, 25);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(327, 191);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 29);
            this.txtSize.TabIndex = 3;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(133, 276);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(76, 25);
            this.lblServer.TabIndex = 4;
            this.lblServer.Text = "Server:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(225, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 40);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 33);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(327, 276);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(121, 32);
            this.cboServer.TabIndex = 8;
            // 
            // lblGroupWait
            // 
            this.lblGroupWait.AutoSize = true;
            this.lblGroupWait.Location = new System.Drawing.Point(133, 427);
            this.lblGroupWait.Name = "lblGroupWait";
            this.lblGroupWait.Size = new System.Drawing.Size(129, 25);
            this.lblGroupWait.TabIndex = 9;
            this.lblGroupWait.Text = "Group Name:";
            // 
            // cboWaitlistGroup
            // 
            this.cboWaitlistGroup.FormattingEnabled = true;
            this.cboWaitlistGroup.Location = new System.Drawing.Point(327, 424);
            this.cboWaitlistGroup.Name = "cboWaitlistGroup";
            this.cboWaitlistGroup.Size = new System.Drawing.Size(121, 32);
            this.cboWaitlistGroup.TabIndex = 10;
            // 
            // cboServerWaitlist
            // 
            this.cboServerWaitlist.FormattingEnabled = true;
            this.cboServerWaitlist.Location = new System.Drawing.Point(327, 478);
            this.cboServerWaitlist.Name = "cboServerWaitlist";
            this.cboServerWaitlist.Size = new System.Drawing.Size(121, 32);
            this.cboServerWaitlist.TabIndex = 12;
            // 
            // lblServerWaitlist
            // 
            this.lblServerWaitlist.AutoSize = true;
            this.lblServerWaitlist.Location = new System.Drawing.Point(133, 478);
            this.lblServerWaitlist.Name = "lblServerWaitlist";
            this.lblServerWaitlist.Size = new System.Drawing.Size(76, 25);
            this.lblServerWaitlist.TabIndex = 11;
            this.lblServerWaitlist.Text = "Server:";
            // 
            // btnAddWaitgroup
            // 
            this.btnAddWaitgroup.Location = new System.Drawing.Point(225, 563);
            this.btnAddWaitgroup.Name = "btnAddWaitgroup";
            this.btnAddWaitgroup.Size = new System.Drawing.Size(117, 40);
            this.btnAddWaitgroup.TabIndex = 13;
            this.btnAddWaitgroup.Text = "Add";
            this.btnAddWaitgroup.UseVisualStyleBackColor = true;
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 641);
            this.Controls.Add(this.btnAddWaitgroup);
            this.Controls.Add(this.cboServerWaitlist);
            this.Controls.Add(this.lblServerWaitlist);
            this.Controls.Add(this.cboWaitlistGroup);
            this.Controls.Add(this.lblGroupWait);
            this.Controls.Add(this.cboServer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label lblGroupWait;
        private System.Windows.Forms.ComboBox cboWaitlistGroup;
        private System.Windows.Forms.ComboBox cboServerWaitlist;
        private System.Windows.Forms.Label lblServerWaitlist;
        private System.Windows.Forms.Button btnAddWaitgroup;
    }
}