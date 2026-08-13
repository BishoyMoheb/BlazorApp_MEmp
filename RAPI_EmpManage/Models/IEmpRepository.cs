using CLib_MEmp;//To use MEmp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI_EmpManage.Models
{
    ///* Starting Point */
    //public interface IEmpRepository
    //{
    //    Task<IEnumerable<MEmp>> GetAll_MEmps();
    //    Task<MEmp> Get_MEmp(int EmpID);
    //    Task<MEmp> Add_MEmp(MEmp emp);
    //    Task<MEmp> Update_MEmp(MEmp emp);
    //    void Delete_MEmp(int EmpID);
    //}

    ///* Adding Get_MEmp_ByEmail */
    //public interface IEmpRepository
    //{
    //    Task<IEnumerable<MEmp>> GetAll_MEmps();
    //    Task<MEmp> Get_MEmp(int EmpID);
    //    Task<MEmp> Get_MEmp_ByEmail(string Email);
    //    Task<MEmp> Add_MEmp(MEmp emp);
    //    Task<MEmp> Update_MEmp(MEmp emp);
    //    void Delete_MEmp(int EmpID);
    //}

    ///* Modifying the Delete_MEmp action method to return Task<MEmp> */
    //public interface IEmpRepository
    //{
    //    Task<IEnumerable<MEmp>> GetAll_MEmps();
    //    Task<MEmp> Get_MEmp(int EmpID);
    //    Task<MEmp> Get_MEmp_ByEmail(string Email);
    //    Task<MEmp> Add_MEmp(MEmp emp);
    //    Task<MEmp> Update_MEmp(MEmp emp);
    //    Task<MEmp> Delete_MEmp(int EmpID);
    //}

    /* Adding the Search_MEmps action method of type Task<IEnumerable<MEmp>> */
    public interface IEmpRepository
    {
        Task<IEnumerable<MEmp>> GetAll_MEmps();
        Task<IEnumerable<MEmp>> Search_MEmps(string Name, EGender? gender);
        Task<MEmp> Get_MEmp(int EmpID);
        Task<MEmp> Get_MEmp_ByEmail(string Email);
        Task<MEmp> Add_MEmp(MEmp emp);
        Task<MEmp> Update_MEmp(MEmp emp);
        Task<MEmp> Delete_MEmp(int EmpID);
    }
}
