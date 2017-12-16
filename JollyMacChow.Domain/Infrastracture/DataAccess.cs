using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollyMacChow.Domain.Infrastracture
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(
                new JollyMacChow.Domain.Infrastracture.DataInitializer()
             );
        }


        public DbSet<Models.User> Users { get; set; }
    }
}
