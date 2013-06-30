using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IM.Model;
using dyForm.CControl;
using dyForm;
using dyForm.Win32;
using System.Net;
using System.Net.Sockets;
namespace IM
{
    public partial class FrmMain : dyForm.CForm.NewSkinForm
    {
        int PastId = 1;
        bool isFixed = true;
        bool isDown = false;
        bool isLoadOver = false;

        public FrmMain(User user)
        {
            InitializeComponent();
            lblName.Text = user.userNickName;

            foreach (User u in user.friends)
            {
                ChatListSubItem clst = new ChatListSubItem();

                clst.DisplayName = u.userNickName.ToString().Trim();
                clst.NicName = u.userNumber.ToString().Trim();
                this.friendList.Items[0].SubItems.Add(clst);

            }
            //this.friendList.Items[0].IsTwinkleHide = false;
            //this.friendList.Items[0].SubItems[1].IsTwinkle = true;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnSelectID.Focus();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);

            timer.Start();
            tmrLoad.Start();
            isLoadOver = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SlidePnl(Control pnl, int NewId)
        {
            if (NewId == PastId)
            {
                return;
            }
            pnlBase1.SetBounds(282, 0, 1, 1);
            pnlBase2.SetBounds(282, 10, 1, 1);
            pnlBase3.SetBounds(282, 20, 1, 1);
            pnlBase4.SetBounds(282, 30, 1, 1);
            pnlBase5.SetBounds(282, 40, 1, 1);
            if (NewId > PastId)
            {
                int temp = 60;
                for (int i = 0; i < 12; i++)
                {
                    pnl.SetBounds(temp -= 5, 0, 281, 400);
                    Application.DoEvents();
                    Thread.Sleep(5);
                }

            }
            else
            {
                int temp = -60;
                for (int i = 0; i < 12; i++)
                {
                    pnl.SetBounds(temp += 5, 0, 281, 400);
                    Application.DoEvents();
                    Thread.Sleep(5);
                }
            }
            PastId = NewId;
        }

        private void tssbLinkman_ButtonClick(object sender, EventArgs e)
        {
            SlidePnl(pnlBase1, 1);
        }

        private void tssbConversation_ButtonClick(object sender, EventArgs e)
        {
            SlidePnl(pnlBase2, 2);
        }

        private void tssbGroup_ButtonClick(object sender, EventArgs e)
        {
            SlidePnl(pnlBase3, 3);
        }

        private void tssbQzone_ButtonClick(object sender, EventArgs e)
        {
            SlidePnl(pnlBase4, 4);
        }

        private void tssbWeiBo_ButtonClick(object sender, EventArgs e)
        {
            SlidePnl(pnlBase5, 5);
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isFixed == true)
            {
                if (this.Top < 2)
                {
                    while (this.Bottom > 50)
                    {
                        this.SetBounds(this.Left, this.Top -= 50, this.Width, this.Height);
                        Application.DoEvents();
                        Thread.Sleep(20);
                    }
                    this.SetBounds(this.Left, -this.Height + 2, this.Width, this.Height);
                    isFixed = false;
                }
            }
            else
            {
                if (MousePosition.X > this.Left && MousePosition.X < this.Right
                    && MousePosition.Y < this.Bottom && MousePosition.Y > this.Top)
                {
                    if (isDown == false )
                    {
                        while (this.Top < -50)
                        {
                            this.SetBounds(this.Left, this.Top += 50, this.Width, this.Height);
                            Application.DoEvents();
                            Thread.Sleep(20);
                        }
                        isDown = true;
                        this.SetBounds(this.Left, -2, this.Width, this.Height);
                    }
                }
                else
                {
                    if (isDown == true && this.Top < 2)
                    {
                        while (this.Bottom > 50)
                        {
                            this.SetBounds(this.Left, this.Top -= 50, this.Width, this.Height);
                            Application.DoEvents();
                            Thread.Sleep(20);
                        }
                        this.SetBounds(this.Left, -this.Height + 2, this.Width, this.Height);
                        isDown = false;
                    }
                }
            }
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            if (isLoadOver==true)
            {
                isLoadOver = false;
                tmrLoad.Stop();

                this.MaximumSize = new System.Drawing.Size(0, 0);
                this.MinimumSize = new System.Drawing.Size(0, 0);
                Rectangle rect = new Rectangle();
                rect = Screen.GetWorkingArea(this);

                while(this.Left>rect.Width - this.Width - 50)
                {
                    this.SetBounds(this.Left -= 30, this.Top, this.Width, this.Height);
                    Application.DoEvents();
                    Thread.Sleep(15);
                }
                this.MinimumSize = new System.Drawing.Size(281, 660);
                this.MaximumSize = new System.Drawing.Size(281, 660);
                Thread.Sleep(1000);
                FrmNotification frmNotification = new FrmNotification();
                frmNotification.Show();
            }
        }

        private void friendList_DoubleClickSubItem(object sender, ChatListEventArgs e)
        {
            ChatListSubItem item = e.SelectSubItem;
            item.IsTwinkle = false;

            //bool isFormexist;
            string windowsName = "与 " + item.DisplayName + " 对话中";
            IntPtr handle = NativeMethods.FindWindow(null, windowsName);
            if (handle != IntPtr.Zero)
            {
                Form frm = (Form)Form.FromHandle(handle);
                frm.Activate();
                
            }
            else
            {
                TcpClient tc = new TcpClient();
                tc.Connect("127.0.0.1",8082);
                NetworkStream stream= tc.GetStream();


                byte [] onTmp=System.Text.Encoding.UTF8.GetBytes("Online:"+item.NicName);
                stream.Write(onTmp,0,onTmp.Length);

                byte[] ip = new byte[1024 * 80];
                int n=stream.Read(ip,0,1024*80);

                if (n != 0)
                {
                    string sIP = System.Text.Encoding.UTF8.GetString(ip, 0, n);

                    FrmChat frmChat = new FrmChat(item.DisplayName, item.NicName);
                    frmChat.Show();
                }
                else
                {
                    MessageBox.Show("此用户不在线！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tc.Close();
            }
        }

    }
}
