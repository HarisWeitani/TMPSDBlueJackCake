using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class DatabaseRepositories
    {
        //member
        private static MemberDatabaseEntities2 db = new MemberDatabaseEntities2();

        public static List<Member> getAllMember()
        {
            return db.Members.ToList<Member>();
        }

        public static List<Member> getAllMember(string email)
        {
            return db.Members.Where(c => c.Email == email).ToList<Member>();
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

        public static Member findEmail(string email)
        {
            return db.Members.Find(email);
        }

        public static int deleteMember(Member m)
        {
            db.Members.Remove(m);
            return db.SaveChanges();
        }

        public static void updateMember(Member m, string password)
        {
            m.Password = password;
        }

        public static int updateMember(List<Member> member, string password)
        {
            foreach (Member m in member)
            {
                updateMember(m, password);
            }
            return db.SaveChanges();
        }




    }
}