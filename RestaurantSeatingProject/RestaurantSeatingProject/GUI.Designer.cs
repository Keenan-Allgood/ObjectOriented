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
            //this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            //this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            //this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
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
            this.tabControl.Location = new System.Drawing.Point(22, 89);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1767, 1050);
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
            //this.tabHost.Controls.Add(this.shapeContainer1);
            this.tabHost.Location = new System.Drawing.Point(4, 33);
            this.tabHost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabHost.Name = "tabHost";
            this.tabHost.Size = new System.Drawing.Size(1759, 1013);
            this.tabHost.TabIndex = 0;
            this.tabHost.Text = "HOST";
            // 
            // btnRemoveTableInfo
            // 
            this.btnRemoveTableInfo.Location = new System.Drawing.Point(1151, 119);
            this.btnRemoveTableInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveTableInfo.Name = "btnRemoveTableInfo";
            this.btnRemoveTableInfo.Size = new System.Drawing.Size(103, 52);
            this.btnRemoveTableInfo.TabIndex = 18;
            this.btnRemoveTableInfo.Text = "Remove";
            this.btnRemoveTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnModifyTableInfo
            // 
            this.btnModifyTableInfo.Location = new System.Drawing.Point(1032, 119);
            this.btnModifyTableInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyTableInfo.Name = "btnModifyTableInfo";
            this.btnModifyTableInfo.Size = new System.Drawing.Size(95, 52);
            this.btnModifyTableInfo.TabIndex = 17;
            this.btnModifyTableInfo.Text = "Modify";
            this.btnModifyTableInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddTableInfo
            // 
            this.btnAddTableInfo.Location = new System.Drawing.Point(915, 119);
            this.btnAddTableInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTableInfo.Name = "btnAddTableInfo";
            this.btnAddTableInfo.Size = new System.Drawing.Size(97, 52);
            this.btnAddTableInfo.TabIndex = 16;
            this.btnAddTableInfo.Text = "Add";
            this.btnAddTableInfo.UseVisualStyleBackColor = true;
            this.btnAddTableInfo.Click += new System.EventHandler(this.btnAddTableInfo_Click);
            // 
            // btnAddWaitGroup
            // 
            this.btnAddWaitGroup.Location = new System.Drawing.Point(1496, 967);
            this.btnAddWaitGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWaitGroup.Name = "btnAddWaitGroup";
            this.btnAddWaitGroup.Size = new System.Drawing.Size(122, 40);
            this.btnAddWaitGroup.TabIndex = 15;
            this.btnAddWaitGroup.Text = "Add Group";
            this.btnAddWaitGroup.UseVisualStyleBackColor = true;
            this.btnAddWaitGroup.Click += new System.EventHandler(this.btnAddWaitGroup_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(1604, 928);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(121, 29);
            this.txtSize.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1420, 928);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 29);
            this.txtName.TabIndex = 13;
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
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(1611, 652);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(115, 46);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboWaitList
            // 
            this.cboWaitList.FormattingEnabled = true;
            this.cboWaitList.Location = new System.Drawing.Point(1420, 664);
            this.cboWaitList.Margin = new System.Windows.Forms.Padding(4);
            this.cboWaitList.Name = "cboWaitList";
            this.cboWaitList.Size = new System.Drawing.Size(147, 32);
            this.cboWaitList.TabIndex = 9;
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
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(1483, 437);
            this.btnAddServer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(136, 35);
            this.btnAddServer.TabIndex = 7;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(1484, 384);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(121, 29);
            this.txtServerName.TabIndex = 6;
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
            // cboServerList
            // 
            this.cboServerList.FormattingEnabled = true;
            this.cboServerList.Location = new System.Drawing.Point(1483, 115);
            this.cboServerList.Margin = new System.Windows.Forms.Padding(4);
            this.cboServerList.Name = "cboServerList";
            this.cboServerList.Size = new System.Drawing.Size(147, 32);
            this.cboServerList.TabIndex = 4;
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
            // cboTableList
            // 
            this.cboTableList.FormattingEnabled = true;
            this.cboTableList.Location = new System.Drawing.Point(44, 116);
            this.cboTableList.Margin = new System.Windows.Forms.Padding(4);
            this.cboTableList.Name = "cboTableList";
            this.cboTableList.Size = new System.Drawing.Size(697, 32);
            this.cboTableList.TabIndex = 2;
            // 
            // lblTableList
            // 
            this.lblTableList.AutoSize = true;
            this.lblTableList.Location = new System.Drawing.Point(44, 66);
            this.lblTableList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTableList.Name = "lblTableList";
            this.lblTableList.Size = new System.Drawing.Size(97, 25);
            this.lblTableList.TabIndex = 1;
            this.lblTableList.Text = "Table List";
            // 
            // shapeContainer1
            // 
            //this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            //this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            //this.shapeContainer1.Name = "shapeContainer1";
            //this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            //this.lineShape2,
            //this.lineShape1});
            //this.shapeContainer1.Size = new System.Drawing.Size(1759, 1013);
            //this.shapeContainer1.TabIndex = 0;
            //this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            //this.lineShape2.BorderWidth = 10;
            //this.lineShape2.Name = "lineShape2";
            //this.lineShape2.X1 = 1077;
            //this.lineShape2.X2 = 1439;
            //this.lineShape2.Y1 = 447;
            //this.lineShape2.Y2 = 447;
            // 
            // lineShape1
            // 
            //this.lineShape1.BorderWidth = 10;
            //this.lineShape1.Name = "lineShape1";
            //this.lineShape1.X1 = 1074;
            //this.lineShape1.X2 = 1075;
            //this.lineShape1.Y1 = 839;
            //this.lineShape1.Y2 = 3;
            // 
            // tabManager
            // 
            this.tabManager.Location = new System.Drawing.Point(4, 33);
            this.tabManager.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(1759, 1013);
            this.tabManager.TabIndex = 1;
            this.tabManager.Text = "MANAGER";
            this.tabManager.UseVisualStyleBackColor = true;
            // 
            // cboRestaurant
            // 
            this.cboRestaurant.FormattingEnabled = true;
            this.cboRestaurant.Location = new System.Drawing.Point(71, 30);
            this.cboRestaurant.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboRestaurant.Name = "cboRestaurant";
            this.cboRestaurant.Size = new System.Drawing.Size(454, 32);
            this.cboRestaurant.TabIndex = 1;
            // 
            // btnCreateLayout
            // 
            this.btnCreateLayout.Location = new System.Drawing.Point(618, 30);
            this.btnCreateLayout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCreateLayout.Name = "btnCreateLayout";
            this.btnCreateLayout.Size = new System.Drawing.Size(220, 44);
            this.btnCreateLayout.TabIndex = 2;
            this.btnCreateLayout.Text = "Create Layout";
            this.btnCreateLayout.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(904, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            this.ClientSize = new System.Drawing.Size(2016, 1390);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreateLayout);
            this.Controls.Add(this.cboRestaurant);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
        //private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        //private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}