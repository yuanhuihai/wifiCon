namespace wifiCon
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.wifiPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wifiCon = new System.Windows.Forms.Button();
            this.wifiDis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.wifiStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wifiPass
            // 
            this.wifiPass.AutoSize = true;
            this.wifiPass.BackColor = System.Drawing.SystemColors.Control;
            this.wifiPass.Location = new System.Drawing.Point(36, 142);
            this.wifiPass.Name = "wifiPass";
            this.wifiPass.Size = new System.Drawing.Size(73, 30);
            this.wifiPass.TabIndex = 1;
            this.wifiPass.Text = "密码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(208, 42);
            this.textBox1.TabIndex = 2;
            // 
            // wifiCon
            // 
            this.wifiCon.Location = new System.Drawing.Point(49, 232);
            this.wifiCon.Name = "wifiCon";
            this.wifiCon.Size = new System.Drawing.Size(119, 58);
            this.wifiCon.TabIndex = 3;
            this.wifiCon.Text = "连接";
            this.wifiCon.UseVisualStyleBackColor = true;
            this.wifiCon.Click += new System.EventHandler(this.wifiCon_Click);
            // 
            // wifiDis
            // 
            this.wifiDis.Location = new System.Drawing.Point(204, 232);
            this.wifiDis.Name = "wifiDis";
            this.wifiDis.Size = new System.Drawing.Size(119, 58);
            this.wifiDis.TabIndex = 4;
            this.wifiDis.Text = "断开";
            this.wifiDis.UseVisualStyleBackColor = true;
            this.wifiDis.Click += new System.EventHandler(this.wifiDis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(545, 225);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(751, 496);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Wlan名称";
            this.columnHeader1.Width = 715;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wlan网络列表";
            // 
            // wifiStatus
            // 
            this.wifiStatus.AutoSize = true;
            this.wifiStatus.Location = new System.Drawing.Point(540, 807);
            this.wifiStatus.Name = "wifiStatus";
            this.wifiStatus.Size = new System.Drawing.Size(193, 30);
            this.wifiStatus.TabIndex = 7;
            this.wifiStatus.Text = "网络连接状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1966, 1008);
            this.Controls.Add(this.wifiStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.wifiDis);
            this.Controls.Add(this.wifiCon);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wifiPass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wifiPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button wifiCon;
        private System.Windows.Forms.Button wifiDis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wifiStatus;
    }
}

