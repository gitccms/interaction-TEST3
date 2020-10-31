namespace TEST3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.writebutton = new System.Windows.Forms.Button();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.yeartextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.stafflabel = new System.Windows.Forms.Label();
            this.yearlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.smallradioButton = new System.Windows.Forms.RadioButton();
            this.bigradioButton = new System.Windows.Forms.RadioButton();
            this.readbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.passwdtextBox = new System.Windows.Forms.TextBox();
            this.contentlabel1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.detailradioButton = new System.Windows.Forms.RadioButton();
            this.IDcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.clearbutton);
            this.groupBox1.Controls.Add(this.writebutton);
            this.groupBox1.Controls.Add(this.salarytextBox);
            this.groupBox1.Controls.Add(this.yeartextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.IDtextBox);
            this.groupBox1.Controls.Add(this.stafflabel);
            this.groupBox1.Controls.Add(this.yearlabel);
            this.groupBox1.Controls.Add(this.namelabel);
            this.groupBox1.Controls.Add(this.IDlabel);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "写入员工的信息";
            // 
            // writebutton
            // 
            this.writebutton.Enabled = false;
            this.writebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.writebutton.Location = new System.Drawing.Point(36, 316);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(120, 47);
            this.writebutton.TabIndex = 8;
            this.writebutton.Text = "写入";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Enabled = false;
            this.salarytextBox.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.salarytextBox.Location = new System.Drawing.Point(123, 260);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(174, 35);
            this.salarytextBox.TabIndex = 7;
            this.salarytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stafftextBox_KeyPress);
            // 
            // yeartextBox
            // 
            this.yeartextBox.Enabled = false;
            this.yeartextBox.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.yeartextBox.Location = new System.Drawing.Point(123, 194);
            this.yeartextBox.Name = "yeartextBox";
            this.yeartextBox.Size = new System.Drawing.Size(174, 35);
            this.yeartextBox.TabIndex = 6;
            // 
            // nametextBox
            // 
            this.nametextBox.Enabled = false;
            this.nametextBox.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.nametextBox.Location = new System.Drawing.Point(123, 124);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(174, 35);
            this.nametextBox.TabIndex = 5;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Enabled = false;
            this.IDtextBox.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.IDtextBox.Location = new System.Drawing.Point(123, 68);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(174, 35);
            this.IDtextBox.TabIndex = 4;
            // 
            // stafflabel
            // 
            this.stafflabel.AutoSize = true;
            this.stafflabel.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.stafflabel.Location = new System.Drawing.Point(32, 271);
            this.stafflabel.Name = "stafflabel";
            this.stafflabel.Size = new System.Drawing.Size(58, 24);
            this.stafflabel.TabIndex = 3;
            this.stafflabel.Text = "薪水";
            // 
            // yearlabel
            // 
            this.yearlabel.AutoSize = true;
            this.yearlabel.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.yearlabel.Location = new System.Drawing.Point(32, 205);
            this.yearlabel.Name = "yearlabel";
            this.yearlabel.Size = new System.Drawing.Size(58, 24);
            this.yearlabel.TabIndex = 2;
            this.yearlabel.Text = "年龄";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("长城宋体", 13.8F);
            this.namelabel.Location = new System.Drawing.Point(32, 135);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(58, 24);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "姓名";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("长城宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDlabel.Location = new System.Drawing.Point(32, 79);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(58, 24);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "工号";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(430, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 500);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.detailradioButton);
            this.groupBox2.Controls.Add(this.smallradioButton);
            this.groupBox2.Controls.Add(this.bigradioButton);
            this.groupBox2.Controls.Add(this.readbutton);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(26, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 464);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读取员工信息";
            // 
            // smallradioButton
            // 
            this.smallradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smallradioButton.AutoSize = true;
            this.smallradioButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.smallradioButton.Location = new System.Drawing.Point(414, 415);
            this.smallradioButton.Name = "smallradioButton";
            this.smallradioButton.Size = new System.Drawing.Size(75, 24);
            this.smallradioButton.TabIndex = 3;
            this.smallradioButton.TabStop = true;
            this.smallradioButton.Text = "小图标";
            this.smallradioButton.UseVisualStyleBackColor = true;
            this.smallradioButton.CheckedChanged += new System.EventHandler(this.change_listview);
            // 
            // bigradioButton
            // 
            this.bigradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bigradioButton.AutoSize = true;
            this.bigradioButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bigradioButton.Location = new System.Drawing.Point(333, 415);
            this.bigradioButton.Name = "bigradioButton";
            this.bigradioButton.Size = new System.Drawing.Size(75, 24);
            this.bigradioButton.TabIndex = 2;
            this.bigradioButton.TabStop = true;
            this.bigradioButton.Text = "大图标";
            this.bigradioButton.UseVisualStyleBackColor = true;
            this.bigradioButton.CheckedChanged += new System.EventHandler(this.change_listview);
            // 
            // readbutton
            // 
            this.readbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.readbutton.Enabled = false;
            this.readbutton.Location = new System.Drawing.Point(6, 393);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(286, 65);
            this.readbutton.TabIndex = 1;
            this.readbutton.Text = "读取信息";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDcolumnHeader,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(614, 352);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // passwdtextBox
            // 
            this.passwdtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.passwdtextBox.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwdtextBox.Location = new System.Drawing.Point(12, 439);
            this.passwdtextBox.Name = "passwdtextBox";
            this.passwdtextBox.PasswordChar = '*';
            this.passwdtextBox.Size = new System.Drawing.Size(265, 43);
            this.passwdtextBox.TabIndex = 4;
            this.passwdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdtextBox_KeyPress);
            // 
            // contentlabel1
            // 
            this.contentlabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.contentlabel1.AutoSize = true;
            this.contentlabel1.Font = new System.Drawing.Font("长城宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.contentlabel1.ForeColor = System.Drawing.Color.Black;
            this.contentlabel1.Location = new System.Drawing.Point(12, 417);
            this.contentlabel1.Name = "contentlabel1";
            this.contentlabel1.Size = new System.Drawing.Size(198, 19);
            this.contentlabel1.TabIndex = 5;
            this.contentlabel1.Text = "输入密码连接数据库";
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loginbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.loginbutton.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginbutton.Location = new System.Drawing.Point(294, 439);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(114, 43);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "连接";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.clearbutton.Enabled = false;
            this.clearbutton.Location = new System.Drawing.Point(212, 316);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(120, 47);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "清空";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // detailradioButton
            // 
            this.detailradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.detailradioButton.AutoSize = true;
            this.detailradioButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.detailradioButton.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.detailradioButton.Location = new System.Drawing.Point(495, 414);
            this.detailradioButton.Name = "detailradioButton";
            this.detailradioButton.Size = new System.Drawing.Size(90, 24);
            this.detailradioButton.TabIndex = 4;
            this.detailradioButton.TabStop = true;
            this.detailradioButton.Text = "详细信息";
            this.detailradioButton.UseVisualStyleBackColor = false;
            this.detailradioButton.CheckedChanged += new System.EventHandler(this.change_listview);
            // 
            // IDcolumnHeader
            // 
            this.IDcolumnHeader.Text = "工号";
            this.IDcolumnHeader.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "年龄";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "薪水";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1111, 500);
            this.Controls.Add(this.contentlabel1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passwdtextBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "实验三";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox yeartextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label stafflabel;
        private System.Windows.Forms.Label yearlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.RadioButton smallradioButton;
        private System.Windows.Forms.RadioButton bigradioButton;
        private System.Windows.Forms.TextBox passwdtextBox;
        private System.Windows.Forms.Label contentlabel1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.RadioButton detailradioButton;
        private System.Windows.Forms.ColumnHeader IDcolumnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

