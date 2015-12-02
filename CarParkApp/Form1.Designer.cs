namespace CarParkApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStandardSpaces = new System.Windows.Forms.Label();
            this.lblDisabledSpaces = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNumberOfSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarParkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(-1, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Secure Car Park System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStandardSpaces);
            this.groupBox1.Controls.Add(this.lblDisabledSpaces);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(6, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spaces Available";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStandardSpaces
            // 
            this.lblStandardSpaces.AutoSize = true;
            this.lblStandardSpaces.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblStandardSpaces.Location = new System.Drawing.Point(84, 44);
            this.lblStandardSpaces.Name = "lblStandardSpaces";
            this.lblStandardSpaces.Size = new System.Drawing.Size(19, 19);
            this.lblStandardSpaces.TabIndex = 3;
            this.lblStandardSpaces.Text = "0";
            // 
            // lblDisabledSpaces
            // 
            this.lblDisabledSpaces.AutoSize = true;
            this.lblDisabledSpaces.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisabledSpaces.Location = new System.Drawing.Point(84, 23);
            this.lblDisabledSpaces.Name = "lblDisabledSpaces";
            this.lblDisabledSpaces.Size = new System.Drawing.Size(19, 19);
            this.lblDisabledSpaces.TabIndex = 1;
            this.lblDisabledSpaces.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Standard:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Disabled:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.addEditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addEditToolStripMenuItem
            // 
            this.addEditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editNumberOfSpacesToolStripMenuItem,
            this.addNewCarParkToolStripMenuItem});
            this.addEditToolStripMenuItem.Name = "addEditToolStripMenuItem";
            this.addEditToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.addEditToolStripMenuItem.Text = "Add/Edit";
            // 
            // editNumberOfSpacesToolStripMenuItem
            // 
            this.editNumberOfSpacesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardSpacesToolStripMenuItem,
            this.disabledSpacesToolStripMenuItem});
            this.editNumberOfSpacesToolStripMenuItem.Name = "editNumberOfSpacesToolStripMenuItem";
            this.editNumberOfSpacesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editNumberOfSpacesToolStripMenuItem.Text = "Edit Number of Spaces";
            // 
            // addNewCarParkToolStripMenuItem
            // 
            this.addNewCarParkToolStripMenuItem.Name = "addNewCarParkToolStripMenuItem";
            this.addNewCarParkToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addNewCarParkToolStripMenuItem.Text = "Add New Car Park";
            // 
            // standardSpacesToolStripMenuItem
            // 
            this.standardSpacesToolStripMenuItem.Name = "standardSpacesToolStripMenuItem";
            this.standardSpacesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.standardSpacesToolStripMenuItem.Text = "Standard Spaces";
            // 
            // disabledSpacesToolStripMenuItem
            // 
            this.disabledSpacesToolStripMenuItem.Name = "disabledSpacesToolStripMenuItem";
            this.disabledSpacesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.disabledSpacesToolStripMenuItem.Text = "Disabled Spaces";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStandardSpaces;
        private System.Windows.Forms.Label lblDisabledSpaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNumberOfSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarParkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

