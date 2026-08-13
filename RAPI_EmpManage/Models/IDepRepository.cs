using CLib_MEmp;//To use MDep
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI_EmpManage.Models
{
    ///* The default way */
    //public interface IDepRepository
    //{
    //    IEnumerable<MDep> GetAll_MDeps();
    //    MDep Get_MDep(int DepID);
    //}

    /* Make the interface async */
    public interface IDepRepository
    {
        Task<IEnumerable<MDep>> GetAll_MDeps();
        Task<MDep> Get_MDep(int DepID);
    }
}
