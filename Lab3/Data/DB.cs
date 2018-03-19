using Lab3.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Data
{
    public static class DB
    {
        public static List<User> Users = new List<User>();
        public static int id = 0;

        public static int NextId()
        {
            return id++;
        }

        public static void DeleteUser(int id)
        {
            var user = Users.Find(u => u.Id == id);
            Users.Remove(user);
        }
    }
}