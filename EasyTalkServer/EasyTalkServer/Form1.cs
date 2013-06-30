using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DataLibrary;
using EasyTalkServer.Model;
namespace EasyTalkServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        Socket sok = null;
        bool tag = false;
        Dictionary<string, IPEndPoint> online = new Dictionary<string, IPEndPoint>();

        Dictionary<string, Socket> talk = new Dictionary<string, Socket>();
        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress adress = Dns.GetHostAddresses("cnhun.3322.org")[0];

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8082);
            sok = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            sok.Bind(endPoint);
            sok.Listen(10);
            Thread thread = new Thread(Watching);
            thread.IsBackground = true;
            thread.Start();
            tbMsg.Text += "服务器已启动...\r\n";
        }

        Socket clientSocket;
        private void Watching()
        {
            while (true)
            {
                clientSocket = sok.Accept();
                IPEndPoint tmp = (IPEndPoint)clientSocket.RemoteEndPoint;
                tbMsg.Text += tmp.Port.ToString()+"   已连接...\r\n";
                
                try
                {
                    byte[] tmpbyte = new byte[1024 * 100];
                    int n = clientSocket.Receive(tmpbyte);
                    string s = System.Text.Encoding.UTF8.GetString(tmpbyte, 0, n);
                    tbMsg.Text += s + "\r\n";
                    if (s.Split(':')[0] == "LOGIN")
                    {
                        string userNumber = s.Split(':')[1];
                        string userPass = s.Split(':')[2];
                        if (userNumber != "" && userPass != "")
                        {
                            DataSet ds = SQLHelper.GetPasswordFormUserNumber(userNumber, userPass);
                            string sUser = null;
                            if (ds.Tables["User"].Rows.Count > 0)
                            {



                                DataSet dsUser = SQLHelper.GetUserByNumber(userNumber);

                                string userNumber1 = dsUser.Tables["User"].Rows[0]["UserNumber"].ToString();
                                string userNickName1 = dsUser.Tables["User"].Rows[0]["UserNickName"].ToString();

                                string user = String.Format("((User:(UserName:{0}:,:UserNumber:{1})", userNickName1.Trim(), userNumber1);

                                DataSet dsFriends = SQLHelper.GetFriendsByNumber(userNumber);
                                List<string> friends = new List<string>();
                                if (dsFriends.Tables["User"].Rows.Count > 0)
                                {
                                    for (int i = 0; i < dsFriends.Tables["User"].Rows.Count; i++)
                                    {
                                        friends.Add(dsFriends.Tables["User"].Rows[i]["UserFriend"].ToString());
                                    }


                                    ///
                                    //加载用户好友信息
                                    ///
                                    List<User> userFriends = new List<User>();

                                    foreach (string id in friends)
                                    {
                                        DataSet dsd = SQLHelper.GetUserById(id);
                                        User u = new User();
                                        u.userNumber = dsd.Tables["User"].Rows[0]["UserNumber"].ToString();
                                        u.userNickName = dsd.Tables["User"].Rows[0]["UserNickName"].ToString();

                                        userFriends.Add(u);
                                    }



                                    foreach (User t in userFriends)
                                    {

                                        sUser += "<" + t.userNickName.Trim() + "<" + t.userNumber.Trim();
                                    }
                                    tbMsg.Text += sUser.Trim() + "\r\n";
                                }

                                tbMsg.Text += user + "\r\n";


                                byte[] b = System.Text.Encoding.UTF8.GetBytes("Hello:" + user + sUser);
                                clientSocket.Send(b);

                                online.Add(userNumber1, (IPEndPoint)clientSocket.RemoteEndPoint);
                            }
                            else
                            {

                                byte[] b = System.Text.Encoding.UTF8.GetBytes("ERROR:NULL");
                                clientSocket.Send(b);
                            }
                        }
                    }

                    if (s.Split(':')[0] == "Online")
                    {
                        tbMsg.Text += "test...\r\n";

                        tbMsg.Text += s.Split(':')[1]+"\r\n";

                        foreach (var a in online)
                        {
                            if (a.Key == s.Split(':')[1])
                            {
                                IPEndPoint tmpEndPoint = a.Value;

                                string tmpS = string.Format("{0}:{1}",tmpEndPoint.Address.ToString(),tmpEndPoint.Port.ToString());

                                byte[] tmpByte = System.Text.Encoding.UTF8.GetBytes(tmpS);
                                clientSocket.Send(tmpByte);
                                break;
                            }
                        }
                    }

                    if (s.Split(':')[0] == "Send")
                    {
                        talk.Add(s.Split(':')[1], clientSocket);
                        if (clientSocket != null)
                        {
                            Thread t = new Thread(Recv);
                            t.IsBackground = true;
                            t.Start();
                            //tag = true;
                        }
                    }


                    


                }
                catch (Exception ex)
                {
                    tbMsg.Text+= ex.Message.ToString();
                }


            }
        }


        private void Recv()
        {
            while (true)
            {
                try
                {
                    byte[] tmp = new byte[1024 * 100];
                    int n = clientSocket.Receive(tmp);
                    string s = System.Text.Encoding.UTF8.GetString(tmp, 0, n);
                    
                    string value=s.Split(':')[1];
                    Socket sTmp = talk[value];

                    byte[] b = System.Text.Encoding.UTF8.GetBytes(s.Split(':')[2]);
                    sTmp.Send(b);
                }
                catch
                {

                }

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] b = System.Text.Encoding.UTF8.GetBytes(tbSend.Text);
            clientSocket.Send(b);
        }
    }
}
