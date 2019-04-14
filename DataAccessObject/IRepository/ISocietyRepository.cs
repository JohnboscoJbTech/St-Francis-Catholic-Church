﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObject.DataModel;

namespace DataAccessObject.IRepository
{
    public interface ISocietyRepository
    {
        bool AddPosition(Position position);
        IQueryable<Position> GetPositions();
    }
}
