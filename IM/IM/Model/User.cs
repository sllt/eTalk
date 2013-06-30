using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IM.Model
{
    /// <summary>
    /// 保存用户信息
    /// </summary>
    public class User
    {
        public string userNumber;   //eTalk号码

        public string userNickName; //昵称
        public string status;       //用户状态
        public IPAddress ip;        //当前用户IP
        public List<User> friends=null; //用户好友列表
    }
}
