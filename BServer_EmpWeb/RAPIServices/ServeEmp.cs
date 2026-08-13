using CLib_MEmp;//To use models
using Microsoft.AspNetCore.Components;//To use GetJsonAsyn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;//To use HttpClient
using System.Threading.Tasks;

namespace BServer_EmpWeb.RAPIServices
{
    public class ServeEmp : IServeEmp
    {
        private readonly HttpClient _hClient;

        public ServeEmp(HttpClient hClient)
        {
            this._hClient = hClient;
        }

        public async Task<IEnumerable<MEmp>> S_Get_AllEmps()
        {
            var L_Emp_Client = await _hClient.GetJsonAsync<MEmp[]>("api/cr_emp");
            return L_Emp_Client;
        }

        public async Task<MEmp> S_Get_Emp_ByID(int Emp_ID)
        {
            var Emp_Client = await _hClient.GetJsonAsync<MEmp>($"api/cr_emp/{Emp_ID}");
            return Emp_Client;
        }

        public async Task<MEmp> S_Update_Emp(MEmp mEmpToUpdate)
        {
            var Emp_Client = await _hClient.PutJsonAsync<MEmp>("api/cr_emp/", mEmpToUpdate);
            return Emp_Client;
        }

        public async Task<MEmp> S_Create_Emp(MEmp mEmpToCreate)
        {
            var Emp_Client = await _hClient.PostJsonAsync<MEmp>("api/cr_emp/", mEmpToCreate);
            return Emp_Client;
        }

        public async Task S_Delete_Emp(int Emp_ID)
        {
            await _hClient.DeleteAsync($"api/cr_emp/{Emp_ID}");
        }
    }
}
