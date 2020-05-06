using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess1.Data.Repository.IRepository
{
    public interface ISP_Call
    {
        IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null);

        void ExecuteWithoutReturn(string procedureName, DynamicParameters param = null);

        T ExecuteReturnScaler<T>(string procedureName, DynamicParameters param = null);
    }
}
