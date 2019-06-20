using System;
using System.Data.Entity;
using System.Linq;
using Model;

namespace DataAccess.Repositories
{
    class PlayerRepository : IPlayerRepository
    {
        private SuperLeagueDBContext _dbContext;
        public PlayerRepository(SuperLeagueDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void Add(Player entity)
        {
            _dbContext.Players.Add(entity);
        }

        public void Delete(Player entity)
        {
            var entry = _dbContext.Entry(entity);
            if (entry == null || entry.State == EntityState.Detached)
            {
                _dbContext.Players.Attach(entity);
            }
            entry.State = EntityState.Deleted;
        }

        public Player GetById(int id)
        {
            return _dbContext.Players.SingleOrDefault(p => p.PlayerId == id);
        }

        public IQueryable<Player> List()
        {
            return _dbContext.Players;
        }

        public void Update(Player entity)
        {
            var entry = _dbContext.Entry(entity);
            if (entry == null || entry.State == EntityState.Detached)
            {
                _dbContext.Players.Attach(entity);
            }
            entry.State = EntityState.Modified;
        }
    }
}
