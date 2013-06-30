using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dyForm.CControl;
using dyForm.CForm;
using System.Threading;
using DataLibrary;
using IM.Model;
using System.Net.Sockets;
using System.Net;
namespace IM
{
    public partial class FrmLogin : dyForm.CForm.NewSkinForm
    {
        bool isLoadding = false;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            BackGroundImage();

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
        }

        private void btnKeyBoard_Click(object sender, EventArgs e)
        {
            PassKey pk = new PassKey(this.Left + btnKeyBoard.Left - 110, this.Top + btnKeyBoard.Bottom+50 + pnlBase.Top, txtPwd);
            pk.Show(this);
        }

        Socket sok;
        Thread thread;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (isLoadding == false)
            //{
            //    isLoadding = true;

            //    foreach (Control myControls in this.pnlBase.Controls)
            //    {
            //        if (myControls.Name != "btnLogin" && myControls.Name != "btnHead" && myControls.Name != "pnlWhite")
            //        {
            //            myControls.Visible = false;
            //        }
            //    }

            //    this.btnMultiID.Visible = false;
            //    this.btnTwoDimension.Visible = false;
            //    this.picLoadding.Visible = true;

            //    btnLogin.Text = "取     消";
            //    while (btnHead.Left < 130)
            //    {
            //        btnHead.SetBounds(btnHead.Left += 15, btnHead.Top, btnHead.Width, btnHead.Height);
            //        Application.DoEvents();
            //        Thread.Sleep(20);
            //    }
            //    btnHead.SetBounds((380 - 85) / 2, btnHead.Top, btnHead.Width, btnHead.Height);
            //    Thread.Sleep(1000);
            //    this.MaximumSize = new System.Drawing.Size(0, 0);
            //    this.MinimumSize = new System.Drawing.Size(0, 0);
            //    int Height = this.Height;
            //    while (Height > 30)
            //    {
            //        this.SetBounds(this.Left, this.Top, this.Width, Height -= 30);
            //        Application.DoEvents();
            //        Thread.Sleep(10);
            //    }
            //    notifyIcon.Visible = false;
            //    this.Hide();

            //    FrmMain frmMain = new FrmMain();
            //    frmMain.Show();

            //}
            //else
            //{
            //    isLoadding = false;

            //    foreach (Control myControls in this.Controls)
            //    {
            //        myControls.Visible = true;
            //    }
            //    btnLogin.Text = "登     录";
            //    btnHead.SetBounds(15, 140, 85, 85);
            //}




            //string userNumber = txtID.Text.Trim();
            //string userPass = txtPwd.Text.Trim();
            //if (userNumber != "" && userPass != "")
            //{
            //    DataSet ds = SQLHelper.GetPasswordFormUserNumber(userNumber, userPass);
            //    if (ds.Tables["User"].Rows.Count > 0)
            //    {
            //        DataSet dsUser = SQLHelper.GetUserByNumber(userNumber);
            //        User user = new User();
            //        ///
            //        ///获取用户账号和昵称
            //        //
            //        user.userNumber = dsUser.Tables["User"].Rows[0]["UserNumber"].ToString();
            //        user.userNickName = dsUser.Tables["User"].Rows[0]["UserNickName"].ToString();


            //        //从数据库获取用户好友，将其加入一个列表备用
            //        //
            //        DataSet dsFriends = SQLHelper.GetFriendsByNumber(userNumber);
            //        List<string> friends = new List<string>();
            //        for (int i = 0; i < dsFriends.Tables["User"].Rows.Count; i++)
            //        {
            //            friends.Add(dsFriends.Tables["User"].Rows[i]["UserFriend"].ToString());
            //        }
            //        ///
            //        //加载用户好友信息
            //        ///
            //        List<User> userFriends = new List<User>();

            //        foreach (string id in friends)
            //        {
            //            DataSet dsd = SQLHelper.GetUserById(id);
            //            User u = new User();
            //            u.userNumber = dsd.Tables["User"].Rows[0]["UserNumber"].ToString();
            //            u.userNickName = dsd.Tables["User"].Rows[0]["UserNickName"].ToString();

