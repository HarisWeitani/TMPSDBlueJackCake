using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class UserFactory
    {
        public static Member create(string email , string password, string name, DateTime dob, string phone, string address)
        {
            return new Member()
            {
                Email = email,
                Password = password,
                Name = name,
                DOB = dob,
                PhoneNumber = phone,
                Address = address,
                Type = "Customer"
            };
        }

    }
}