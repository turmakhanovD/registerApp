﻿using SecurityApp.Services;
using System.Data.Entity;

namespace SecurityApp.DataAccess
{
    public class DataInitializer : CreateDatabaseIfNotExists<SecurityContext>
    {
        protected override void Seed(SecurityContext context)
        {
            context.Users.Add(new Models.User
            {
                Login = "admin",
                Password = SecurityHasher.HashPassword("123ASD")
            });
        }
    }
}
