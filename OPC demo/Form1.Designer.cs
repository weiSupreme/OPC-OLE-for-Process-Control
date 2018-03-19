namespace OPCClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.cmbServerName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TagValue = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.cmbServerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接OPC服务器";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "获取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connect
            // 
            this.connect.Enabled = false;
            this.connect.Location = new System.Drawing.Point(74, 67);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(49, 25);
            this.connect.TabIndex = 3;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // cmbServerName
            // 
            this.cmbServerName.FormattingEnabled = true;
            this.cmbServerName.Location = new System.Drawing.Point(6, 39);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(185, 22);
            this.cmbServerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "服务器：";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(207, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(265, 382);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TagValue);
            this.groupBox2.Location = new System.Drawing.Point(4, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前值";
            // 
            // TagValue
            // 
            this.TagValue.Location = new System.Drawing.Point(12, 17);
            this.TagValue.Multiline = true;
            this.TagValue.Name = "TagValue";
            this.TagValue.ReadOnly = true;
            this.TagValue.Size = new System.Drawing.Size(170, 197);
            this.TagValue.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWrite);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(4, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 55);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "写入值";
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(118, 16);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(64, 31);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "写入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.Status.Location = new System.Drawing.Point(0, 394);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(474, 22);
            this.Status.TabIndex = 5;
            this.Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(459, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "河海大学物联网工程学院";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OPCClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.ComboBox cmbServerName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TagValue;
        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button2;
    }
}

