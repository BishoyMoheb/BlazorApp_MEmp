using CLib_MEmp;//To use models
using Microsoft.AspNetCore.Components;//To use GetJsonAsyn
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;//To use HttpClient
using System.Threading.Tasks;

namespace BServer_EmpWeb.RAPIServices
{
    public class ServeDep : IServeDep
    {
        private readonly HttpClient _hClient;

        public ServeDep(HttpClient hClient)
        {
            this._hClient = hClient;
        }

        public async Task<IEnumerable<MDep>> S_Get_AllDeps()
        {
            var L_Emp_Client = await _hClient.GetJsonAsync<MDep[]>("api/cr_dept");
            return L_Emp_Client;
        }

        public async Task<MDep> S_Get_Dep_ByID(int Dep_ID)
        {
            var Emp_Client = await _hClient.GetJsonAsync<MDep>($"api/cr_dept/{Dep_ID}");
            return Emp_Client;
        }
    }
}
