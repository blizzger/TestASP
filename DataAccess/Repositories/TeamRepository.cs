using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess.Repositories
{
    class TeamRepository : ITeamRepository
    {
        private readonly SuperLeagueDBContext _dbContext;
        public TeamRepository(SuperLeagueDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Team entity)
        {
            _dbContext.Teams.Add(entity);
        }

        public void Delete(Team entity)
        {
            var entry = _dbContext.Entry(entity);
            if (entry == null || entry.State == EntityState.Deleted)
            {
                _dbContext.Teams.Attach(entity);
            }
            entry.State = EntityState.Deleted;
        }

        public Team GetById(int id)
        {
            return _dbContext.Teams.SingleOrDefault(t => t.TeamId == id);
        }

        public IQueryable<Team> List()
        {
            return _dbContext.Teams;
        }

        public void Update(Team entity)
        {
            var entry = _dbContext.Entry(entity);
            if (entry == null || entry.State == EntityState.Deleted)
            {
                _dbContext.Teams.Attach(entity);
            }
            entry.State = EntityState.Modified;
        }
    }
}
