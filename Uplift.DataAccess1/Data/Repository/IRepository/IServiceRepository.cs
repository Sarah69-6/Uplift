﻿using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess1.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        void Update(Service service);
    }
}
