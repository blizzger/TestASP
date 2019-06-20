using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SuperLeagueDBContext : DbContext
    {
        protected SuperLeagueDBContext() : base("name=SuperLeagueDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SuperLeagueDBContext>());

            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
