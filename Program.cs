using System;
using System.Linq;

namespace ISP_Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new OnlinShop())
            {
                User user1 = new User()
                {
                    Name = "Dima",
                    Phone = "+375293192632",
                    Money = 1300
                };
                User user2 = new User()
                {
                    Name = "Diana",
                    Phone = "+375293192632",
                    Money = 2280
                };
                User user3 = new User()
                {
                    Name = "Misha",
                    Phone = "+375293192632",
                    Money = 10000
                };

                db.Users.AddRange(user1, user2, user3);
                db.SaveChanges();

                Console.WriteLine("База данных:");
                PrintUsers(db);
                UpdLastUser(db);
                DelSecondUser(db);
                Console.WriteLine("База данных после изменений");
                PrintUsers(db);

                db.Database.EnsureDeleted();
            }
            Console.ReadLine();
        }
        private static void UpdLastUser(OnlinShop db)
        {
            User user = db.Users.First();
            user.Phone = "0000000000";
            user.Name = "Vova";
            db.Users.Update(user);
            db.SaveChanges();
        }
        private static void DelSecondUser(OnlinShop db)
        {
            User user = db.Users.Find(2);
            db.Users.Remove(user);
            db.SaveChanges();
        }

        private static void PrintUsers(OnlinShop db)
        {
            foreach (User user in db.Users)
            {
                Console.WriteLine(user);
            }
        }
    }
}
