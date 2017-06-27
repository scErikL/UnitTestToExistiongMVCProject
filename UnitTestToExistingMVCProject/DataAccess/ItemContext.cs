using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UnitTestToExistingMVCProject.Models;

namespace UnitTestToExistingMVCProject.DataAccess
{
    public class ItemContext: DbContext
    {
        public ItemContext() : base("DefaultConnection") { }

        public DbSet<Item> Items { get; set; }
    }
}