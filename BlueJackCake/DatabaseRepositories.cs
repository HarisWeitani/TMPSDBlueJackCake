using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class DatabaseRepositories
    {
        private static MemberDatabaseEntities1 db = new MemberDatabaseEntities1();

        public static List<Member> getAllMember()
        {
            return db.Members.ToList<Member>();
        }

        public static Member LoginUser(string email, string password)
        {
            return db.Members.Where(m => m.Email == email && m.Password == password).FirstOrDefault();
        }



    }
}