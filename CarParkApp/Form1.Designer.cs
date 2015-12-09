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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStandardSpaces = new System.Windows.Forms.Label();
            this.lblDisabledSpaces = new System.Windows.Forms.Label();
            this.lblStandardTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNumberOfSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disabledSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarParkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEnter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblbarrierTitle = new System.Windows.Forms.TextBox();
            this.txtBarrierStatus = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.systemMessages = new System.Windows.Forms.TextBox();
            this.btnTakeCoin = new System.Windows.Forms.Button();
            this.timeBarrier = new System.Windows.Forms.Timer(this.components);
            this.btnStandard = new System.Windows.Forms.Button();
            this.btnDisabled = new System.Windows.Forms.Button();
            this.btnReturnCoin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.lblStandardTitle);
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
            this.lblStandardSpaces.Text = "4";
            // 
            // lblDisabledSpaces
            // 
            this.lblDisabledSpaces.AutoSize = true;
            this.lblDisabledSpaces.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisabledSpaces.Location = new System.Drawing.Point(84, 23);
            this.lblDisabledSpaces.Name = "lblDisabledSpaces";
            this.lblDisabledSpaces.Size = new System.Drawing.Size(19, 19);
            this.lblDisabledSpaces.TabIndex = 1;
            this.lblDisabledSpaces.Text = "4";
            // 
            // lblStandardTitle
            // 
            this.lblStandardTitle.AutoSize = true;
            this.lblStandardTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardTitle.Location = new System.Drawing.Point(3, 44);
            this.lblStandardTitle.Name = "lblStandardTitle";
            this.lblStandardTitle.Size = new System.Drawing.Size(78, 19);
            this.lblStandardTitle.TabIndex = 2;
            this.lblStandardTitle.Text = "Standard:";
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
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // standardSpacesToolStripMenuItem
            // 
            this.standardSpacesToolStripMenuItem.Name = "standardSpacesToolStripMenuItem";
            this.standardSpacesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.standardSpacesToolStripMenuItem.Text = "Standard Spaces";
            this.standardSpacesToolStripMenuItem.Click += new System.EventHandler(this.standardSpacesToolStripMenuItem_Click);
            // 
            // disabledSpacesToolStripMenuItem
            // 
            this.disabledSpacesToolStripMenuItem.Name = "disabledSpacesToolStripMenuItem";
            this.disabledSpacesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.disabledSpacesToolStripMenuItem.Text = "Disabled Spaces";
            // 
            // addNewCarParkToolStripMenuItem
            // 
            this.addNewCarParkToolStripMenuItem.Name = "addNewCarParkToolStripMenuItem";
            this.addNewCarParkToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addNewCarParkToolStripMenuItem.Text = "Add New Car Park";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Location = new System.Drawing.Point(6, 159);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(147, 57);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter Car Park";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(502, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 137);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(492, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Taken Coins";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblbarrierTitle);
            this.groupBox3.Controls.Add(this.txtBarrierStatus);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.systemMessages);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(174, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 140);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System Messages";
            // 
            // lblbarrierTitle
            // 
            this.lblbarrierTitle.BackColor = System.Drawing.Color.Black;
            this.lblbarrierTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblbarrierTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarrierTitle.ForeColor = System.Drawing.Color.White;
            this.lblbarrierTitle.Location = new System.Drawing.Point(6, 100);
            this.lblbarrierTitle.Multiline = true;
            this.lblbarrierTitle.Name = "lblbarrierTitle";
            this.lblbarrierTitle.Size = new System.Drawing.Size(115, 20);
            this.lblbarrierTitle.TabIndex = 2;
            this.lblbarrierTitle.Text = "Barrier status:";
            // 
            // txtBarrierStatus
            // 
            this.txtBarrierStatus.BackColor = System.Drawing.Color.Black;
            this.txtBarrierStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarrierStatus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrierStatus.ForeColor = System.Drawing.Color.Red;
            this.txtBarrierStatus.Location = new System.Drawing.Point(6, 97);
            this.txtBarrierStatus.Multiline = true;
            this.txtBarrierStatus.Name = "txtBarrierStatus";
            this.txtBarrierStatus.Size = new System.Drawing.Size(300, 26);
            this.txtBarrierStatus.TabIndex = 1;
            this.txtBarrierStatus.Text = "Lowered";
            this.txtBarrierStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(6, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // systemMessages
            // 
            this.systemMessages.BackColor = System.Drawing.Color.Black;
            this.systemMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.systemMessages.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemMessages.ForeColor = System.Drawing.Color.Lime;
            this.systemMessages.Location = new System.Drawing.Point(6, 26);
            this.systemMessages.Multiline = true;
            this.systemMessages.Name = "systemMessages";
            this.systemMessages.Size = new System.Drawing.Size(300, 97);
            this.systemMessages.TabIndex = 0;
            this.systemMessages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTakeCoin
            // 
            this.btnTakeCoin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTakeCoin.Location = new System.Drawing.Point(6, 251);
            this.btnTakeCoin.Name = "btnTakeCoin";
            this.btnTakeCoin.Size = new System.Drawing.Size(147, 58);
            this.btnTakeCoin.TabIndex = 1;
            this.btnTakeCoin.Text = "Take Coin";
            this.btnTakeCoin.UseVisualStyleBackColor = true;
            this.btnTakeCoin.Click += new System.EventHandler(this.btnTakeCoin_Click);
            // 
            // timeBarrier
            // 
            this.timeBarrier.Interval = 10000;
            this.timeBarrier.Tick += new System.EventHandler(this.timeBarrier_Tick);
            // 
            // btnStandard
            // 
            this.btnStandard.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandard.Location = new System.Drawing.Point(6, 222);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(64, 23);
            this.btnStandard.TabIndex = 8;
            this.btnStandard.Text = "Standard";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnDisabled
            // 
            this.btnDisabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisabled.Location = new System.Drawing.Point(89, 222);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(64, 23);
            this.btnDisabled.TabIndex = 9;
            this.btnDisabled.Text = "Disabled";
            this.btnDisabled.UseVisualStyleBackColor = true;
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnReturnCoin
            // 
            this.btnReturnCoin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnCoin.Location = new System.Drawing.Point(6, 315);
            this.btnReturnCoin.Name = "btnReturnCoin";
            this.btnReturnCoin.Size = new System.Drawing.Size(147, 59);
            this.btnReturnCoin.TabIndex = 10;
            this.btnReturnCoin.Text = "Return a coin";
            this.btnReturnCoin.UseVisualStyleBackColor = true;
            this.btnReturnCoin.Click += new System.EventHandler(this.btnReturnCoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(40F, 77F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 423);
            this.Controls.Add(this.btnReturnCoin);
            this.Controls.Add(this.btnDisabled);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.btnTakeCoin);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.Name = "Form1";
            this.Text = "Secure Car Park System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStandardSpaces;
        private System.Windows.Forms.Label lblDisabledSpaces;
        private System.Windows.Forms.Label lblStandardTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNumberOfSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disabledSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarParkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox systemMessages;
        private System.Windows.Forms.Button btnTakeCoin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBarrierStatus;
        private System.Windows.Forms.Timer timeBarrier;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.Button btnDisabled;
        private System.Windows.Forms.TextBox lblbarrierTitle;
        private System.Windows.Forms.Button btnReturnCoin;
    }
}

