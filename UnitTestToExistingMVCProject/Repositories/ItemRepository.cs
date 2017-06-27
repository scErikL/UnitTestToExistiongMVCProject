using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitTestToExistingMVCProject.DataAccess;
using UnitTestToExistingMVCProject.Models;

namespace UnitTestToExistingMVCProject.Repositories
{
    public class ItemRepository
    {
        ItemContext context = new ItemContext();

        public IEnumerable<Item> GetAll()
        {
            return context.Items.ToList();
        }

        public IEnumerable<Item> Search(string searchTerm)
        {
            return context.Items.Where(
                i => i.Name.Contains(searchTerm) ||
                i.Category.Contains(searchTerm));
        }
    }
}