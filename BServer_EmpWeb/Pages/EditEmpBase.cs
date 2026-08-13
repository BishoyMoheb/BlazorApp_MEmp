using AutoMapper;
using BServer_EmpWeb.ModelSpecific;//To use MS_EditEmp
using BServer_EmpWeb.RAPIServices;//To use IServeEmp, IServeDep
using CLib_MEmp;//To use models
using Microsoft.AspNetCore.Components;//To use ComponentBase
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    ///* Starting point */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    public MEmp mEmp { get; set; } = new MEmp();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //    }
    //}

    ///* Adding the Department ID Name
    // * Fixing the non support type of System.Int32 in InputSelect*/
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    public MEmp mEmp { get; set; } = new MEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    public string DepId_Str { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        DepId_Str = mEmp.DeptID.ToString();
    //    }
    //}

    ///* The ideal way for fixing the non support type of System.Int32 in InputSelect
    // * is through creating a class RCL_Cust_InputSelect<TValue> that drives from 
    // * InputSelect<TValue> and then override TryParseValueFromString method */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    public MEmp mEmp { get; set; } = new MEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //    }
    //}

    ///* Using the specific model for EditEmp that contains ConfirmEmail property */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    private MEmp mEmp { get; set; } = new MEmp();

    //    public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        msEditEmp.EmpID = mEmp.EmpID;
    //        msEditEmp.FirstName = mEmp.FirstName;
    //        msEditEmp.LastName = mEmp.LastName;
    //        msEditEmp.Email = mEmp.Email;
    //        msEditEmp.ConfirmEmail = mEmp.Email;
    //        msEditEmp.DOBirth = mEmp.DOBirth;
    //        msEditEmp.GenderSex = mEmp.GenderSex;
    //        msEditEmp.PhotoPath = mEmp.PhotoPath;
    //        msEditEmp.DeptID = mEmp.DeptID;
    //        msEditEmp.Dep_Nav = mEmp.Dep_Nav;
    //    }
    //}

    ///* Using the AutoMapper to map between MS_EditEmp and MEmp */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    private MEmp mEmp { get; set; } = new MEmp();

    //    public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    [Inject]
    //    public IMapper MapperI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        MapperI.Map(mEmp, msEditEmp);
    //    }

    //    protected async Task HandleValidSubmit()
    //    {
    //        MapperI.Map(msEditEmp, mEmp);
    //        MEmp mEmpUpdated = await SerEmpI.S_Update_Emp(mEmp);
    //        if (mEmpUpdated != null)
    //            NavManager.NavigateTo("/");
    //    }
    //}

    ///* Modifying OnInitializedAsync & HandleValidSubmit methods for both edit 
    // * and create actions actions */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    private MEmp mEmp { get; set; } = new MEmp();

    //    public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    [Inject]
    //    public IMapper MapperI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        int.TryParse(EmpId, out int EID);
    //        if (EID != 0)
    //            mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        else
    //        {
    //            mEmp = new MEmp
    //            {
    //                DeptID = 1,
    //                DOBirth = DateTime.Now,
    //                PhotoPath = "Images/Emp_NoPhoto.png"
    //            };
    //        }
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        MapperI.Map(mEmp, msEditEmp);
    //    }

    //    protected async Task HandleValidSubmit()
    //    {
    //        MapperI.Map(msEditEmp, mEmp);
    //        MEmp mEmpAddedOrUpdated = null;
    //        if (mEmp.EmpID != 0)
    //            mEmpAddedOrUpdated = await SerEmpI.S_Update_Emp(mEmp);
    //        else
    //            mEmpAddedOrUpdated = await SerEmpI.S_Create_Emp(mEmp);
    //        if (mEmpAddedOrUpdated != null)
    //            NavManager.NavigateTo("/");
    //    }
    //}

    ///* Making dynamic work flow for Page Header Text */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    private MEmp mEmp { get; set; } = new MEmp();

    //    public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    public string PageHeaderText { get; set; }      

    //    [Inject]
    //    public IMapper MapperI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        int.TryParse(EmpId, out int EID);
    //        if (EID != 0)
    //        {
    //            PageHeaderText = "Edit Employee";
    //            mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        }
    //        else
    //        {
    //            PageHeaderText = "Create Employee";
    //            mEmp = new MEmp
    //            {
    //                DeptID = 1,
    //                DOBirth = DateTime.Now,
    //                PhotoPath = "Images/Emp_NoPhoto.png"
    //            };
    //        }
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        MapperI.Map(mEmp, msEditEmp);
    //    }

    //    protected async Task HandleValidSubmit()
    //    {
    //        MapperI.Map(msEditEmp, mEmp);
    //        MEmp mEmpAddedOrUpdated = null;
    //        if (mEmp.EmpID != 0)
    //            mEmpAddedOrUpdated = await SerEmpI.S_Update_Emp(mEmp);
    //        else
    //            mEmpAddedOrUpdated = await SerEmpI.S_Create_Emp(mEmp);
    //        if (mEmpAddedOrUpdated != null)
    //            NavManager.NavigateTo("/");
    //    }
    //}

    ///* Adding the delete method */
    //public class EditEmpBase : ComponentBase
    //{
    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    private MEmp mEmp { get; set; } = new MEmp();

    //    public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

    //    [Inject]
    //    public IServeDep SerDepI { get; set; }

    //    public List<MDep> L_mDep { get; set; } = new List<MDep>();

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    public string PageHeaderText { get; set; }

    //    [Inject]
    //    public IMapper MapperI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected Gen_RCLib.ReC_ConfirmBase DeleteConfirmation { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        int.TryParse(EmpId, out int EID);
    //        if (EID != 0)
    //        {
    //            PageHeaderText = "Edit Employee";
    //            mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //        }
    //        else
    //        {
    //            PageHeaderText = "Create Employee";
    //            mEmp = new MEmp
    //            {
    //                DeptID = 1,
    //                DOBirth = DateTime.Now,
    //                PhotoPath = "Images/Emp_NoPhoto.png"
    //            };
    //        }
    //        L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
    //        MapperI.Map(mEmp, msEditEmp);
    //    }

    //    protected async Task HandleValidSubmit()
    //    {
    //        MapperI.Map(msEditEmp, mEmp);
    //        MEmp mEmpAddedOrUpdated = null;
    //        if (mEmp.EmpID != 0)
    //            mEmpAddedOrUpdated = await SerEmpI.S_Update_Emp(mEmp);
    //        else
    //            mEmpAddedOrUpdated = await SerEmpI.S_Create_Emp(mEmp);
    //        if (mEmpAddedOrUpdated != null)
    //            NavManager.NavigateTo("/");
    //    }

    //    protected void HandleDeleting()
    //    {
    //        DeleteConfirmation.ShowDialog();
    //    }

    //    protected async Task EH_ConfirmDelete_Click(bool IsDeleteConfirmed)
    //    {
    //        if (IsDeleteConfirmed)
    //        {
    //            await SerEmpI.S_Delete_Emp(mEmp.EmpID);
    //            NavManager.NavigateTo("/");
    //        }
    //    }
    //}

    /* Prevent unAuthorized access to the component */
    public class EditEmpBase : ComponentBase
    {
        [CascadingParameter]
        public Task<AuthenticationState> AuthenState_Task { get; set; }

        [Inject]
        public IServeEmp SerEmpI { get; set; }

        private MEmp mEmp { get; set; } = new MEmp();

        public MS_EditEmp msEditEmp { get; set; } = new MS_EditEmp();

        [Inject]
        public IServeDep SerDepI { get; set; }

        public List<MDep> L_mDep { get; set; } = new List<MDep>();

        [Parameter]
        public string EmpId { get; set; }

        public string PageHeaderText { get; set; }

        [Inject]
        public IMapper MapperI { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }

        protected Gen_RCLib.ReC_ConfirmBase DeleteConfirmation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var ASTask = await AuthenState_Task;
            if (!ASTask.User.Identity.IsAuthenticated)
            {
                string ReturnURL = WebUtility.UrlEncode($"/editemp/{EmpId}");
                NavManager.NavigateTo($"/identity/account/login?returnUrl={ReturnURL}");
            }
            int.TryParse(EmpId, out int EID);
            if (EID != 0)
            {
                PageHeaderText = "Edit Employee";
                mEmp = await SerEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
            }
            else
            {
                PageHeaderText = "Create Employee";
                mEmp = new MEmp
                {
                    DeptID = 1,
                    DOBirth = DateTime.Now,
                    PhotoPath = "Images/Emp_NoPhoto.png"
                };
            }
            L_mDep = (await SerDepI.S_Get_AllDeps()).ToList();
            MapperI.Map(mEmp, msEditEmp);
        }

        protected async Task HandleValidSubmit()
        {
            MapperI.Map(msEditEmp, mEmp);
            MEmp mEmpAddedOrUpdated = null;
            if (mEmp.EmpID != 0)
                mEmpAddedOrUpdated = await SerEmpI.S_Update_Emp(mEmp);
            else
                mEmpAddedOrUpdated = await SerEmpI.S_Create_Emp(mEmp);
            if (mEmpAddedOrUpdated != null)
                NavManager.NavigateTo("/");
        }

        protected void HandleDeleting()
        {
            DeleteConfirmation.ShowDialog();
        }

        protected async Task EH_ConfirmDelete_Click(bool IsDeleteConfirmed)
        {
            if (IsDeleteConfirmed)
            {
                await SerEmpI.S_Delete_Emp(mEmp.EmpID);
                NavManager.NavigateTo("/");
            }
        }
    }
}
