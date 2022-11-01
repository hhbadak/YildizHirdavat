using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YildizHirdavat
{
    public class UserLogin
    {
        public string userName;
        public string password;
        public string name;

        public string Bring()
        {
            return $"Hoşgeldiniz, Sayın {name}";
        }
    }
}
