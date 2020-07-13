namespace AmamiyaEditer
{
    partial class frmAmamiyaTalk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmamiyaTalk));
            this.lblMin = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.Setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setbackcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.setTextBoxColor = new System.Windows.Forms.ToolStripMenuItem();
            this.setFont = new System.Windows.Forms.ToolStripMenuItem();
            this.setForeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reset = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSize = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTalk = new System.Windows.Forms.TextBox();
            this.lblNowTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLiveTime = new System.Windows.Forms.Label();
            this.lblLiveColor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.picAvatar = new AmamiyaEditer.MyForms.MyPictureBox();
            this.Setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMin.Location = new System.Drawing.Point(746, 13);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(49, 34);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "－";
            this.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMin.Click += new System.EventHandler(this.label2_Click);
            this.lblMin.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.lblMin.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClose.Location = new System.Drawing.Point(801, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(45, 34);
            this.lblClose.TabIndex = 4;
            this.lblClose.Text = "×";
            this.lblClose.Click += new System.EventHandler(this.label3_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // Setting
            // 
            this.Setting.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Setting.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setbackcolor,
            this.setTextBoxColor,
            this.setFont,
            this.setForeColor,
            this.Separator1,
            this.reset,
            this.resetSize});
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(154, 154);
            // 
            // setbackcolor
            // 
            this.setbackcolor.Name = "setbackcolor";
            this.setbackcolor.Size = new System.Drawing.Size(153, 24);
            this.setbackcolor.Text = "背景颜色";
            this.setbackcolor.Click += new System.EventHandler(this.setbackcolor_Click);
            // 
            // setTextBoxColor
            // 
            this.setTextBoxColor.Name = "setTextBoxColor";
            this.setTextBoxColor.Size = new System.Drawing.Size(153, 24);
            this.setTextBoxColor.Text = "输入框颜色";
            this.setTextBoxColor.Click += new System.EventHandler(this.setTextBoxColor_Click);
            // 
            // setFont
            // 
            this.setFont.Name = "setFont";
            this.setFont.Size = new System.Drawing.Size(153, 24);
            this.setFont.Text = "字体与字号";
            this.setFont.Click += new System.EventHandler(this.setFont_Click);
            // 
            // setForeColor
            // 
            this.setForeColor.Name = "setForeColor";
            this.setForeColor.Size = new System.Drawing.Size(153, 24);
            this.setForeColor.Text = "字体颜色";
            this.setForeColor.Click += new System.EventHandler(this.setForeColor_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(150, 6);
            // 
            // reset
            // 
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(153, 24);
            this.reset.Text = "恢复颜色";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // resetSize
            // 
            this.resetSize.Name = "resetSize";
            this.resetSize.Size = new System.Drawing.Size(153, 24);
            this.resetSize.Text = "恢复大小";
            this.resetSize.Click += new System.EventHandler(this.resetSize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(370, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "希姐说";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // txtTalk
            // 
            this.txtTalk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTalk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTalk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTalk.ContextMenuStrip = this.Setting;
            this.txtTalk.Font = new System.Drawing.Font("Microsoft YaHei", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTalk.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTalk.Location = new System.Drawing.Point(12, 57);
            this.txtTalk.Multiline = true;
            this.txtTalk.Name = "txtTalk";
            this.txtTalk.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTalk.Size = new System.Drawing.Size(839, 483);
            this.txtTalk.TabIndex = 0;
            this.txtTalk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTalk_KeyUp);
            // 
            // lblNowTime
            // 
            this.lblNowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNowTime.BackColor = System.Drawing.Color.Transparent;
            this.lblNowTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNowTime.Font = new System.Drawing.Font("1234567890", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowTime.Location = new System.Drawing.Point(651, 543);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(200, 48);
            this.lblNowTime.TabIndex = 6;
            this.lblNowTime.Text = "07 : 10";
            this.lblNowTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNowTime.DoubleClick += new System.EventHandler(this.lblNowTime_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLiveTime
            // 
            this.lblLiveTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLiveTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLiveTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveTime.Font = new System.Drawing.Font("1234567890", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiveTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblLiveTime.Location = new System.Drawing.Point(12, 543);
            this.lblLiveTime.Name = "lblLiveTime";
            this.lblLiveTime.Size = new System.Drawing.Size(200, 48);
            this.lblLiveTime.TabIndex = 6;
            this.lblLiveTime.Text = "00 : 00";
            this.lblLiveTime.DoubleClick += new System.EventHandler(this.lblLiveTime_DoubleClick);
            // 
            // lblLiveColor
            // 
            this.lblLiveColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLiveColor.BackColor = System.Drawing.Color.White;
            this.lblLiveColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLiveColor.ForeColor = System.Drawing.Color.Transparent;
            this.lblLiveColor.Location = new System.Drawing.Point(12, 563);
            this.lblLiveColor.Name = "lblLiveColor";
            this.lblLiveColor.Size = new System.Drawing.Size(7, 7);
            this.lblLiveColor.TabIndex = 7;
            this.lblLiveColor.Visible = false;
            this.lblLiveColor.DoubleClick += new System.EventHandler(this.lblLiveColor_DoubleClick);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.ForeColor = System.Drawing.Color.Transparent;
            this.txtTitle.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTitle.Location = new System.Drawing.Point(278, 6);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(306, 44);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "希姐说";
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.DoubleClick += new System.EventHandler(this.txtTitle_DoubleClick);
            this.txtTitle.LostFocus += new System.EventHandler(this.txtTitle_LostFocus);
            // 
            // picAvatar
            // 
            this.picAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAvatar.Image = global::AmamiyaEditer.Properties.Resources.tou;
            this.picAvatar.Location = new System.Drawing.Point(695, 403);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(128, 128);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            this.picAvatar.DoubleClick += new System.EventHandler(this.picAvatar_DoubleClick);
            // 
            // frmAmamiyaTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 599);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblLiveColor);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNowTime);
            this.Controls.Add(this.lblLiveTime);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtTalk);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAmamiyaTalk";
            this.Text = "希姐说";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblClose;
        private MyForms.MyPictureBox picAvatar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ContextMenuStrip Setting;
        private System.Windows.Forms.ToolStripMenuItem setbackcolor;
        private System.Windows.Forms.ToolStripMenuItem setTextBoxColor;
        private System.Windows.Forms.ToolStripMenuItem setFont;
        private System.Windows.Forms.ToolStripMenuItem setForeColor;
        private System.Windows.Forms.ToolStripMenuItem reset;
        private System.Windows.Forms.ToolStripMenuItem resetSize;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.TextBox txtTalk;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLiveTime;
        private System.Windows.Forms.Label lblLiveColor;
        private System.Windows.Forms.TextBox txtTitle;
    }
}

