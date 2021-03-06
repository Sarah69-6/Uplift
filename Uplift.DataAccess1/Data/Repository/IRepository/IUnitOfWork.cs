﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess1.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        void Save();
    }
}
