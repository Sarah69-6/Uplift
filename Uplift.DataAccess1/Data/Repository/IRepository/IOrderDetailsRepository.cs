using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess1.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess1.Data.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {

    }
}