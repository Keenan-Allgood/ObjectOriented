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
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboWaitList
            // 
            this.cboWaitList.FormattingEnabled = true;
            this.cboWaitList.Location = new System.Drawing.Point(13, 172);
            this.cboWaitList.Name = "cboWaitList";
            this.cboWaitList.Size = new System.Drawing.Size(290, 21);
            this.cboWaitList.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Size";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(111, 97);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(192, 20);
            this.txtSize.TabIndex = 4;
            // 
            // btnAddFromTxt
            // 
            this.btnAddFromTxt.Location = new System.Drawing.Point(77, 133);
            this.btnAddFromTxt.Name = "btnAddFromTxt";
            this.btnAddFromTxt.Size = new System.Drawing.Size(180, 23);
            this.btnAddFromTxt.TabIndex = 5;
            this.btnAddFromTxt.Text = "Add Group From Text Boxes";
            this.btnAddFromTxt.UseVisualStyleBackColor = true;
            this.btnAddFromTxt.Click += new System.EventHandler(this.btnAddFromTxt_Click);
            // 
            // btnAddFromWL
            // 
            this.btnAddFromWL.Location = new System.Drawing.Point(77, 206);
            this.btnAddFromWL.Name = "btnAddFromWL";
            this.btnAddFromWL.Size = new System.Drawing.Size(180, 23);
            this.btnAddFromWL.TabIndex = 6;
            this.btnAddFromWL.Text = "Add Group From Waitlist";
            this.btnAddFromWL.UseVisualStyleBackColor = true;
            this.btnAddFromWL.Click += new System.EventHandler(this.btnAddFromWL_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(13, 13);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(95, 13);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "SELECT SERVER";
            // 
            // cboServerList
            // 
            this.cboServerList.FormattingEnabled = true;
            this.cboServerList.Location = new System.Drawing.Point(110, 10);
            this.cboServerList.Name = "cboServerList";
            this.cboServerList.Size = new System.Drawing.Size(192, 21);
            this.cboServerList.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(125, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GroupToTableUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboServerList);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnAddFromWL);
            this.Controls.Add(this.btnAddFromTxt);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboWaitList);
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
        private System.Windows.Forms.Button btnCancel;
    }
}