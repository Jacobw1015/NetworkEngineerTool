namespace NetworkToolUI
{
    partial class Dashboard
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
            networkToolTitle = new Label();
            networkField = new TextBox();
            networkFieldLabel = new Label();
            createNetworkBtn = new Button();
            textBox2 = new TextBox();
            subnetResults = new Label();
            vlanSubnetPairings = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            vlanField = new TextBox();
            addVlanBtn = new Button();
            statusLabel = new Label();
            VlansList = new TextBox();
            vlanListLabel = new Label();
            SuspendLayout();
            // 
            // networkToolTitle
            // 
            networkToolTitle.AutoSize = true;
            networkToolTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            networkToolTitle.Location = new Point(272, 9);
            networkToolTitle.Margin = new Padding(6, 0, 6, 0);
            networkToolTitle.Name = "networkToolTitle";
            networkToolTitle.Size = new Size(291, 32);
            networkToolTitle.TabIndex = 0;
            networkToolTitle.Text = "Network Engineering Tool";
            // 
            // networkField
            // 
            networkField.Location = new Point(201, 104);
            networkField.Margin = new Padding(6);
            networkField.Name = "networkField";
            networkField.Size = new Size(420, 35);
            networkField.TabIndex = 1;
            // 
            // networkFieldLabel
            // 
            networkFieldLabel.BackColor = Color.FromArgb(224, 224, 224);
            networkFieldLabel.Location = new Point(31, 104);
            networkFieldLabel.Margin = new Padding(6, 0, 6, 0);
            networkFieldLabel.Name = "networkFieldLabel";
            networkFieldLabel.Size = new Size(164, 35);
            networkFieldLabel.TabIndex = 2;
            networkFieldLabel.Text = "Enter in network";
            // 
            // createNetworkBtn
            // 
            createNetworkBtn.Location = new Point(633, 104);
            createNetworkBtn.Margin = new Padding(6);
            createNetworkBtn.Name = "createNetworkBtn";
            createNetworkBtn.Size = new Size(128, 35);
            createNetworkBtn.TabIndex = 4;
            createNetworkBtn.Text = "Go";
            createNetworkBtn.UseVisualStyleBackColor = true;
            createNetworkBtn.Click += createNetworkBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 241);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 266);
            textBox2.TabIndex = 10;
            // 
            // subnetResults
            // 
            subnetResults.AutoSize = true;
            subnetResults.Location = new Point(12, 208);
            subnetResults.Name = "subnetResults";
            subnetResults.Size = new Size(92, 30);
            subnetResults.TabIndex = 5;
            subnetResults.Text = "Subnets:";
            // 
            // vlanSubnetPairings
            // 
            vlanSubnetPairings.AutoSize = true;
            vlanSubnetPairings.Location = new Point(584, 208);
            vlanSubnetPairings.Name = "vlanSubnetPairings";
            vlanSubnetPairings.Size = new Size(240, 30);
            vlanSubnetPairings.TabIndex = 6;
            vlanSubnetPairings.Text = "Suggested Vlan Pairings:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(584, 241);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 266);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 154);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 8;
            label5.Text = "Enter Vlan";
            // 
            // vlanField
            // 
            vlanField.Location = new Point(201, 151);
            vlanField.Name = "vlanField";
            vlanField.Size = new Size(420, 35);
            vlanField.TabIndex = 2;
            // 
            // addVlanBtn
            // 
            addVlanBtn.Location = new Point(633, 151);
            addVlanBtn.Margin = new Padding(6);
            addVlanBtn.Name = "addVlanBtn";
            addVlanBtn.Size = new Size(128, 36);
            addVlanBtn.TabIndex = 3;
            addVlanBtn.Text = "Add Vlan";
            addVlanBtn.UseVisualStyleBackColor = true;
            addVlanBtn.Click += addVlanBtn_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(393, 68);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(69, 30);
            statusLabel.TabIndex = 11;
            statusLabel.Text = "Ready";
            // 
            // VlansList
            // 
            VlansList.Location = new Point(302, 241);
            VlansList.Multiline = true;
            VlansList.Name = "VlansList";
            VlansList.Size = new Size(231, 266);
            VlansList.TabIndex = 12;
            // 
            // vlanListLabel
            // 
            vlanListLabel.AutoSize = true;
            vlanListLabel.Location = new Point(302, 208);
            vlanListLabel.Name = "vlanListLabel";
            vlanListLabel.Size = new Size(91, 30);
            vlanListLabel.TabIndex = 13;
            vlanListLabel.Text = "Vlan List";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(866, 519);
            Controls.Add(vlanListLabel);
            Controls.Add(VlansList);
            Controls.Add(statusLabel);
            Controls.Add(addVlanBtn);
            Controls.Add(vlanField);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(vlanSubnetPairings);
            Controls.Add(subnetResults);
            Controls.Add(textBox2);
            Controls.Add(createNetworkBtn);
            Controls.Add(networkFieldLabel);
            Controls.Add(networkField);
            Controls.Add(networkToolTitle);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label networkToolTitle;
        private TextBox networkField;
        private Label networkFieldLabel;
        private Button createNetworkBtn;
        private TextBox textBox2;
        private Label subnetResults;
        private Label vlanSubnetPairings;
        private TextBox textBox3;
        private Label label5;
        private TextBox vlanField;
        private Button addVlanBtn;
        private Label statusLabel;
        private TextBox VlansList;
        private Label vlanListLabel;
    }
}