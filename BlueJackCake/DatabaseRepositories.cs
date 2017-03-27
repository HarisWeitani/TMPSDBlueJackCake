using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class DatabaseRepositories
    {
        private static MyDatabaseEntities db = new MyDatabaseEntities();

        public static List<Member> getAllMember()
        {
            return db.Members.ToList<Member>();
        }

        public static Member LoginUser(String email, String password)
        {
            return db.Members.Where(m => m.Email == email && m.Password == password).FirstOrDefault();
        }



    }
}