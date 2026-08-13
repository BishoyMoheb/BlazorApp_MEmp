using BServer_EmpWeb.RAPIServices;
using CLib_MEmp;//To use MEmp
using Microsoft.AspNetCore.Components;//To use ComponentBase, EventCallback
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    ///* Starting point */
    //public class EmpCListBase : ComponentBase
    //{
    //    [Parameter]
    //    public MEmp mEmp { get; set; }

    //    [Parameter]
    //    public bool IsVisibleFooter { get; set; }
    //}

    ///* Creating Event Handler that will pass data to the Parent component */
    //public class EmpCListBase : ComponentBase
    //{
    //    [Parameter]
    //    public MEmp mEmp { get; set; }

    //    [Parameter]
    //    public bool IsVisibleFooter { get; set; }

    //    [Parameter]
    //    public EventCallback<bool> OnSelectingEmp { get; set; }

    //    protected async Task EH_ChangeCheckBox(ChangeEventArgs CEArgs)
    //    {
    //        await OnSelectingEmp.InvokeAsync((bool)CEArgs.Value);
    //    }
    //}

    ///* 1st way Event Handler for Deletion will be passed to the Parent component */
    //public class EmpCListBase : ComponentBase
    //{
    //    [Parameter]
    //    public MEmp mEmp { get; set; }

    //    [Parameter]
    //    public bool IsVisibleFooter { get; set; }

    //    [Parameter]
    //    public EventCallback<bool> OnSelectingEmp { get; set; }

    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected async Task EH_ChangeCheckBox(ChangeEventArgs CEArgs)
    //    {
    //        await OnSelectingEmp.InvokeAsync((bool)CEArgs.Value);
    //    }

    //    protected async Task EH_Deleting()
    //    {
    //        await SerEmpI.S_Delete_Emp(mEmp.EmpID);
    //        NavManager.NavigateTo("/", true);
    //    }
    //}

    ///* 2nd way Event Handler for Deletion will be passed to the Parent component
    // * by using custom events */
    //public class EmpCListBase : ComponentBase
    //{
    //    [Parameter]
    //    public MEmp mEmp { get; set; }

    //    [Parameter]
    //    public bool IsVisibleFooter { get; set; }

    //    [Parameter]
    //    public EventCallback<bool> OnSelectingEmp { get; set; }

    //    [Parameter]
    //    public EventCallback<int> OnDeletingEmp { get; set; }

    //    [Inject]
    //    public IServeEmp SerEmpI { get; set; }

    //    [Inject]
    //    public NavigationManager NavManager { get; set; }

    //    protected async Task EH_ChangeCheckBox(ChangeEventArgs CEArgs)
    //    {
    //        await OnSelectingEmp.InvokeAsync((bool)CEArgs.Value);
    //    }

    //    protected async Task EH_Deleting()
    //    {
    //        await SerEmpI.S_Delete_Emp(mEmp.EmpID);
    //        await OnDeletingEmp.InvokeAsync(mEmp.EmpID);
    //    }
    //}

    /* Adding Delete Confirmation to prevent accident deleting */
    public class EmpCListBase : ComponentBase
    {
        [Parameter]
        public MEmp mEmp { get; set; }

        [Parameter]
        public bool IsVisibleFooter { get; set; }

        [Parameter]
        public EventCallback<bool> OnSelectingEmp { get; set; }

        [Parameter]
        public EventCallback<int> OnDeletingEmp { get; set; }

        [Inject]
        public IServeEmp SerEmpI { get; set; }

        [Inject]
        public NavigationManager NavManager { get; set; }

        protected Gen_RCLib.ReC_ConfirmBase DeleteConfirmation { get; set; }

        protected async Task EH_ChangeCheckBox(ChangeEventArgs CEArgs)
        {
            await OnSelectingEmp.InvokeAsync((bool)CEArgs.Value);
        }

        protected async Task EH_ConfirmDelete_Click(bool IsDeleteConfirmed)
        {
            if (IsDeleteConfirmed)
            {
                await SerEmpI.S_Delete_Emp(mEmp.EmpID);
                await OnDeletingEmp.InvokeAsync(mEmp.EmpID);
            }
        }

        protected void EH_Deleting()
        {
            DeleteConfirmation.ShowDialog();
        }
    }
}
