namespace EntityUppgift.Migrations
{
    using EntityUppgift.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityUppgift.Data.EntityUppgiftContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityUppgift.Data.EntityUppgiftContext context)
        {

            // Kampanjer
            //context.Campaign.AddOrUpdate(new Campaign()
            //{
            //    CampaignID = 1,
            //    CampaignName = "Helgrea",
            //    Discount = 0.90
            //});
            //context.Campaign.AddOrUpdate(new Campaign()
            //{
            //    CampaignID = 2,
            //    CampaignName = "Mejerirea",
            //    Discount = 0.88
            //});

            // Inventeringar
            //context.Inventory.AddOrUpdate(new Inventory()
            //{
            //    InventoryID = 1,
            //    InventoryDate = 20210105
            //});
            //context.Inventory.AddOrUpdate(new Inventory()
            //{
            //    InventoryID = 2,
            //    InventoryDate = 20210106
            //});
            // Avdelningar
            context.Department.AddOrUpdate(new Department()
            {
                DepartmentID = 1,
                DepartmentName = "Mejeri"
            });
            context.Department.AddOrUpdate(new Department()
            {
                DepartmentID = 2,
                DepartmentName = "Frukt"
            });
            context.Department.AddOrUpdate(new Department()
            {
                DepartmentID = 3,
                DepartmentName = "Skafferi"
            });
            //context.Department.AddOrUpdate(new Department()
            //{
            //    DepartmentID = 4,
            //    DepartmentName = "Dryck"
            //});
            context.Department.AddOrUpdate(new Department()
            {
                DepartmentID = 5,
                DepartmentName = "Bröd"
            });
            //context.Department.AddOrUpdate(new Department()
            //{
            //    DepartmentID = 6,
            //    DepartmentName = "Köttdisken"
            //});

            // Produkter
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 1,
                ProductName = "Ost",
                Balance = 9,
                Price = 89,
                ExpirationDate = 20210921,
                TableofContent = "Grädde"
            });
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 2,
                ProductName = "Äpple",
                Balance = 15,
                Price = 5,
                ExpirationDate = 20210202,
                TableofContent = "Vitaminer, vatten"
            });
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 3,
                ProductName = "Pasta",
                Balance = 20,
                Price = 25,
                ExpirationDate = 20210624,
                TableofContent = "Vete"
            });
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 4,
                ProductName = "Coca-Cola",
                Balance = 25,
                Price = 10,
                ExpirationDate = 20211121,
                TableofContent = "Massor av socker",
                Department = new List<Department>()
                {
                    new Department()
                    {
                        DepartmentID = 4,
                        DepartmentName = "Dryck",
                        Person = new Person()
                        {
                            PersonID = 3,
                            PersonName = "Kurt Hansson",
                            PersonNr = 5610100000,
                            PhoneNr = 0707101113,
                            HomeNr = 019101114
                        }
                    }
                },
                Campaign = new List<Campaign>()
                {
                    new Campaign()
                    {
                        CampaignID = 2,
                        CampaignName = "Mejerirea",
                        Discount = 0.88
                    }
                }
            });
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 5,
                ProductName = "Lantbröd",
                Balance = 3,
                Price = 31,
                ExpirationDate = 20210109,
                TableofContent = "Vete, socker, jäst"
            });
            context.Product.AddOrUpdate(new Product()
            {
                ProductID = 6,
                ProductName = "Kassler",
                Balance = 3,
                Price = 89,
                ExpirationDate = 20210111,
                TableofContent = "Protein",
                Department = new List<Department>()
                {
                    new Department()
                    {
                        DepartmentID = 6,
                        DepartmentName = "Köttdisken",
                        Person = new Person()
                        {
                            PersonID = 1,
                            PersonName = "Klas Göransson",
                            PersonNr = 8010100000,
                            PhoneNr = 0707101112,
                            HomeNr = 019101112
                        }
                    }
                },
                Campaign = new List<Campaign>()
                {
                    new Campaign()
                    {
                        CampaignID = 1,
                        CampaignName = "Helgrea",
                        Discount = 0.90
                    }
                }
            });

            // Anställda
            //context.Person.AddOrUpdate(new Person()
            //{
            //    PersonID = 1,
            //    PersonName = "Klas Göransson",
            //    PersonNr = 8010100000,
            //    PhoneNr = 0707101112,
            //    HomeNr = 019101112
            //});
            context.Person.AddOrUpdate(new Person()
            {
                PersonID = 2,
                PersonName = "Bertil Klaesson",
                PersonNr = 8310100000,
                PhoneNr = 0707101122,
                HomeNr = 019101122,
                Inventory = new List<Inventory>()
                {
                    new Inventory()
                    {
                        InventoryID = 1,
                        InventoryDate = 20210105
                    },
                    new Inventory()
                    {
                        InventoryID = 2,
                        InventoryDate = 20210106
                    }
                }
            }); ;
            //context.Person.AddOrUpdate(new Person()
            //{
            //    PersonID = 3,
            //    PersonName = "Kurt Hansson",
            //    PersonNr = 5610100000,
            //    PhoneNr = 0707101113,
            //    HomeNr = 019101114
            //});
            context.Person.AddOrUpdate(new Person()
            {
                PersonID = 4,
                PersonName = "Emma Dahl",
                PersonNr = 9010100000,
                PhoneNr = 0707101312,
                HomeNr = 019103112
            });
            context.Person.AddOrUpdate(new Person()
            {
                PersonID = 5,
                PersonName = "Lina Nielsen",
                PersonNr = 8710100200,
                PhoneNr = 0707101412,
                HomeNr = 019701112
            });
            context.Person.AddOrUpdate(new Person()
            {
                PersonID = 6,
                PersonName = "Siv Jansson",
                PersonNr = 5710100000,
                PhoneNr = 0707156112,
                HomeNr = 019121112
            });





            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
