using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLib_MEmp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RAPI_EmpManage.Models;//To use IEmpRepository

namespace RAPI_EmpManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CR_Emp : ControllerBase
    {
        private readonly IEmpRepository _empRepositoryI;

        public CR_Emp(IEmpRepository empRepositoryI)
        {
            this._empRepositoryI = empRepositoryI;
        }


        [HttpGet]
        public async Task<ActionResult> Do_GetAll_MEmps()
        {
            try
            {
                return Ok(await _empRepositoryI.GetAll_MEmps());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from Database");
            }
        }


        [HttpGet("{EmpID:int}")]
        public async Task<ActionResult<MEmp>> Do_Get_MEmp(int EmpID)
        {
            try
            {
                var Emp_ToCheck = await _empRepositoryI.Get_MEmp(EmpID);
                if (Emp_ToCheck == null)
                    return NotFound();
                return Emp_ToCheck;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retrieving data from Database");
            }
        }


        [HttpPost]
        public async Task<ActionResult<MEmp>> Do_Add_MEmp(MEmp emp)
        {
            try
            {
                if (emp == null)
                    return BadRequest();
                // Check if the Employee Email already exists
                var Check_EmpEmail = await _empRepositoryI.Get_MEmp_ByEmail(emp.Email);
                if (Check_EmpEmail != null)
                {
                    ModelState.AddModelError("Email", $"This email {emp.Email} is already in USE");
                    return BadRequest(ModelState);
                }
                var Emp_ToAdd = await _empRepositoryI.Add_MEmp(emp);
                return CreatedAtAction(nameof(Do_Get_MEmp), new { id = Emp_ToAdd.EmpID },
                                       Emp_ToAdd);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error adding data to the Database");
            }
        }


        ///* Starting Point */
        //[HttpPut("{EmpID:int}")]
        //public async Task<ActionResult<MEmp>> Do_Update_MEmp(int EmpID, MEmp emp)
        //{
        //    try
        //    {
        //        if (EmpID != emp.EmpID)
        //            return BadRequest("Employee ID mismatch");
        //        var Emp_ToGet = await _empRepositoryI.Get_MEmp(emp.EmpID);
        //        if (Emp_ToGet == null)
        //            return NotFound($"Employee with ID = {EmpID} is not found");
        //        var Emp_Updated = await _empRepositoryI.Update_MEmp(emp);
        //        return Emp_Updated;
        //    }
        //    catch (Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError,
        //                           "Error updating data in the Database");
        //    }
        //}

        /* Simplify the action method */
        [HttpPut]
        public async Task<ActionResult<MEmp>> Do_Update_MEmp(MEmp empToUpdate)
        {
            try
            {
                var Emp_ToGet = await _empRepositoryI.Get_MEmp(empToUpdate.EmpID);
                if (Emp_ToGet == null)
                    return NotFound($"Employee with ID = {empToUpdate.EmpID} is not found");
                var Emp_Updated = await _empRepositoryI.Update_MEmp(empToUpdate);
                return Emp_Updated;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error updating data in the Database");
            }
        }


        [HttpDelete("{EmpID:int}")]
        public async Task<ActionResult<MEmp>> Do_Delete_MEmp(int EmpID)
        {
            try
            {
                var Emp_ToGet = await _empRepositoryI.Get_MEmp(EmpID);
                if (Emp_ToGet == null)
                    return NotFound($"Employee with ID = {EmpID} is not found");
                var Emp_Deleted = await _empRepositoryI.Delete_MEmp(EmpID);
                return Emp_Deleted;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error deleting data from the Database");
            }
        }


        [HttpGet("{Search}")]
        public async Task<ActionResult<MEmp>> Do_Search_MEmps(string Name, EGender gender)
        {
            try
            {
                var E_MEmps_I = await _empRepositoryI.Search_MEmps(Name, gender);
                if (E_MEmps_I.Any())
                    return Ok(E_MEmps_I);
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                   "Error retreiving the searched data from the Database");
            }
        }
    }
}

