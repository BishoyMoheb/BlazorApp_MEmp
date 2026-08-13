using CLib_MEmp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI_EmpManage.Models
{
    public class EmpCrudRepository : IEmpRepository
    {
        private readonly AppDBContext _aDbContext;

        public EmpCrudRepository(AppDBContext ADbContext)
        {
            _aDbContext = ADbContext;
        }

        public async Task<MEmp> Add_MEmp(MEmp emp)
        {
            var Entity_Result = await _aDbContext.DbS_MEmp.AddAsync(emp);
            await _aDbContext.SaveChangesAsync();
            return Entity_Result.Entity;
        }

        ///* The void return type */
        //public async void Delete_MEmp(int EmpID)
        //{
        //    var Emp_ToDelete = await _aDbContext.DbS_MEmp
        //                                   .FirstOrDefaultAsync(e => e.EmpID == EmpID);
        //    if (Emp_ToDelete != null)
        //    {
        //        _aDbContext.DbS_MEmp.Remove(Emp_ToDelete);
        //        await _aDbContext.SaveChangesAsync();
        //    }
        //}

        /* Modifying the Delete_MEmp action method to return Task<MEmp> */
        public async Task<MEmp> Delete_MEmp(int EmpID)
        {
            var Emp_ToDelete = await _aDbContext.DbS_MEmp
                                           .FirstOrDefaultAsync(e => e.EmpID == EmpID);
            if (Emp_ToDelete != null)
            {
                _aDbContext.DbS_MEmp.Remove(Emp_ToDelete);
                await _aDbContext.SaveChangesAsync();
                return Emp_ToDelete;
            }
            return null;
        }


        ///* Short writting */
        //public async Task<IEnumerable<MEmp>> GetAll_MEmps()
        //{
        //    return await _aDbContext.DbS_MEmp.ToListAsync();
        //}


        /* Another rewritting */
        public async Task<IEnumerable<MEmp>> GetAll_MEmps()
        {
            var L_MEmp = await _aDbContext.DbS_MEmp.ToListAsync();
            return L_MEmp;
        }

        ///* Default way using short writting */
        //public async Task<MEmp> Get_MEmp(int EmpID)
        //{
        //    //return await _aDbContext.DbS_MEmp
        //    //                  .FirstOrDefaultAsync(e => e.EmpID == EmpID);
        //}

        ///* Default way and another rewritting */
        //public async Task<MEmp> Get_MEmp(int EmpID)
        //{
        //    var MEmp_ToGet = await _aDbContext.DbS_MEmp
        //                        .FirstOrDefaultAsync(e => e.EmpID == EmpID);
        //    return MEmp_ToGet;
        //}

        /* Linking tables together */
        public async Task<MEmp> Get_MEmp(int EmpID)
        {
            var MEmp_ToGet = await _aDbContext.DbS_MEmp
                                .Include(e => e.Dep_Nav)
                                .FirstOrDefaultAsync(e => e.EmpID == EmpID);
            return MEmp_ToGet;
        }

        ///* Short writting */
        //public async Task<MEmp> Get_MEmp_ByEmail(string Email)
        //{
        //    return await _aDbContext.DbS_MEmp
        //                      .FirstOrDefaultAsync(e => e.Email == Email);
        //}

        /* Another writting */
        public async Task<MEmp> Get_MEmp_ByEmail(string Email)
        {
            var MEmp_ToGet = await _aDbContext.DbS_MEmp
                                .FirstOrDefaultAsync(e => e.Email == Email);
            return MEmp_ToGet;
        }

        public async Task<MEmp> Update_MEmp(MEmp emp)
        {
            var Emp_ToUpdate = await _aDbContext.DbS_MEmp
                                        .FirstOrDefaultAsync(e => e.EmpID == emp.EmpID);
            if (Emp_ToUpdate != null)
            {
                Emp_ToUpdate.FirstName = emp.FirstName;
                Emp_ToUpdate.LastName = emp.LastName;
                Emp_ToUpdate.DOBirth = emp.DOBirth;
                Emp_ToUpdate.Email = emp.Email;
                Emp_ToUpdate.GenderSex = emp.GenderSex;
                Emp_ToUpdate.DeptID = emp.DeptID;
                Emp_ToUpdate.PhotoPath = emp.PhotoPath;
                await _aDbContext.SaveChangesAsync();
                return Emp_ToUpdate;
            }
            return null;
        }

        /* Adding the Search_MEmps action method of type Task<IEnumerable<MEmp>> */
        public async Task<IEnumerable<MEmp>> Search_MEmps(string Name, EGender? gender)
        {
            IQueryable<MEmp> qEmp_I = _aDbContext.DbS_MEmp;
            if (!string.IsNullOrEmpty(Name))
                qEmp_I = qEmp_I.Where(e => e.FirstName.Contains(Name)
                                         || e.LastName.Contains(Name));
            if (gender != null)
                qEmp_I = qEmp_I.Where(e => e.GenderSex == gender);
            var qList = await qEmp_I.ToListAsync();
            return qList;
        }
    }
}
