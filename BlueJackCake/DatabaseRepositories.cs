using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class DatabaseRepositories
    {
        private static DatabaseEntities db = new DatabaseEntities();

        //member

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

        //cake

        public static List<Cake> getAllCake()
        {
            return db.Cakes.ToList<Cake>();
        }

        public static List<Cake> getAllCake(string cakeName)
        {
            return db.Cakes.Where(c => c.CakeName == cakeName).ToList<Cake>();
        }

        public static int addCake(Cake c)
        {
            db.Cakes.Add(c);
            return db.SaveChanges();
        }

        public static Cake findCake(string cakeName)
        {
            return db.Cakes.Find(cakeName);
        }

        public static int deleteCake(Cake c)
        {
            db.Cakes.Remove(c);
            return db.SaveChanges();
        }

        public static void updateCake(Cake c, string cakeName, int cakePrice, int cakeStock, string cakePic)
        {
            c.CakeName = cakeName;
            c.Price = cakePrice;
            c.Stock = cakeStock;
            c.Picture = cakePic;
        }

        public static int updateCake(List<Cake> cake, string cakeName, int cakePrice, int cakeStock, string cakePic)
        {
            foreach (Cake c in cake)
            {
                updateCake(c, cakeName, cakePrice, cakeStock, cakePic);
            }
            return db.SaveChanges();
        }
    }
}