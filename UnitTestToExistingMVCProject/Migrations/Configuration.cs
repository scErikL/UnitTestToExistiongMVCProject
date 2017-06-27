namespace UnitTestToExistingMVCProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UnitTestToExistingMVCProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UnitTestToExistingMVCProject.DataAccess.ItemContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(UnitTestToExistingMVCProject.DataAccess.ItemContext context)
        {
            context.Items.AddOrUpdate(
                item=>item.ID,
                new Item { ID=1, Name="Skruvar", Category="Byggvara", Price=10.0},
                new Item { ID=2, Name="Bultar", Category="Byggvara", Price=10.0},
                new Item { ID=3, Name="Pneumatisk borr", Category="Byggvara", Price=1000.0},
                new Item { ID=4, Name="Jordfr�s", Category="Tr�dg�rd", Price=1000.0},
                new Item { ID=5, Name="Odlingsjord", Category="Tr�dg�rd", Price=50.0},
                new Item { ID=6, Name="Blomjord", Category="Tr�dg�rd", Price=50.0},
                new Item { ID=6, Name="Skottk�rra", Category="Tr�dg�rd", Price=350.0}
            );
        }
    }
}
