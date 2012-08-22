﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using AccountAtAGlance.Model;
using System.Configuration;

namespace AccountAtAGlance.Repository
{
    public class NewsAtAGlance : DbContext
    {
        public DbSet<News> News { get; set; }
        public DbSet<News> NewsUpdates { get; set; }
        public DbSet<News> Languages { get; set; }
        public DbSet<News> Locations { get; set; }
        public DbSet<News> Sections { get; set; }

        public NewsAtAGlance()
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings[1].ToString();
            Database.Initialize(true);
        }

        public int CleanNews(int newsUpdateId)
        {
            return Database.ExecuteSqlCommand("DeleteNews", newsUpdateId);
        }
    }
}
