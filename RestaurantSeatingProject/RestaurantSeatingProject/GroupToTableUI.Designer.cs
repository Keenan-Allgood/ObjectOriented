namespace RestaurantSeatingProject
{
    partial class GroupToTableUI
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
            this.cboWaitList = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.btnAddFromTxt = new System.Windows.Forms.Button();
            this.btnAddFromWL = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.cboServerList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboWaitList
            // 
            this.cboWaitList.FormattingEnabled = true;
            this.cboWaitList.Location = new System.Drawing.Point(24, 318);
            this.cboWaitList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboWaitList.Name = "cboWaitList";
            this.cboWaitList.Size = new System.Drawing.Size(528, 32);
            this.cboWaitList.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Size";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(349, 29);
            this.txtName.TabIndex = 3;
            this.txtName.Tag = "Group Name";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(204, 179);
            this.txtSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(349, 29);
            this.txtSize.TabIndex = 4;
            this.txtSize.Tag = "Group Size";
            // 
            // btnAddFromTxt
            // 
            this.btnAddFromTxt.Location = new System.Drawing.Point(141, 246);
            this.btnAddFromTxt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddFromTxt.Name = "btnAddFromTxt";
            this.btnAddFromTxt.Size = new System.Drawing.Size(330, 42);
            this.btnAddFromTxt.TabIndex = 5;
            this.btnAddFromTxt.Text = "Add Group From Text Boxes";
            this.btnAddFromTxt.UseVisualStyleBackColor = true;
            this.btnAddFromTxt.Click += new System.EventHandler(this.btnAddFromTxt_Click);
            // 
            // btnAddFromWL
            // 
            this.btnAddFromWL.Location = new System.Drawing.Point(141, 380);
            this.btnAddFromWL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAddFromWL.Name = "btnAddFromWL";
            this.btnAddFromWL.Size = new System.Drawing.Size(330, 42);
            this.btnAddFromWL.TabIndex = 6;
            this.btnAddFromWL.Text = "Add Group From Waitlist";
            this.btnAddFromWL.UseVisualStyleBackColor = true;
            this.btnAddFromWL.Click += new System.EventHandler(this.btnAddFromWL_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(24, 24);
            this.lblServer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(176, 25);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "SELECT SERVER";
            // 
            // cboServerList
            // 
            this.cboServerList.FormattingEnabled = true;
            this.cboServerList.Location = new System.Drawing.Point(202, 18);
            this.cboServerList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboServerList.Name = "cboServerList";
            this.cboServerList.Size = new System.Drawing.Size(349, 32);
            this.cboServerList.TabIndex = 8;
            this.cboServerList.Tag = "Server List";
            // 
            // GroupToTableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 454);
            this.Controls.Add(this.cboServerList);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnAddFromWL);
            this.Controls.Add(this.btnAddFromTxt);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboWaitList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GroupToTableUI";
            this.Text = "GroupToTableUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboWaitList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAddFromTxt;
        private System.Windows.Forms.Button btnAddFromWL;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cboServerList;
    }
}