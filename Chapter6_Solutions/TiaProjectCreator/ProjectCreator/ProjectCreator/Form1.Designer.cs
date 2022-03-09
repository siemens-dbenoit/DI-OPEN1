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
            this.SuspendLayout();
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(12, 125);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(178, 22);
            this.tbProjectName.TabIndex = 0;
            // 
            // lbProjectName
            // 
            this.lbProjectName.AutoSize = true;
            this.lbProjectName.Location = new System.Drawing.Point(9, 105);
            this.lbProjectName.Name = "lbProjectName";
            this.lbProjectName.Size = new System.Drawing.Size(175, 17);
            this.lbProjectName.TabIndex = 1;
            this.lbProjectName.Text = "Please enter Project name";
            // 
            // cbSubnetType
            // 
            this.cbSubnetType.Enabled = false;
            this.cbSubnetType.FormattingEnabled = true;
            this.cbSubnetType.Items.AddRange(new object[] {
            "PROFINET",
            "PROFIBUS",
            "ASI",
            "MPI",
            "xxxUNDEFxxx"});
            this.cbSubnetType.Location = new System.Drawing.Point(256, 125);
            this.cbSubnetType.Name = "cbSubnetType";
            this.cbSubnetType.Size = new System.Drawing.Size(323, 24);
            this.cbSubnetType.TabIndex = 2;
            // 
            // cbDeviceType
            // 
            this.cbDeviceType.Enabled = false;
            this.cbDeviceType.FormattingEnabled = true;
            this.cbDeviceType.Items.AddRange(new object[] {
            "S7-300",
            "S7-400",
            "ET200SP",
            "S7-1500",
            "xxxUNDEFxxx"});
            this.cbDeviceType.Location = new System.Drawing.Point(598, 127);
            this.cbDeviceType.Name = "cbDeviceType";
            this.cbDeviceType.Size = new System.Drawing.Size(323, 24);
            this.cbDeviceType.TabIndex = 3;
            // 
            // btnInitializeProject
            // 
            this.btnInitializeProject.Location = new System.Drawing.Point(13, 163);
            this.btnInitializeProject.Name = "btnInitializeProject";
            this.btnInitializeProject.Size = new System.Drawing.Size(176, 34);
            this.btnInitializeProject.TabIndex = 4;
            this.btnInitializeProject.Text = "Initialize Project";
            this.btnInitializeProject.UseVisualStyleBackColor = true;
            this.btnInitializeProject.Click += new System.EventHandler(this.btnInitializeProject_Click);
            // 
            // tbSubnetName
            // 
            this.tbSubnetName.Enabled = false;
            this.tbSubnetName.Location = new System.Drawing.Point(256, 97);
            this.tbSubnetName.Name = "tbSubnetName";
            this.tbSubnetName.Size = new System.Drawing.Size(323, 22);
            this.tbSubnetName.TabIndex = 5;
            // 
            // lb_Subnet
            // 
            this.lb_Subnet.AutoSize = true;
            this.lb_Subnet.Location = new System.Drawing.Point(253, 77);
            this.lb_Subnet.Name = "lb_Subnet";
            this.lb_Subnet.Size = new System.Drawing.Size(174, 17);
            this.lb_Subnet.TabIndex = 6;
            this.lb_Subnet.Text = "Please enter subnet name";
            // 
            // lbDeviceName
            // 
            this.lbDeviceName.AutoSize = true;
            this.lbDeviceName.Location = new System.Drawing.Point(595, 77);
            this.lbDeviceName.Name = "lbDeviceName";
            this.lbDeviceName.Size = new System.Drawing.Size(174, 17);
            this.lbDeviceName.TabIndex = 8;
            this.lbDeviceName.Text = "Please enter Device name";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Enabled = false;
            this.tbDeviceName.Location = new System.Drawing.Point(598, 97);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(323, 22);
            this.tbDeviceName.TabIndex = 7;
            // 
            // btnAddSubnet
            // 
            this.btnAddSubnet.Enabled = false;
            this.btnAddSubnet.Location = new System.Drawing.Point(256, 163);
            this.btnAddSubnet.Name = "btnAddSubnet";
            this.btnAddSubnet.Size = new System.Drawing.Size(323, 34);
            this.btnAddSubnet.TabIndex = 9;
            this.btnAddSubnet.Text = "Add subnet";
            this.btnAddSubnet.UseVisualStyleBackColor = true;
            this.btnAddSubnet.Click += new System.EventHandler(this.btnAddSubnet_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Location = new System.Drawing.Point(598, 163);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(323, 34);
            this.btnAddDevice.TabIndex = 10;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lbSubnets
            // 
            this.lbSubnets.FormattingEnabled = true;
            this.lbSubnets.ItemHeight = 16;
            this.lbSubnets.Location = new System.Drawing.Point(256, 219);
            this.lbSubnets.Name = "lbSubnets";
            this.lbSubnets.Size = new System.Drawing.Size(323, 132);
            this.lbSubnets.TabIndex = 11;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.ItemHeight = 16;
            this.lbDevices.Location = new System.Drawing.Point(598, 219);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(323, 132);
            this.lbDevices.TabIndex = 12;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Enabled = false;
            this.btnCreateProject.Location = new System.Drawing.Point(18, 364);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(902, 73);
            this.btnCreateProject.TabIndex = 13;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
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
    }
}

