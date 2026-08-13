using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLib_MEmp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RAPI_EmpManage.Models;

namespace RAPI_EmpManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CR_Dept : ControllerBase
    {
        private readonly IDepRepository _depRepositoryI;

        public CR_Dept(IDepRepository depRepositoryI)
        {
            this._depRepositoryI = depRepositoryI;
        }

        [HttpGet]
        public async Task<ActionResult> Do_GetAll_MDeps()
        {
            try
            {
                return Ok(await _depRepositoryI.GetAll_MDeps());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from Database");
            }
        }

        [HttpGet("{DepID:int}")]
        public async Task<ActionResult<MDep>> Do_Get_MDep(int DepID)
        {
            try
            {
                var Dep_ToCheck = await _depRepositoryI.Get_MDep(DepID);
                if (Dep_ToCheck == null)
                    return NotFound();
                return Dep_ToCheck;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from Database");
            }
        }
    }
}
