using DiscussIt.Factory;
using DiscussIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Repository
{
    public class UserRepository
    {
        private static readonly DiscussItDatabaseEntities DatabaseEntity = new DiscussItDatabaseEntities();

        public static User GetUser(string email, string password)
        {
            User user = DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email) && x.UserPassword.Equals(password)).FirstOrDefault();

            return user;
        }

        private static bool IsEmailRegistered(string email)
        {
            if (DatabaseEntity.Users.Where(x => x.UserEmail.Equals(email)).FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }

        public static User CreateUser(string name, string email, string password)
        {
            if (IsEmailRegistered(email))
            {
                return null;
            }

            User u = UserFactory.CreateUser(name, email, password);
  
            DatabaseEntity.Users.Add(u);
            DatabaseEntity.SaveChanges();
            return u;
        }
    }
}