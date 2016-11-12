namespace RestaurantSeatingProject
{
    partial class GUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHost = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.hbtnRemoveGroup = new System.Windows.Forms.Button();
            this.hbtnAddGroup = new System.Windows.Forms.Button();
            this.hcmobTableList = new System.Windows.Forms.ComboBox();
            this.btnAddWaitGroup = new System.Windows.Forms.Button();
            this.htxtGroupSize = new System.Windows.Forms.TextBox();
            this.htxtGroupName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.hbtnRemoveFromWaitlist = new System.Windows.Forms.Button();
            this.hcboWaitList = new System.Windows.Forms.ComboBox();
            this.lblWaitList = new System.Windows.Forms.Label();
            this.hbtnAddServer = new System.Windows.Forms.Button();
            this.htxtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.hcboServerList = new System.Windows.Forms.ComboBox();
            this.lblServerList = new System.Windows.Forms.Label();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.btnRemoveTableInfo = new System.Windows.Forms.Button();
            this.btnModifyTableInfo = new System.Windows.Forms.Button();
            this.btnAddTableInfo = new System.Windows.Forms.Button();
            this.cboTableList = new System.Windows.Forms.ComboBox();
            this.lblTableList = new System.Windows.Forms.Label();
            this.cboRestaurant = new System.Windows.Forms.ComboBox();
            this.btnCreateLayout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabHost.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHost);
            this.tabControl.Controls.Add(this.tabManager);
            this.tabControl.Location = new System.Drawing.Point(22, 89);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1767, 1050);
            this.tabControl.TabIndex = 0;
            // 
            // tabHost
            // 
            this.tabHost.BackColor = System.Drawing.Color.Transparent;
            this.tabHost.Controls.Add(this.label1);
            this.tabHost.Controls.Add(this.hbtnRemoveGroup);
            this.tabHost.Controls.Add(this.hbtnAddGroup);
            this.tabHost.Controls.Add(this.hcmobTableList);
            this.tabHost.Controls.Add(this.btnAddWaitGroup);
            this.tabHost.Controls.Add(this.htxtGroupSize);
            this.tabHost.Controls.Add(this.htxtGroupName);
            this.tabHost.Controls.Add(this.lblSize);
            this.tabHost.Controls.Add(this.lblName);
            this.tabHost.Controls.Add(this.hbtnRemoveFromWaitlist);
            this.tabHost.Controls.Add(this.hcboWaitList);
            this.tabHost.Controls.Add(this.lblWaitList);
            this.tabHost.Controls.Add(this.hbtnAddServer);
            this.tabHost.Controls.Add(this.htxtServerName);
            this.tabHost.Controls.Add(this.lblServerName);
            this.tabHost.Controls.Add(this.hcboServerList);
            this.tabHost.Controls.Add(this.lblServerList);
            this.tabHost.Location = new System.Drawing.Point(4, 33);
            this.tabHost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabHost.Name = "tabHost";
            this.tabHost.Size = new System.Drawing.Size(1759, 1013);
            this.tabHost.TabIndex = 0;
            this.tabHost.Text = "HOST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Table List";
            // 
            // hbtnRemoveGroup
            // 
            this.hbtnRemoveGroup.Location = new System.Drawing.Point(1084, 188);
            this.hbtnRemoveGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hbtnRemoveGroup.Name = "hbtnRemoveGroup";
            this.hbtnRemoveGroup.Size = new System.Drawing.Size(207, 52);
            this.hbtnRemoveGroup.TabIndex = 27;
            this.hbtnRemoveGroup.Text = "Remove Group";
            this.hbtnRemoveGroup.UseVisualStyleBackColor = true;
            this.hbtnRemoveGroup.Click += new System.EventHandler(this.hbtnRemoveGroup_Click);
            // 
            // hbtnAddGroup
            // 
            this.hbtnAddGroup.Location = new System.Drawing.Point(821, 188);
            this.hbtnAddGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hbtnAddGroup.Name = "hbtnAddGroup";
            this.hbtnAddGroup.Size = new System.Drawing.Size(185, 52);
            this.hbtnAddGroup.TabIndex = 25;
            this.hbtnAddGroup.Text = "Add Group";
            this.hbtnAddGroup.UseVisualStyleBackColor = true;
            this.hbtnAddGroup.Click += new System.EventHandler(this.hbtnAddGroup_Click);
            // 
            // hcmobTableList
            // 
            this.hcmobTableList.FormattingEnabled = true;
            this.hcmobTableList.Location = new System.Drawing.Point(81, 201);
            this.hcmobTableList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hcmobTableList.Name = "hcmobTableList";
            this.hcmobTableList.Size = new System.Drawing.Size(697, 32);
            this.hcmobTableList.TabIndex = 24;
            // 
            // btnAddWaitGroup
            // 
            this.btnAddWaitGroup.Location = new System.Drawing.Point(1496, 958);
            this.btnAddWaitGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddWaitGroup.Name = "btnAddWaitGroup";
            this.btnAddWaitGroup.Size = new System.Drawing.Size(123, 41);
            this.btnAddWaitGroup.TabIndex = 15;
            this.btnAddWaitGroup.Text = "Add Group";
            this.btnAddWaitGroup.UseVisualStyleBackColor = true;
            this.btnAddWaitGroup.Click += new System.EventHandler(this.btnAddWaitGroup_Click);
            // 
            // htxtGroupSize
            // 
            this.htxtGroupSize.Location = new System.Drawing.Point(1604, 929);
            this.htxtGroupSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htxtGroupSize.Name = "htxtGroupSize";
            this.htxtGroupSize.Size = new System.Drawing.Size(121, 29);
            this.htxtGroupSize.TabIndex = 14;
            // 
            // htxtGroupName
            // 
            this.htxtGroupName.Location = new System.Drawing.Point(1421, 929);
            this.htxtGroupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htxtGroupName.Name = "htxtGroupName";
            this.htxtGroupName.Size = new System.Drawing.Size(121, 29);
            this.htxtGroupName.TabIndex = 13;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(1606, 888);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 25);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "Size";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1415, 888);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // hbtnRemoveFromWaitlist
            // 
            this.hbtnRemoveFromWaitlist.Location = new System.Drawing.Point(1612, 652);
            this.hbtnRemoveFromWaitlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hbtnRemoveFromWaitlist.Name = "hbtnRemoveFromWaitlist";
            this.hbtnRemoveFromWaitlist.Size = new System.Drawing.Size(116, 46);
            this.hbtnRemoveFromWaitlist.TabIndex = 10;
            this.hbtnRemoveFromWaitlist.Text = "Remove";
            this.hbtnRemoveFromWaitlist.UseVisualStyleBackColor = true;
            this.hbtnRemoveFromWaitlist.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // hcboWaitList
            // 
            this.hcboWaitList.FormattingEnabled = true;
            this.hcboWaitList.Location = new System.Drawing.Point(1421, 665);
            this.hcboWaitList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hcboWaitList.Name = "hcboWaitList";
            this.hcboWaitList.Size = new System.Drawing.Size(147, 32);
            this.hcboWaitList.TabIndex = 9;
            // 
            // lblWaitList
            // 
            this.lblWaitList.AutoSize = true;
            this.lblWaitList.Location = new System.Drawing.Point(1483, 593);
            this.lblWaitList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaitList.Name = "lblWaitList";
            this.lblWaitList.Size = new System.Drawing.Size(87, 25);
            this.lblWaitList.TabIndex = 8;
            this.lblWaitList.Text = "Wait List";
            // 
            // hbtnAddServer
            // 
            this.hbtnAddServer.Location = new System.Drawing.Point(1483, 438);
            this.hbtnAddServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hbtnAddServer.Name = "hbtnAddServer";
            this.hbtnAddServer.Size = new System.Drawing.Size(136, 35);
            this.hbtnAddServer.TabIndex = 7;
            this.hbtnAddServer.Text = "Add Server";
            this.hbtnAddServer.UseVisualStyleBackColor = true;
            this.hbtnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // htxtServerName
            // 
            this.htxtServerName.Location = new System.Drawing.Point(1483, 384);
            this.htxtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.htxtServerName.Name = "htxtServerName";
            this.htxtServerName.Size = new System.Drawing.Size(121, 29);
            this.htxtServerName.TabIndex = 6;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(1478, 342);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(127, 25);
            this.lblServerName.TabIndex = 5;
            this.lblServerName.Text = "Server Name";
            // 
            // hcboServerList
            // 
            this.hcboServerList.FormattingEnabled = true;
            this.hcboServerList.Location = new System.Drawing.Point(1483, 114);
            this.hcboServerList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hcboServerList.Name = "hcboServerList";
            this.hcboServerList.Size = new System.Drawing.Size(147, 32);
            this.hcboServerList.TabIndex = 4;
            // 
            // lblServerList
            // 
            this.lblServerList.AutoSize = true;
            this.lblServerList.Location = new System.Drawing.Point(1478, 65);
            this.lblServerList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerList.Name = "lblServerList";
            this.lblServerList.Size = new System.Drawing.Size(105, 25);
            this.lblServerList.TabIndex = 3;
            this.lblServerList.Text = "Server List";
            // 
            // tabManager
            // 
            this.tabManager.Controls.Add(this.btnRemoveTableInfo);
            this.tabManager.Controls.Add(this.btnModifyTableInfo);
            this.tabManager.Controls.Add(this.btnAddTableInfo);
            this.tabManager.Controls.Add(this.cboTableList);
            this.tabManager.Controls.Add(this.lblTableList);
            this.tabManager.Location = new System.Drawing.Point(4, 33);
            this.tabManager.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(1759, 1013);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "MANAGER";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTableInfo
            // 
            this.btnRemoveTableInfo.Location = new System.Drawing.Point(1164, 131);
            this.btnRemoveTableInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveTableInfo.Name = "btnRemoveTableInfo";
            this.btnRemoveTableInfo.Size = new System.Drawing.Size(103, 52);
            this.btnRemoveTableInfo.TabIndex = 23;
            this.btnRemoveTableInfo.Text = "Remove";
            this.btnRemoveTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnModifyTableInfo
            // 
            this.btnModifyTableInfo.Location = new System.Drawing.Point(1045, 131);
            this.btnModifyTableInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModifyTableInfo.Name = "btnModifyTableInfo";
            this.btnModifyTableInfo.Size = new System.Drawing.Size(95, 52);
            this.btnModifyTableInfo.TabIndex = 22;
            this.btnModifyTableInfo.Text = "Modify";
            this.btnModifyTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddTableInfo
            // 
            this.btnAddTableInfo.Location = new System.Drawing.Point(928, 131);
            this.btnAddTableInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTableInfo.Name = "btnAddTableInfo";
            this.btnAddTableInfo.Size = new System.Drawing.Size(97, 52);
            this.btnAddTableInfo.TabIndex = 21;
            this.btnAddTableInfo.Text = "Add";
            this.btnAddTableInfo.UseVisualStyleBackColor = true;
            // 
            // cboTableList
            // 
            this.cboTableList.FormattingEnabled = true;
            this.cboTableList.Location = new System.Drawing.Point(57, 129);
            this.cboTableList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTableList.Name = "cboTableList";
            this.cboTableList.Size = new System.Drawing.Size(697, 32);
            this.cboTableList.TabIndex = 20;
            // 
            // lblTableList
            // 
            this.lblTableList.AutoSize = true;
            this.lblTableList.Location = new System.Drawing.Point(51, 72);
            this.lblTableList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableList.Name = "lblTableList";
            this.lblTableList.Size = new System.Drawing.Size(97, 25);
            this.lblTableList.TabIndex = 19;
            this.lblTableList.Text = "Table List";
            // 
            // cboRestaurant
            // 
            this.cboRestaurant.FormattingEnabled = true;
            this.cboRestaurant.Location = new System.Drawing.Point(72, 30);
            this.cboRestaurant.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboRestaurant.Name = "cboRestaurant";
            this.cboRestaurant.Size = new System.Drawing.Size(453, 32);
            this.cboRestaurant.TabIndex = 1;
            // 
            // btnCreateLayout
            // 
            this.btnCreateLayout.Location = new System.Drawing.Point(618, 30);
            this.btnCreateLayout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateLayout.Name = "btnCreateLayout";
            this.btnCreateLayout.Size = new System.Drawing.Size(220, 44);
            this.btnCreateLayout.TabIndex = 2;
            this.btnCreateLayout.Text = "Create Layout";
            this.btnCreateLayout.UseVisualStyleBackColor = true;
            this.btnCreateLayout.Click += new System.EventHandler(this.btnCreateLayout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(904, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Layout";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1887, 1163);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateLayout);
            this.Controls.Add(this.cboRestaurant);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GUI";
            this.Text = "HostUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHost.ResumeLayout(false);
            this.tabHost.PerformLayout();
            this.tabManager.ResumeLayout(false);
            this.tabManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHost;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.ComboBox cboRestaurant;
        private System.Windows.Forms.Button btnCreateLayout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddWaitGroup;
        private System.Windows.Forms.TextBox htxtGroupSize;
        private System.Windows.Forms.TextBox htxtGroupName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button hbtnRemoveFromWaitlist;
        private System.Windows.Forms.ComboBox hcboWaitList;
        private System.Windows.Forms.Label lblWaitList;
        private System.Windows.Forms.Button hbtnAddServer;
        private System.Windows.Forms.TextBox htxtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox hcboServerList;
        private System.Windows.Forms.Label lblServerList;
        private System.Windows.Forms.Button btnRemoveTableInfo;
        private System.Windows.Forms.Button btnModifyTableInfo;
        private System.Windows.Forms.Button btnAddTableInfo;
        private System.Windows.Forms.ComboBox cboTableList;
        private System.Windows.Forms.Label lblTableList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hbtnRemoveGroup;
        private System.Windows.Forms.Button hbtnAddGroup;
        private System.Windows.Forms.ComboBox hcmobTableList;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}