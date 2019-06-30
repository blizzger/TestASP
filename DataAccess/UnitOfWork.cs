using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SuperLeagueDBContext _dbContext;
        public IPlayerRepository PlayerRepository { get; }
        public ITeamRepository TeamRepository { get; }
        public UnitOfWork(IPlayerRepository playerRepository, ITeamRepository teamRepository, SuperLeagueDBContext dBContext)
        {
            PlayerRepository = playerRepository;
            TeamRepository = teamRepository;
            _dbContext = dBContext;
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
