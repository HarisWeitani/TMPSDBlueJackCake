using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class DatabaseRepositories
    {
        private static MemberDatabaseEntities2 db = new MemberDatabaseEntities2();

        public static List<Member> getAllMember()
        {
            return db.Members.ToList<Member>();
        }

        public static Member LoginUser(string email, string password)
        {
            return db.Members.Where(m => m.Email == email && m.Password == password).FirstOrDefault();
        }

        public static int register(Member m)
        {
            db.Members.Add(m);
            return db.SaveChanges();
        }
        
        public static Member ForgotPassword(string email)
        {
            return db.Members.Find(email);
        }

    }
}