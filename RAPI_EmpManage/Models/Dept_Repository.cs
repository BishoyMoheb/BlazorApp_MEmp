using CLib_MEmp;//To use MDep
using Microsoft.EntityFrameworkCore;//To use FirstOrDefaultAsync
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI_EmpManage.Models
{
    public class Dept_Repository : IDepRepository
    {
        private readonly AppDBContext _appDBContext;

        public Dept_Repository(AppDBContext appDBContext)
        {
            this._appDBContext = appDBContext;
        }

        ///* The default way */
        //public IEnumerable<MDep> GetAll_MDeps()
        //{
        //    //return _appDBContext.DbS_MDep;

        //    // Another rewritting
        //    var L_MDep = _appDBContext.DbS_MDep.ToList();
        //    return L_MDep;
        //}

        /* Make the method async */
        public async Task<IEnumerable<MDep>> GetAll_MDeps()
        {
            var L_MDep = await _appDBContext.DbS_MDep.ToListAsync();
            return L_MDep;
        }


        ///* The default way */
        //public MDep Get_MDep(int DepID)
        //{
        //    //return _appDBContext.DbS_MDep.FirstOrDefault(d => d.DepID == DepID);

        //    // Another rewritting
        //    var Dep_ToGet = _appDBContext.DbS_MDep.FirstOrDefault(d => d.DepID == DepID);
        //    return Dep_ToGet;
        //}

        /* Make the method async */
        public async Task< MDep> Get_MDep(int DepID)
        {
            var Dep_ToGet = await _appDBContext.DbS_MDep.FirstOrDefaultAsync(d => d.DepID == DepID);
            return Dep_ToGet;
        }
    }
}
