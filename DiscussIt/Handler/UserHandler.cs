using DiscussIt.Model;
using DiscussIt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiscussIt.Handler
{
    public class UserHandler
    {
        public static User GetUser(string email, string password)
        {
            return UserRepository.GetUser(email, password);
        }

        public static User CreateUser(string name, string email, string password)
        {
            return UserRepository.CreateUser(name, email, password);
        }
    }
}