            //            userFriends.Add(u);
            //        }
            //        //将好友信息加入到用户信息中
            //        user.friends = userFriends;

            //        //MessageBox.Show(user.userNumber);
            //        this.Hide();
            //        FrmMain frmMain = new FrmMain(user);
            //        frmMain.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("账号或密码错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}


            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8082);
                sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sok.Connect(endPoint);

                string userNumber = txtID.Text.Trim();
                string userPass = txtPwd.Text.Trim();

                string tmpUser = "LOGIN:" + userNumber + ":" + userPass;
                byte[] m = System.Text.Encoding.UTF8.GetBytes(tmpUser);
                sok.Send(m);


                byte[] tmp = new byte[1024 * 100];
                int n = sok.Receive(tmp);
                string s = System.Text.Encoding.UTF8.GetString(tmp, 0, n);
            
                if (s.Split(':')[0] == "Hello")
                {
                    User user = new User();
                    user.userNickName = s.Split(':')[3];
                    user.userNumber = s.Split(':')[6];

                    List<User> uFriends = new List<User>();
                    for (int i = 1; i < s.Split('<').Length-1; i+=2)
                    {
                        User u = new User();
                        u.userNickName = s.Split('<')[i];
                        u.userNumber = s.Split('<')[i + 1];
                        uFriends.Add(u);
                    }

                    user.friends = uFriends;

                    this.Hide();
                    FrmMain frmMain = new FrmMain(user);
                    frmMain.Show();
                
                }
                else if (s.Split(':')[0] == "ERROR")
                {
                    MessageBox.Show("用户名或密码错误！");
                }

                sok.Close();
            }
            catch
            {
                MessageBox.Show("服务器未打开！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

       

        private void btnFindPwd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("活该，谁叫你忘...          \n\n再注册一个去~~                \n\n   ╮(╯_╰)╭");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            while (pnlBase.Left > -this.Width + 60)
            {
                pnlBase.SetBounds(pnlBase.Left -= 60, pnlBase.Top, pnlBase.Width, pnlBase.Height);
                pnlRegister.SetBounds(pnlRegister.Left -= 60, pnlRegister.Top, pnlRegister.Width, pnlRegister.Height);
                Application.DoEvents();
                Thread.Sleep(25);
            }
            pnlBase.SetBounds(-382, pnlBase.Top, pnlBase.Width, pnlBase.Height);
            pnlRegister.SetBounds(0, pnlRegister.Top, pnlRegister.Width, pnlRegister.Height);
            Thread.Sleep(200);
            //this.BackColor = Color.FromArgb(186, 175, 111);
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = Properties.Resources.RegBackGround;
        }

        private void chkAutoLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoLogin.Checked == true)
            {
                chkRememberPwd.Checked = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            while (pnlRegister.Left < this.Width - 60)
            {
                pnlBase.SetBounds(pnlBase.Left += 60, pnlBase.Top, pnlBase.Width, pnlBase.Height);
                pnlRegister.SetBounds(pnlRegister.Left += 60, pnlRegister.Top, pnlRegister.Width, pnlRegister.Height);
                Application.DoEvents();
                Thread.Sleep(25);
            }
            pnlBase.SetBounds(-1, pnlBase.Top, pnlBase.Width, pnlBase.Height);
            pnlRegister.SetBounds(381, pnlRegister.Top, pnlRegister.Width, pnlRegister.Height);
            Thread.Sleep(200);
            BackGroundImage();
        }

        private void BackGroundImage()
        {
            int H = DateTime.Now.Hour;
            this.BackgroundImage =
                H > 5 & H <= 11 ? Properties.Resources.morning :
                H > 11 & H <= 16 ? Properties.Resources.noon :
                H > 16 & H <= 19 ? Properties.Resources.afternoon :
                Properties.Resources.night;
        }

        private void btnMultiID_Click(object sender, EventArgs e)
        {
            NewSkinForm form = new NewSkinForm();
            form.Show();
        }
    }
}
