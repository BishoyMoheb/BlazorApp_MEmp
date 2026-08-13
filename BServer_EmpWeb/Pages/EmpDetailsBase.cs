using BServer_EmpWeb.RAPIServices;//To use IServeEmp
using CLib_MEmp;//To use MEmp
using Microsoft.AspNetCore.Components;//To use ComponentBase
using Microsoft.AspNetCore.Components.Web;//To use MouseEventArgs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    ///* Injecting and using IServeEmp */
    //public class EmpDetailsBase : ComponentBase
    //{
    //    public MEmp mEmp { get; set; } = new MEmp();

    //    [Inject]
    //    public IServeEmp serviceEmpI { get; set; }

    //    [Parameter]
    //    public string EmpId { get; set; }

    //    protected override async Task OnInitializedAsync()
    //    {
    //        EmpId = EmpId ?? "1";//In case no id was not stated
    //        mEmp = await serviceEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
    //    }
    //} 

    /* Adding the Event Handler Function */
    public class EmpDetailsBase : ComponentBase
    {
        public MEmp mEmp { get; set; } = new MEmp();

        protected string Coordinates { get; set; }

        protected string ButtonText { get; set; } = "Hide Footer";
        protected string CssClass { get; set; } = null;

        [Inject]
        public IServeEmp serviceEmpI { get; set; }

        [Parameter]
        public string EmpId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            EmpId = EmpId ?? "1";//In case no id was not stated
            mEmp = await serviceEmpI.S_Get_Emp_ByID(int.Parse(EmpId));
        }

        //protected void EH_MouseMove(MouseEventArgs mEventArgs)
        //{
        //    Coordinates = $"X-Co = {mEventArgs.ClientX} & Y-Co = {mEventArgs.ClientY}";
        //}

        protected void EH_HideShow()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                CssClass = "HideFooter";
            }
            else
            {
                ButtonText = "Hide Footer";
                CssClass = null;
            }
        }
    }
}
