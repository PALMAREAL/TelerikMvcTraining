﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.Data
{
    public class NorthwindDbContext : DbContext
    {

        public NorthwindDbContext() : base("name=NorthwindDbContext")
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<Meeting> Meetings { get; set; }

        public DbSet<MeetingAttendee> MeetingAttendees { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
