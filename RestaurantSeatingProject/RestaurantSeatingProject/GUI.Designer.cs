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
            this.hcboTableList = new System.Windows.Forms.ComboBox();
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
            this.tabControl.Location = new System.Drawing.Point(12, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 569);
            this.tabControl.TabIndex = 0;
            // 
            // tabHost
            // 
            this.tabHost.BackColor = System.Drawing.Color.Transparent;
            this.tabHost.Controls.Add(this.label1);
            this.tabHost.Controls.Add(this.hbtnRemoveGroup);
            this.tabHost.Controls.Add(this.hbtnAddGroup);
            this.tabHost.Controls.Add(this.hcboTableList);
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
            this.tabHost.Location = new System.Drawing.Point(4, 22);
            this.tabHost.Name = "tabHost";
            this.tabHost.Size = new System.Drawing.Size(956, 543);
            this.tabHost.TabIndex = 0;
            this.tabHost.Text = "HOST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Table List";
            // 
            // hbtnRemoveGroup
            // 
            this.hbtnRemoveGroup.Location = new System.Drawing.Point(591, 102);
            this.hbtnRemoveGroup.Margin = new System.Windows.Forms.Padding(2);
            this.hbtnRemoveGroup.Name = "hbtnRemoveGroup";
            this.hbtnRemoveGroup.Size = new System.Drawing.Size(113, 28);
            this.hbtnRemoveGroup.TabIndex = 27;
            this.hbtnRemoveGroup.Text = "Remove Group";
            this.hbtnRemoveGroup.UseVisualStyleBackColor = true;
            this.hbtnRemoveGroup.Click += new System.EventHandler(this.hbtnRemoveGroup_Click);
            // 
            // hbtnAddGroup
            // 
            this.hbtnAddGroup.Location = new System.Drawing.Point(448, 102);
            this.hbtnAddGroup.Margin = new System.Windows.Forms.Padding(2);
            this.hbtnAddGroup.Name = "hbtnAddGroup";
            this.hbtnAddGroup.Size = new System.Drawing.Size(101, 28);
            this.hbtnAddGroup.TabIndex = 25;
            this.hbtnAddGroup.Text = "Add Group";
            this.hbtnAddGroup.UseVisualStyleBackColor = true;
            // 
            // hcboTableList
            // 
            this.hcboTableList.FormattingEnabled = true;
            this.hcboTableList.Location = new System.Drawing.Point(44, 109);
            this.hcboTableList.Margin = new System.Windows.Forms.Padding(2);
            this.hcboTableList.Name = "hcboTableList";
            this.hcboTableList.Size = new System.Drawing.Size(382, 21);
            this.hcboTableList.TabIndex = 24;
            // 
            // btnAddWaitGroup
            // 
            this.btnAddWaitGroup.Location = new System.Drawing.Point(816, 519);
            this.btnAddWaitGroup.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddWaitGroup.Name = "btnAddWaitGroup";
            this.btnAddWaitGroup.Size = new System.Drawing.Size(67, 22);
            this.btnAddWaitGroup.TabIndex = 15;
            this.btnAddWaitGroup.Text = "Add Group";
            this.btnAddWaitGroup.UseVisualStyleBackColor = true;
            this.btnAddWaitGroup.Click += new System.EventHandler(this.btnAddWaitGroup_Click);
            // 
            // htxtGroupSize
            // 
            this.htxtGroupSize.Location = new System.Drawing.Point(875, 503);
            this.htxtGroupSize.Margin = new System.Windows.Forms.Padding(2);
            this.htxtGroupSize.Name = "htxtGroupSize";
            this.htxtGroupSize.Size = new System.Drawing.Size(68, 20);
            this.htxtGroupSize.TabIndex = 14;
            // 
            // htxtGroupName
            // 
            this.htxtGroupName.Location = new System.Drawing.Point(775, 503);
            this.htxtGroupName.Margin = new System.Windows.Forms.Padding(2);
            this.htxtGroupName.Name = "htxtGroupName";
            this.htxtGroupName.Size = new System.Drawing.Size(68, 20);
            this.htxtGroupName.TabIndex = 13;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(876, 481);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "Size";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(772, 481);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // hbtnRemoveFromWaitlist
            // 
            this.hbtnRemoveFromWaitlist.Location = new System.Drawing.Point(879, 353);
            this.hbtnRemoveFromWaitlist.Margin = new System.Windows.Forms.Padding(2);
            this.hbtnRemoveFromWaitlist.Name = "hbtnRemoveFromWaitlist";
            this.hbtnRemoveFromWaitlist.Size = new System.Drawing.Size(63, 25);
            this.hbtnRemoveFromWaitlist.TabIndex = 10;
            this.hbtnRemoveFromWaitlist.Text = "Remove";
            this.hbtnRemoveFromWaitlist.UseVisualStyleBackColor = true;
            this.hbtnRemoveFromWaitlist.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // hcboWaitList
            // 
            this.hcboWaitList.FormattingEnabled = true;
            this.hcboWaitList.Location = new System.Drawing.Point(775, 360);
            this.hcboWaitList.Margin = new System.Windows.Forms.Padding(2);
            this.hcboWaitList.Name = "hcboWaitList";
            this.hcboWaitList.Size = new System.Drawing.Size(82, 21);
            this.hcboWaitList.TabIndex = 9;
            // 
            // lblWaitList
            // 
            this.lblWaitList.AutoSize = true;
            this.lblWaitList.Location = new System.Drawing.Point(809, 321);
            this.lblWaitList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitList.Name = "lblWaitList";
            this.lblWaitList.Size = new System.Drawing.Size(48, 13);
            this.lblWaitList.TabIndex = 8;
            this.lblWaitList.Text = "Wait List";
            // 
            // hbtnAddServer
            // 
            this.hbtnAddServer.Location = new System.Drawing.Point(809, 237);
            this.hbtnAddServer.Margin = new System.Windows.Forms.Padding(2);
            this.hbtnAddServer.Name = "hbtnAddServer";
            this.hbtnAddServer.Size = new System.Drawing.Size(74, 19);
            this.hbtnAddServer.TabIndex = 7;
            this.hbtnAddServer.Text = "Add Server";
            this.hbtnAddServer.UseVisualStyleBackColor = true;
            this.hbtnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // htxtServerName
            // 
            this.htxtServerName.Location = new System.Drawing.Point(809, 208);
            this.htxtServerName.Margin = new System.Windows.Forms.Padding(2);
            this.htxtServerName.Name = "htxtServerName";
            this.htxtServerName.Size = new System.Drawing.Size(68, 20);
            this.htxtServerName.TabIndex = 6;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(806, 185);
            this.lblServerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(69, 13);
            this.lblServerName.TabIndex = 5;
            this.lblServerName.Text = "Server Name";
            // 
            // hcboServerList
            // 
            this.hcboServerList.FormattingEnabled = true;
            this.hcboServerList.Location = new System.Drawing.Point(809, 62);
            this.hcboServerList.Margin = new System.Windows.Forms.Padding(2);
            this.hcboServerList.Name = "hcboServerList";
            this.hcboServerList.Size = new System.Drawing.Size(82, 21);
            this.hcboServerList.TabIndex = 4;
            // 
            // lblServerList
            // 
            this.lblServerList.AutoSize = true;
            this.lblServerList.Location = new System.Drawing.Point(806, 35);
            this.lblServerList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServerList.Name = "lblServerList";
            this.lblServerList.Size = new System.Drawing.Size(57, 13);
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
            this.tabManager.Location = new System.Drawing.Point(4, 22);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(956, 543);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "MANAGER";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTableInfo
            // 
            this.btnRemoveTableInfo.Location = new System.Drawing.Point(635, 71);
            this.btnRemoveTableInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTableInfo.Name = "btnRemoveTableInfo";
            this.btnRemoveTableInfo.Size = new System.Drawing.Size(56, 28);
            this.btnRemoveTableInfo.TabIndex = 23;
            this.btnRemoveTableInfo.Text = "Remove";
            this.btnRemoveTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnModifyTableInfo
            // 
            this.btnModifyTableInfo.Location = new System.Drawing.Point(570, 71);
            this.btnModifyTableInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyTableInfo.Name = "btnModifyTableInfo";
            this.btnModifyTableInfo.Size = new System.Drawing.Size(52, 28);
            this.btnModifyTableInfo.TabIndex = 22;
            this.btnModifyTableInfo.Text = "Modify";
            this.btnModifyTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddTableInfo
            // 
            this.btnAddTableInfo.Location = new System.Drawing.Point(506, 71);
            this.btnAddTableInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTableInfo.Name = "btnAddTableInfo";
            this.btnAddTableInfo.Size = new System.Drawing.Size(53, 28);
            this.btnAddTableInfo.TabIndex = 21;
            this.btnAddTableInfo.Text = "Add";
            this.btnAddTableInfo.UseVisualStyleBackColor = true;
            // 
            // cboTableList
            // 
            this.cboTableList.FormattingEnabled = true;
            this.cboTableList.Location = new System.Drawing.Point(31, 70);
            this.cboTableList.Margin = new System.Windows.Forms.Padding(2);
            this.cboTableList.Name = "cboTableList";
            this.cboTableList.Size = new System.Drawing.Size(382, 21);
            this.cboTableList.TabIndex = 20;
            // 
            // lblTableList
            // 
            this.lblTableList.AutoSize = true;
            this.lblTableList.Location = new System.Drawing.Point(28, 39);
            this.lblTableList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableList.Name = "lblTableList";
            this.lblTableList.Size = new System.Drawing.Size(53, 13);
            this.lblTableList.TabIndex = 19;
            this.lblTableList.Text = "Table List";
            // 
            // cboRestaurant
            // 
            this.cboRestaurant.FormattingEnabled = true;
            this.cboRestaurant.Location = new System.Drawing.Point(39, 16);
            this.cboRestaurant.Name = "cboRestaurant";
            this.cboRestaurant.Size = new System.Drawing.Size(249, 21);
            this.cboRestaurant.TabIndex = 1;
            // 
            // btnCreateLayout
            // 
            this.btnCreateLayout.Location = new System.Drawing.Point(337, 16);
            this.btnCreateLayout.Name = "btnCreateLayout";
            this.btnCreateLayout.Size = new System.Drawing.Size(120, 24);
            this.btnCreateLayout.TabIndex = 2;
            this.btnCreateLayout.Text = "Create Layout";
            this.btnCreateLayout.UseVisualStyleBackColor = true;
            this.btnCreateLayout.Click += new System.EventHandler(this.btnCreateLayout_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Layout";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateLayout);
            this.Controls.Add(this.cboRestaurant);
            this.Controls.Add(this.tabControl);
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
        private System.Windows.Forms.ComboBox hcboTableList;
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}