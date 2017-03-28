using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class emailValidate
    {
        public static bool checkEmail(string email)
        {
            if (email.Split('@').Length != 2) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") - 1) return false;
            else if (email.IndexOf(".") == email.IndexOf("@") + 1) return false;
            return true;
        }

    }
}