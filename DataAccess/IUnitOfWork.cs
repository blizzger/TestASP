﻿using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IUnitOfWork
    {
        IPlayerRepository PlayerRepository { get; }
        ITeamRepository TeamRepository { get; }
        void Commit();
    }
}
