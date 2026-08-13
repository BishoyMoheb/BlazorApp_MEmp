using CLib_MEmp;//To use MDep
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.RAPIServices
{
    public interface IServeDep
    {
        Task<IEnumerable<MDep>> S_Get_AllDeps();
        Task<MDep> S_Get_Dep_ByID(int DepID);
    }
}
