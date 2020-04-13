﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using StudentsManager.Data;

namespace StudentsManager.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build()
                .Seed();// Seed DataBase
    }
}
