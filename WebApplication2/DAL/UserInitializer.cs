using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.MappingContext;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class UserInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Mvc2Context>
    {
        protected override void Seed(Mvc2Context context)
        {
            var users = new List<User>
            {
                new User {Fn = "A", Ln = "AL"},
                new User {Fn = "B", Ln = "AL"},
                new User {Fn = "C", Ln = "CL"}
            };

            users.ForEach(x => context.Users.Add(x));
            
            context.SaveChanges();

            base.Seed(context);
        }
    }
}