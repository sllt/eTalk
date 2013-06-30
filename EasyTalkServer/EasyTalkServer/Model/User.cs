using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace EasyTalkServer.Model
{
    class User
    {
        public string userNumber;   //eTalk号码

        public string userNickName; //昵称
        public string status;       //用户状态
        public IPAddress ip;        //当前用户IP
        public List<User> friends = null; //用户好友列表
    }
}
