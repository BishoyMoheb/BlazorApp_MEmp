using CLib_MEmp;//To use MEmp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.RAPIServices
{
    public interface IServeEmp
    {
        Task<IEnumerable<MEmp>> S_Get_AllEmps();
        Task<MEmp> S_Get_Emp_ByID(int EmpID);
        Task<MEmp> S_Update_Emp(MEmp mEmpToUpdate);
        Task<MEmp> S_Create_Emp(MEmp mEmpToCreate);
        Task S_Delete_Emp(int EmpID);
    }
}
