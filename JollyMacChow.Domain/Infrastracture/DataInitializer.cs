using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollyMacChow.Domain.Infrastracture
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataAccess>
    {
        protected override void Seed(DataAccess db)
        {
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Kelvin Joseph",
                    LastName = "Ili",
                    Password = "12345",
                    UserName = "Kjili",
                    Role = Models.Enums.Role.Admin


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Joseph",
                    LastName = "Ili",
                    Password = "12345",
                    UserName = "Jili",
                    Role = Models.Enums.Role.Admin


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Harold",
                    LastName = "Cabalbag",
                    Password = "12345",
                    UserName = "Hcabalbag",
                    Role = Models.Enums.Role.Cashier


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Manny",
                    LastName = "Paksiw",
                    Password = "12345",
                    UserName = "Pacman",
                    Role = Models.Enums.Role.Cashier


                }



         );
            db.SaveChanges();
            db.Users.Add(
                    new Models.User()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = "Mammy",
                        LastName = "Di",
                        Password = "12345",
                        UserName = "Mdi",
                        Role = Models.Enums.Role.Waiter


                    }



             );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Gina",
                    LastName = "Cabalbag",
                    Password = "12345",
                    UserName = "G2cabalbag",
                    Role = Models.Enums.Role.Waiter


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Gladys",
                    LastName = "Cabalbag",
                    Password = "12345",
                    UserName = "G1cabalbag",
                    Role = Models.Enums.Role.InventoryController


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Loris",
                    LastName = "Cabalbag",
                    Password = "12345",
                    UserName = "Lcabalbag",
                    Role = Models.Enums.Role.InventoryController


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Manex",
                    LastName = "Cano",
                    Password = "12345",
                    UserName = "Mcano",
                    Role = Models.Enums.Role.Chef


                }



         );
            db.SaveChanges();
            db.Users.Add(
                new Models.User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jessa",
                    LastName = "dela cruz",
                    Password = "12345",
                    UserName = "Jdelacruz",
                    Role = Models.Enums.Role.Chef


                }



         );
            db.SaveChanges();


        }


    }
}
