using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using dyForm.CControl;
namespace IM
{
    public partial class FrmChat : dyForm.CForm.NewSkinForm
    {
        string number = null;
        string NickName = "";

        NetworkStream ns;
        Thread thread;
        public FrmChat(string nickName,string number)
        {

            InitializeComponent();
            RichTextBox.CheckForIllegalCrossThreadCalls = false;
           
            //rtbReceive.BackColor = Color.White;
            this.Text = "与 " + nickName + " 对话中";
            lblChatName.Text = nickName;
            NickName = nickName;
            this.number = number;

            TcpClient client = new TcpClient("127.0.0.1", 8082);

            ns = client.GetStream();

            byte[] m = System.Text.Encoding.UTF8.GetBytes("Send:" + this.number + ":hello");
            ns.Write(m, 0, m.Length);

            thread = new Thread(Recv);
            thread.IsBackground = true;
            thread.Start();
            
        }

        void Recv()
        {
            while (true)
            {
                byte []b=new byte[1024*100];
                int n=ns.Read(b, 0, 1024 * 100);

                rtbReceive.Text += NickName + " " + string.Format("{0:T}\r\n    ", DateTime.Now) + System.Text.Encoding.UTF8.GetString(b,0,n);
            }
        }
        
        private void FrmChat_Load(object sender, EventArgs e)
        {

            //GetClient();
            

        }

        //private void Recv()
        //{
        //    while (true)
        //    {
        //        byte[] tmp = new byte[1024 * 100];
        //        int n = sok.Receive(tmp);
        //        string s = System.Text.Encoding.UTF8.GetString(tmp, 0, n);
        //        if (s != "")
        //        {
        //            rtbReceive.Text += s;
        //        }

        //    }
        //}
        public void GetClient()
        {
            TcpClient tc = new TcpClient();
            tc.Connect("127.0.0.1", 8082);
            NetworkStream stream = tc.GetStream();


            byte[] onTmp = System.Text.Encoding.UTF8.GetBytes("Online:"+number);
            stream.Write(onTmp, 0, onTmp.Length);

            byte[] ip = new byte[1024 * 80];
            int n = stream.Read(ip, 0, 1024 * 80);

            if (n != 0)
            {
                string sIP = System.Text.Encoding.UTF8.GetString(ip, 0, n);

                //mip = sIP.Split(':')[0];
                //mport = sIP.Split(':')[1];
                rtbReceive.Text += sIP;
            }
            else
            {
                MessageBox.Show("此用户不在线！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //tc.Close();
        }

        
        private void WinShake()
        {
            int l=2;
            int wait = 20;
            for (int i = 0; i < 2 ; i++)
            {
                this.SetBounds(this.Left += l, this.Top -= l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left , this.Top -= l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left -= l, this.Top -= l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left -= l, this.Top , this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left -= l, this.Top += l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left , this.Top += l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left += l, this.Top += l, this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
                this.SetBounds(this.Left += l, this.Top , this.Width, this.Height); Application.DoEvents(); Thread.Sleep(wait);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //string msg = rtbEdit.Text.ToString() + "\r\n";
            //byte[] m = System.Text.Encoding.UTF8.GetBytes(msg);
            //sok.Send(m);
            rtbReceive.Text += NickName + " " + string.Format("{0:T}\r\n    ", DateTime.Now) + rtbEdit.Text + "\r\n";
            

            byte[] m = System.Text.Encoding.UTF8.GetBytes("Send:" + this.number + ":" + rtbEdit.Text + "\r\n");
            ns.Write(m, 0, m.Length);

            rtbEdit.Text = "";
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //截图方法
        private FrmCapture m_frmCapture;
        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            if (m_frmCapture == null || m_frmCapture.IsDisposed)
                m_frmCapture = new FrmCapture(rtbEdit);
            m_frmCapture.IsCaptureCursor = false;
            m_frmCapture.Show();
        }

        //窗口抖动
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            WinShake();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog1.ShowDialog())
            {
                this.rtbEdit.Font = fontDialog1.Font;
                this.rtbEdit.ForeColor = fontDialog1.Color;
            }
        }
    }
}
