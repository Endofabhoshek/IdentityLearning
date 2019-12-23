using IdentityUsers.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IdentityUsers.Infrastructure
{
    public class UserDbContext : IdentityDbContext<User>
    {
        public UserDbContext() : base("DbConnection")
        {

        }

        static UserDbContext()
        {
            Database.SetInitializer<UserDbContext>(new IdentityDbInit());
        }

        public static UserDbContext Create()
        {
            return new UserDbContext();
        }
    }
}