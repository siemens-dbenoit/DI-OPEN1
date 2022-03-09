namespace ProjectCreator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.lbProjectName = new System.Windows.Forms.Label();
            this.cbSubnetType = new System.Windows.Forms.ComboBox();
            this.cbDeviceType = new System.Windows.Forms.ComboBox();
            this.btnInitializeProject = new System.Windows.Forms.Button();
            this.tbSubnetName = new System.Windows.Forms.TextBox();
            this.lb_Subnet = new System.Windows.Forms.Label();
            this.lbDeviceName = new System.Windows.Forms.Label();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.btnAddSubnet = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lbSubnets = new System.Windows.Forms.ListBox();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lbTest = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(9, 102);
            this.tbProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(134, 20);
            this.tbProjectName.TabIndex = 0;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(7, 85);
            this.lbProjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(131, 13);
            this.lbProjectName.TabIndex = 1;
            this.lbProjectName.Text = "Please enter Project name";
            // 
            // cbSubnetType
            // 
            this.cbSubnetType.Enabled = false;
            this.cbSubnetType.FormattingEnabled = true;
            this.cbSubnetType.Location = new System.Drawing.Point(192, 102);
            this.cbSubnetType.Margin = new System.Windows.Forms.Padding(2);
            this.cbSubnetType.Name = "cbSubnetType";
            this.cbSubnetType.Size = new System.Drawing.Size(243, 21);
            this.cbSubnetType.TabIndex = 2;
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.Enabled = false;
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Location = new System.Drawing.Point(448, 103);
            this.cbDeviceType.Margin = new System.Windows.Forms.Padding(2);
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(243, 21);
            this.cbDeviceType.TabIndex = 3;
            // 
            // btnInitializeProject
            // 
            this.btnInitializeProject.Location = new System.Drawing.Point(10, 132);
            this.btnInitializeProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitializeProject.Name = "btnInitializeProject";
            this.btnInitializeProject.Size = new System.Drawing.Size(132, 28);
            this.btnInitializeProject.TabIndex = 4;
            this.btnInitializeProject.Text = "Initialize Project";
            this.btnInitializeProject.UseVisualStyleBackColor = true;
            this.btnInitializeProject.Click += new System.EventHandler(this.btnInitializeProject_Click);
            // 
            // tbSubnetName
            // 
            this.tbSubnetName.Enabled = false;
            this.tbSubnetName.Location = new System.Drawing.Point(192, 79);
            this.tbSubnetName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSubnetName.Name = "tbSubnetName";
            this.tbSubnetName.Size = new System.Drawing.Size(243, 20);
            this.tbSubnetName.TabIndex = 5;
            // 
            // lb_Subnet
            // 
            this.lb_Subnet.AutoSize = true;
            this.lb_Subnet.Location = new System.Drawing.Point(190, 63);
            this.lb_Subnet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Subnet.Name = "lb_Subnet";
            this.lb_Subnet.Size = new System.Drawing.Size(130, 13);
            this.lb_Subnet.TabIndex = 6;
            this.lb_Subnet.Text = "Please enter subnet name";
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.AutoSize = true;
            this.lbDeviceName.Location = new System.Drawing.Point(446, 63);
            this.lbDeviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(132, 13);
            this.lbDeviceName.TabIndex = 8;
            this.lbDeviceName.Text = "Please enter Device name";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Enabled = false;
            this.tbDeviceName.Location = new System.Drawing.Point(448, 79);
            this.tbDeviceName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(243, 20);
            this.tbDeviceName.TabIndex = 7;
            // 
            // btnAddSubnet
            // 
            this.btnAddSubnet.Enabled = false;
            this.btnAddSubnet.Location = new System.Drawing.Point(192, 132);
            this.btnAddSubnet.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSubnet.Name = "btnAddSubnet";
            this.btnAddSubnet.Size = new System.Drawing.Size(242, 28);
            this.btnAddSubnet.TabIndex = 9;
            this.btnAddSubnet.Text = "Add subnet";
            this.btnAddSubnet.UseVisualStyleBackColor = true;
            this.btnAddSubnet.Click += new System.EventHandler(this.btnAddSubnet_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Location = new System.Drawing.Point(448, 132);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(242, 28);
            this.btnAddDevice.TabIndex = 10;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lbSubnets
            // 
            this.lbSubnets.FormattingEnabled = true;
            this.lbSubnets.Location = new System.Drawing.Point(192, 178);
            this.lbSubnets.Margin = new System.Windows.Forms.Padding(2);
            this.lbSubnets.Name = "lbSubnets";
            this.lbSubnets.Size = new System.Drawing.Size(243, 108);
            this.lbSubnets.TabIndex = 11;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(448, 178);
            this.lbDevices.Margin = new System.Windows.Forms.Padding(2);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(243, 108);
            this.lbDevices.TabIndex = 12;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Enabled = false;
            this.btnCreateProject.Location = new System.Drawing.Point(14, 296);
            this.btnCreateProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(676, 59);
            this.btnCreateProject.TabIndex = 13;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(392, 527);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 14;
            // 
            // lbTest
            // 
            this.lbTest.FormattingEnabled = true;
            this.lbTest.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3"});
            this.lbTest.Location = new System.Drawing.Point(102, 452);
            this.lbTest.Name = "lbTest";
            this.lbTest.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTest.Size = new System.Drawing.Size(217, 186);
            this.lbTest.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "was ist ausgewählt?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 792);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTest);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.lbSubnets);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.btnAddSubnet);
            this.Controls.Add(this.lbDeviceName);
            this.Controls.Add(this.tbDeviceName);
            this.Controls.Add(this.lb_Subnet);
            this.Controls.Add(this.tbSubnetName);
            this.Controls.Add(this.btnInitializeProject);
            this.Controls.Add(this.cbDeviceType);
            this.Controls.Add(this.cbSubnetType);
            this.Controls.Add(this.lbProjectName);
            this.Controls.Add(this.tbProjectName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ProjectCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label lbProjectName;
        private System.Windows.Forms.ComboBox cbSubnetType;
        private System.Windows.Forms.ComboBox cbDeviceType;
        private System.Windows.Forms.Button btnInitializeProject;
        private System.Windows.Forms.TextBox tbSubnetName;
        private System.Windows.Forms.Label lb_Subnet;
        private System.Windows.Forms.Label lbDeviceName;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Button btnAddSubnet;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.ListBox lbSubnets;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox lbTest;
        private System.Windows.Forms.Button button1;
    }
}

