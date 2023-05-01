namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.MetaDocContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.MetaDocContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //Random random = new Random();

            //for (int i = 1; i <= 10; i++)
            //{
            //    context.Doctors.AddOrUpdate(new Models.Doctor
            //    {
            //        Name = Guid.NewGuid().ToString().Substring(0, 20),
            //        Email = Guid.NewGuid().ToString().Substring(0, 6) + "@gmail.com",
            //        Contact = "01" + random.Next(111111111, 999999999),
            //        Username = Guid.NewGuid().ToString().Substring(0, 8),
            //        Password = Guid.NewGuid().ToString().Substring(0, 10),
            //        Degree = "MBBS",
            //        Chamber = "Dhaka"
            //    });
            //}

            //for (int i = 1; i <= 15; i++)
            //{
            //    context.Patients.AddOrUpdate(new Models.Patient
            //    {
            //        Name = Guid.NewGuid().ToString().Substring(0, 20),
            //        Email = Guid.NewGuid().ToString().Substring(0, 6) + "@gmail.com",
            //        Contact = "01" + random.Next(111111111, 999999999),
            //        Username = Guid.NewGuid().ToString().Substring(0, 8),
            //        Password = Guid.NewGuid().ToString().Substring(0, 10),
            //        Age = random.Next(17, 65),
            //        Gender = "Male",
            //        Profession = Guid.NewGuid().ToString().Substring(0, 7)
            //    });
            //}

            //for (int i = 1; i <=5; i++)
            //{
            //    context.Pharmacies.AddOrUpdate(new Models.Pharmacy
            //    {
            //        Name = Guid.NewGuid().ToString().Substring(0, 20),
            //        Username = Guid.NewGuid().ToString().Substring(0, 8),
            //        Password = Guid.NewGuid().ToString().Substring(0, 10),
            //        Location = "Dhaka"
            //    });
            //}
        }
    }
}
