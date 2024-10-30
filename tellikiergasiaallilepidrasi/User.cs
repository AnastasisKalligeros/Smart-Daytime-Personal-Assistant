using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellikiergasiaallilepidrasi
{
    class User
    {
        public String Username { get; set; }

        public String Password { get; set; }

        public String HiUser()
        {
            return "Your username is: " + Username + " ";
        }

        public String MyPass()
        {
            return "Your password is: " + Password + " ";
        }
    }
}
