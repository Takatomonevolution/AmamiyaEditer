using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AmamiyaEditer
{
    public partial class frmAmamiyaTalk : Form
    {
        private Point p;
        //private bool isEnterBox;
        private bool isMouseDown;
        private ColorDialog colorDia;
        private MouseDirection direction = MouseDirection.None;//表示拖动的方向，起始为None，表示不拖动
        private bool isShowNowLbl = true;
        private bool isShowLiveLbl = true;
        private bool isEdge = false;

        private TimeSpan nowTS;
        private TimeSpan openTS;
        private bool sFlash = false;
        //private string path = "";
        //private string oldStr = "";
        //private string speekText = "";
        private Process process = new Process();  //创建进程对象
        private byte[] bytes1 = new byte[1024];
        private DateTime dt1970;
        private int timeDifference;

        public frmAmamiyaTalk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.BackColor = Properties.Settings.Default._backcolor;
            this.Size = Properties.Settings.Default._size;
            txtTalk.Font = Properties.Settings.Default._font;
            txtTalk.ForeColor = Properties.Settings.Default._forecolor;
            txtTalk.BackColor = Properties.Settings.Default._textboxcolor;
            Setting.BackColor = Properties.Settings.Default._textboxcolor;
            //Rectangle screen =  Screen.GetWorkingArea(this);
            Location = Properties.Settings.Default._location;
            lblNowTime.Text = timeFormat(DateTime.Now.Hour) + " : " + timeFormat(DateTime.Now.Minute);
            openTS = DateTime.Now - dt1970;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            this.Cursor = Cursors.Arrow;
            p = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //label1.Text = e.Location.Y.ToString();
            isMouseDown = false;
            direction = MouseDirection.None; //既然鼠标弹起了，那么就不能再改变窗体尺寸，拖拽方向置 none
            Properties.Settings.Default._size = this.Size;//使用Save方法保存更改
            Properties.Settings.Default.Save();//使用Save方法保存更改
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {   
            if (e.Location.X >= this.Width - 24 && e.Location.Y > this.Height - 24)
            {
                this.Cursor = Cursors.SizeNWSE;
                if (isMouseDown)
                {
                    direction = MouseDirection.Declining;
                }
            }
            else if (e.Location.X >= this.Width - 12 && direction != MouseDirection.Declining)
            {
                this.Cursor = Cursors.SizeWE;
                if (isMouseDown)
                {
                    direction = MouseDirection.Herizontal;
                }
            }
            else if (e.Location.Y >= this.Height - 12 && direction != MouseDirection.Declining)
            {
                this.Cursor = Cursors.SizeNS;
                if (isMouseDown)
                {
                    direction = MouseDirection.Vertical;
                }
            }
            else
            {
                this.Cursor = Cursors.Arrow;
            }
            ResizeWindow();
            if (direction == MouseDirection.Vertical || direction == MouseDirection.Herizontal || direction == MouseDirection.Declining)
                return;
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeAll;
                Location = new Point((Location.X + (e.X - p.X)), (Location.Y + (e.Y - p.Y)));
                Properties.Settings.Default._location = Location;
                Properties.Settings.Default.Save();
            }
        }

        private void ResizeWindow()
        {
            if (!isMouseDown) return;
            if (direction == MouseDirection.Declining)
            {
                this.Cursor = Cursors.SizeNWSE;
                this.Width = MousePosition.X - this.Left;
                this.Height = MousePosition.Y - this.Top;
            }
            if (direction == MouseDirection.Herizontal)
            {
                this.Cursor = Cursors.SizeWE;
                this.Width = MousePosition.X - this.Left;
            }
            else if (direction == MouseDirection.Vertical)
            {
                this.Cursor = Cursors.SizeNS;
                this.Height = MousePosition.Y - this.Top;
            }
            else this.Cursor = Cursors.Arrow;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1_MouseDown(sender, e);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            Form1_MouseMove(sender, e);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Tomato;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Transparent;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            lblMin.BackColor = Color.Aqua;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            lblMin.BackColor = Color.Transparent;
        }

        private void setbackcolor_Click(object sender, EventArgs e)
        {
            colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDia.Color;
                BackColor = color;
                Properties.Settings.Default._backcolor = color;
                Properties.Settings.Default.Save();
            }
        }

        private void setTextBoxColor_Click(object sender, EventArgs e)
        {
            colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDia.Color;
                txtTalk.BackColor = color;
                Properties.Settings.Default._textboxcolor = color;
                Properties.Settings.Default.Save();
            }
        }

        private void setFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDia = new FontDialog();
            fontDia.Font = txtTalk.Font;
            if (fontDia.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDia.Font;
                txtTalk.Font = font;
                Properties.Settings.Default._font = font;
                Properties.Settings.Default.Save();
            }
        }

        private void setForeColor_Click(object sender, EventArgs e)
        {
            colorDia = new ColorDialog();
            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDia.Color;
                txtTalk.ForeColor = color;
                Properties.Settings.Default._forecolor = color;
                Properties.Settings.Default.Save();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtTalk.ForeColor = Color.Black;
            txtTalk.Font = new Font("Microsoft YaHei", 42);
            BackColor = Color.FromArgb(153, 180, 203);
            txtTalk.BackColor = Color.FromArgb(191, 205, 219);
            Properties.Settings.Default._forecolor = Color.Black;
            Properties.Settings.Default._font = new Font("Microsoft YaHei", 42);
            Properties.Settings.Default._backcolor = Color.FromArgb(153, 180, 203);
            Properties.Settings.Default._textboxcolor = Color.FromArgb(191, 205, 219);
            Properties.Settings.Default.Save();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if(isMouseDown)
            {
                this.Cursor = Cursors.SizeAll;
                Location = new Point(Location.X + (e.X - p.X), Location.Y + (e.Y - p.Y));
            }
            */
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            lblTitle.Text = "textBox1_GotFocus";
            txtTalk.Focus();
            //txtTalk.Select(txtTalk.TextLength, 0);
            //txtTalk.ScrollToCaret();
        }

        private void resetSize_Click(object sender, EventArgs e)
        {
            Size = new Size(863, 599);
            Rectangle screen =  Screen.GetWorkingArea(this);
            Location = new Point((screen.Width - Size.Width) / 2, (screen.Height - Size.Height) / 2);
            //Location = Properties.Settings.Default._location;
            Properties.Settings.Default._size = Size;
            Properties.Settings.Default._location = Location;
            Properties.Settings.Default.Save();
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Form1_MouseUp(sender, e);
        }

        private void txtTalk_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            if(e.KeyCode == Keys.Enter)
            {
                speekText = txtTalk.Lines[txtTalk.Lines.GetUpperBound(0) - 1].ToString();
                //MessageBox.Show(speekText);
                if(!speekText.Trim().Equals(string.Empty))
                {
                    Execute();
                }
                //lblTitle.Text = speekText;
            }
            */
        }

        public string Execute()
        {
            /*
            path = Directory.GetCurrentDirectory();// + "test.js";
            path = path.Substring(0, path.Length - 10) + "\\google-tts\\node_modules\\google-tts-api\\example\\";
            string codeStart = "\"use strict\";var googleTTS = require('..');googleTTS('";
            string codeEnd = "', 'zh').then(console.log).catch(console.error); ";
            if (!oldStr.Equals(speekText.Trim()))
            {
                string str = codeStart + speekText + codeEnd;
                oldStr = speekText.Trim();
                bytes1 = Encoding.UTF8.GetBytes(str);
                FileStream fst = null;
                try
                {
                    fst = new FileStream(path + "chinese.js", FileMode.Create, System.IO.FileAccess.Write);
                    fst.Write(bytes1, 0, bytes1.Length);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    fst.Close();
                }
            }
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            string frame = path.Substring(0, System.Windows.Forms.Application.StartupPath.IndexOf('\\'));
            string strRst = "";
            try
            {
                process.Start();
                process.StandardInput.WriteLine(frame);
                process.StandardInput.WriteLine("cd " + path);
                process.StandardInput.WriteLine("node chinese.js");
                process.StandardInput.WriteLine("exit");
                strRst = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
            }
            finally
            {
                process.Close();  //进程结束
            }
            String sStart = "https://";
            string sEnd = "&ttsspeed=1";
            string url = sStart + Regex.Match(strRst, "(?<=" + sStart + ").*?(?=" + sEnd + ")").Value + sEnd;  //参数：输入、模式

            /*
            if(wbsSpeed == null)
            {
                wbsSpeed = new WebKitBrowser();
            }
            //wbsSpeed.Navigate(url);//wbsSpeed.Navigate(url);
            //wbsSpeed.Dispose();
            txtTalk.Focus();
            txtTalk.Select(txtTalk.TextLength, 0);
            txtTalk.ScrollToCaret();
            */
            return "";
        }

        private void frmAmamiyaTalk_Click(object sender, EventArgs e)
        {
            txtTalk.Focus();
            txtTalk.Select(txtTalk.TextLength, 0);
            txtTalk.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isShowNowLbl)
            {
                if (sFlash)
                {
                    lblNowTime.Text = timeFormat(DateTime.Now.Hour) + " : " + timeFormat(DateTime.Now.Minute);
                }
                else if (!sFlash)
                {
                    lblNowTime.Text = timeFormat(DateTime.Now.Hour) + "   " + timeFormat(DateTime.Now.Minute);
                }
            }
            sFlash = !sFlash;

            nowTS = DateTime.Now - dt1970;
            timeDifference = Convert.ToInt32(nowTS.TotalMinutes - openTS.TotalMinutes);
            if (isShowLiveLbl)
            {
                lblLiveTime.Text = timeFormat(timeDifference / 60) + " : " + timeFormat(timeDifference % 60);
                lblLiveColor.Visible = false;
            }
            else if (!isShowLiveLbl)
            {
                lblLiveTime.Text = "";
                lblLiveColor.Visible = true;
            }
        }

        private string timeFormat(int data)
        {
            return String.Format("{0:D2}", data);
        }

        private void lblLiveTime_DoubleClick(object sender, EventArgs e)
        {
            isShowLiveLbl = !isShowLiveLbl;
            showLblLive();
            showLblTime();
        }

        private void lblNowTime_DoubleClick(object sender, EventArgs e)
        {
            isShowNowLbl = !isShowNowLbl;
            showLblNow();
            showLblTime();
        }

        private void showLblTime()
        {
            if (!isEdge && !isShowLiveLbl && !isShowNowLbl)
            {
                txtTalk.Size = new Size(txtTalk.Size.Width, txtTalk.Size.Height + 42);
                picAvatar.Location = new Point(picAvatar.Location.X, picAvatar.Location.Y + 42);
                lblLiveTime.Location = new Point(lblLiveTime.Location.X, lblLiveTime.Location.Y + 40);
                lblNowTime.Location = new Point(lblNowTime.Location.X, lblNowTime.Location.Y + 40);
                lblLiveColor.Location = new Point(lblLiveColor.Location.X, lblLiveColor.Location.Y + 24);
                //lblLiveTime.BackColor = Properties.Settings.Default._textboxcolor;
                //lblNowTime.BackColor = Properties.Settings.Default._textboxcolor;
                //lblLiveColor.Visible = true;
                isEdge = true;
            }
            else if (isEdge && (isShowLiveLbl || isShowNowLbl))
            {
                txtTalk.Size = new Size(txtTalk.Size.Width, txtTalk.Size.Height - 42);
                picAvatar.Location = new Point(picAvatar.Location.X, picAvatar.Location.Y - 42);
                lblLiveTime.Location = new Point(lblLiveTime.Location.X, lblLiveTime.Location.Y - 40);
                lblNowTime.Location = new Point(lblNowTime.Location.X, lblNowTime.Location.Y - 40);
                lblLiveColor.Location = new Point(lblLiveColor.Location.X, lblLiveColor.Location.Y - 24);
                //lblLiveTime.BackColor = Color.Transparent;
                //lblNowTime.BackColor = Color.Transparent;
                //lblLiveColor.Visible = false;
                isEdge = false;
            }
        }

        private void showLblNow()
        {
            if (!isShowNowLbl)
            {
                lblNowTime.Text = "";
            }
            else if(isShowNowLbl)
            {
                sFlash = true;
            }
        }

        private void showLblLive()
        {
            nowTS = DateTime.Now - dt1970;
            timeDifference = Convert.ToInt32(nowTS.TotalMinutes - openTS.TotalMinutes);
            if (timeDifference / 60 >= 4)
            {
                lblLiveTime.ForeColor = Color.Pink;
                lblLiveColor.BackColor = Color.Pink;
            }
            else if (timeDifference / 60 < 2)
            {
                lblLiveTime.ForeColor = Color.Transparent;
                lblLiveColor.BackColor = Color.White;
            }
            else if (timeDifference / 60 >= 2)
            {
                lblLiveTime.ForeColor = Color.Khaki;
                lblLiveColor.BackColor = Color.Khaki;
            }
        }

        private void lblLiveColor_DoubleClick(object sender, EventArgs e)
        {
            lblLiveTime_DoubleClick(sender, e);
        }
    }

    /// <summary>
    /// 定义一个枚举，表示拖动方向
    /// </summary>
    public enum MouseDirection
    {
        Herizontal,//水平方向拖动，只改变窗体的宽度       
        Vertical,//垂直方向拖动，只改变窗体的高度
        Declining,//倾斜方向，同时改变窗体的宽度和高度       
        None//不做标志，即不拖动窗体改变大小
    }
}
