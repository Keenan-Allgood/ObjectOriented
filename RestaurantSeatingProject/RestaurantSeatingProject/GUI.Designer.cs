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
            this.btnRemoveTableInfo = new System.Windows.Forms.Button();
            this.btnModifyTableInfo = new System.Windows.Forms.Button();
            this.btnAddTableInfo = new System.Windows.Forms.Button();
            this.btnAddWaitGroup = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboWaitList = new System.Windows.Forms.ComboBox();
            this.lblWaitList = new System.Windows.Forms.Label();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.cboServerList = new System.Windows.Forms.ComboBox();
            this.lblServerList = new System.Windows.Forms.Label();
            this.cboTableList = new System.Windows.Forms.ComboBox();
            this.lblTableList = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabManager = new System.Windows.Forms.TabPage();
            this.cboRestaurant = new System.Windows.Forms.ComboBox();
            this.btnCreateLayout = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabHost.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHost);
            this.tabControl.Controls.Add(this.tabManager);
            this.tabControl.Location = new System.Drawing.Point(18, 74);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1446, 875);
            this.tabControl.TabIndex = 0;
            // 
            // tabHost
            // 
            this.tabHost.BackColor = System.Drawing.Color.Transparent;
            this.tabHost.Controls.Add(this.btnRemoveTableInfo);
            this.tabHost.Controls.Add(this.btnModifyTableInfo);
            this.tabHost.Controls.Add(this.btnAddTableInfo);
            this.tabHost.Controls.Add(this.btnAddWaitGroup);
            this.tabHost.Controls.Add(this.txtSize);
            this.tabHost.Controls.Add(this.txtName);
            this.tabHost.Controls.Add(this.lblSize);
            this.tabHost.Controls.Add(this.lblName);
            this.tabHost.Controls.Add(this.btnRemove);
            this.tabHost.Controls.Add(this.cboWaitList);
            this.tabHost.Controls.Add(this.lblWaitList);
            this.tabHost.Controls.Add(this.btnAddServer);
            this.tabHost.Controls.Add(this.txtServerName);
            this.tabHost.Controls.Add(this.lblServerName);
            this.tabHost.Controls.Add(this.cboServerList);
            this.tabHost.Controls.Add(this.lblServerList);
            this.tabHost.Controls.Add(this.cboTableList);
            this.tabHost.Controls.Add(this.lblTableList);
            this.tabHost.Controls.Add(this.shapeContainer1);
            this.tabHost.Location = new System.Drawing.Point(4, 29);
            this.tabHost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHost.Name = "tabHost";
            this.tabHost.Size = new System.Drawing.Size(1438, 842);
            this.tabHost.TabIndex = 0;
            this.tabHost.Text = "HOST";
            // 
            // btnRemoveTableInfo
            // 
            this.btnRemoveTableInfo.Location = new System.Drawing.Point(942, 99);
            this.btnRemoveTableInfo.Name = "btnRemoveTableInfo";
            this.btnRemoveTableInfo.Size = new System.Drawing.Size(84, 43);
            this.btnRemoveTableInfo.TabIndex = 18;
            this.btnRemoveTableInfo.Text = "Remove";
            this.btnRemoveTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnModifyTableInfo
            // 
            this.btnModifyTableInfo.Location = new System.Drawing.Point(844, 99);
            this.btnModifyTableInfo.Name = "btnModifyTableInfo";
            this.btnModifyTableInfo.Size = new System.Drawing.Size(78, 43);
            this.btnModifyTableInfo.TabIndex = 17;
            this.btnModifyTableInfo.Text = "Modify";
            this.btnModifyTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddTableInfo
            // 
            this.btnAddTableInfo.Location = new System.Drawing.Point(749, 99);
            this.btnAddTableInfo.Name = "btnAddTableInfo";
            this.btnAddTableInfo.Size = new System.Drawing.Size(79, 43);
            this.btnAddTableInfo.TabIndex = 16;
            this.btnAddTableInfo.Text = "Add";
            this.btnAddTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddWaitGroup
            // 
            this.btnAddWaitGroup.Location = new System.Drawing.Point(1224, 806);
            this.btnAddWaitGroup.Name = "btnAddWaitGroup";
            this.btnAddWaitGroup.Size = new System.Drawing.Size(100, 33);
            this.btnAddWaitGroup.TabIndex = 15;
            this.btnAddWaitGroup.Text = "Add Group";
            this.btnAddWaitGroup.UseVisualStyleBackColor = true;
            this.btnAddWaitGroup.Click += new System.EventHandler(this.btnAddWaitGroup_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(1312, 773);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1162, 773);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 13;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(1314, 740);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 12;
            this.lblSize.Text = "Size";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1158, 740);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1318, 543);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 38);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboWaitList
            // 
            this.cboWaitList.FormattingEnabled = true;
            this.cboWaitList.Location = new System.Drawing.Point(1162, 553);
            this.cboWaitList.Name = "cboWaitList";
            this.cboWaitList.Size = new System.Drawing.Size(121, 28);
            this.cboWaitList.TabIndex = 9;
            // 
            // lblWaitList
            // 
            this.lblWaitList.AutoSize = true;
            this.lblWaitList.Location = new System.Drawing.Point(1213, 494);
            this.lblWaitList.Name = "lblWaitList";
            this.lblWaitList.Size = new System.Drawing.Size(70, 20);
            this.lblWaitList.TabIndex = 8;
            this.lblWaitList.Text = "Wait List";
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(1213, 364);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(111, 29);
            this.btnAddServer.TabIndex = 7;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(1214, 320);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(100, 26);
            this.txtServerName.TabIndex = 6;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.Location = new System.Drawing.Point(1209, 285);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(101, 20);
            this.lblServerName.TabIndex = 5;
            this.lblServerName.Text = "Server Name";
            // 
            // cboServerList
            // 
            this.cboServerList.FormattingEnabled = true;
            this.cboServerList.Location = new System.Drawing.Point(1213, 96);
            this.cboServerList.Name = "cboServerList";
            this.cboServerList.Size = new System.Drawing.Size(121, 28);
            this.cboServerList.TabIndex = 4;
            // 
            // lblServerList
            // 
            this.lblServerList.AutoSize = true;
            this.lblServerList.Location = new System.Drawing.Point(1209, 54);
            this.lblServerList.Name = "lblServerList";
            this.lblServerList.Size = new System.Drawing.Size(84, 20);
            this.lblServerList.TabIndex = 3;
            this.lblServerList.Text = "Server List";
            // 
            // cboTableList
            // 
            this.cboTableList.FormattingEnabled = true;
            this.cboTableList.Location = new System.Drawing.Point(36, 97);
            this.cboTableList.Name = "cboTableList";
            this.cboTableList.Size = new System.Drawing.Size(571, 28);
            this.cboTableList.TabIndex = 2;
            // 
            // lblTableList
            // 
            this.lblTableList.AutoSize = true;
            this.lblTableList.Location = new System.Drawing.Point(36, 55);
            this.lblTableList.Name = "lblTableList";
            this.lblTableList.Size = new System.Drawing.Size(77, 20);
            this.lblTableList.TabIndex = 1;
            this.lblTableList.Text = "Table List";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1438, 842);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 10;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 1077;
            this.lineShape2.X2 = 1439;
            this.lineShape2.Y1 = 447;
            this.lineShape2.Y2 = 447;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 10;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1074;
            this.lineShape1.X2 = 1075;
            this.lineShape1.Y1 = 839;
            this.lineShape1.Y2 = 3;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 29);
            this.tabManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(1438, 842);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "MANAGER";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // cboRestaurant
            // 
            this.cboRestaurant.FormattingEnabled = true;
            this.cboRestaurant.Location = new System.Drawing.Point(58, 25);
            this.cboRestaurant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboRestaurant.Name = "cboRestaurant";
            this.cboRestaurant.Size = new System.Drawing.Size(372, 28);
            this.cboRestaurant.TabIndex = 1;
            // 
            // btnCreateLayout
            // 
            this.btnCreateLayout.Location = new System.Drawing.Point(506, 25);
            this.btnCreateLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateLayout.Name = "btnCreateLayout";
            this.btnCreateLayout.Size = new System.Drawing.Size(180, 37);
            this.btnCreateLayout.TabIndex = 2;
            this.btnCreateLayout.Text = "Create Layout";
            this.btnCreateLayout.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(740, 25);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Layout";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 968);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateLayout);
            this.Controls.Add(this.cboRestaurant);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GUI";
            this.Text = "HostUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.tabControl.ResumeLayout(false);
            this.tabHost.ResumeLayout(false);
            this.tabHost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHost;
        private System.Windows.Forms.TabPage tabManager;
        private System.Windows.Forms.ComboBox cboRestaurant;
        private System.Windows.Forms.Button btnCreateLayout;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRemoveTableInfo;
        private System.Windows.Forms.Button btnModifyTableInfo;
        private System.Windows.Forms.Button btnAddTableInfo;
        private System.Windows.Forms.Button btnAddWaitGroup;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboWaitList;
        private System.Windows.Forms.Label lblWaitList;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.ComboBox cboServerList;
        private System.Windows.Forms.Label lblServerList;
        private System.Windows.Forms.ComboBox cboTableList;
        private System.Windows.Forms.Label lblTableList;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}