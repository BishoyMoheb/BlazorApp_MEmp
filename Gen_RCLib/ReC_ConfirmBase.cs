using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gen_RCLib
{
    public class ReC_ConfirmBase : ComponentBase
    {
        protected bool IsShowConfirmation { get; set; }

        public void ShowDialog()
        {
            IsShowConfirmation = true;
            StateHasChanged();
        }

        [Parameter]
        public string ConfirmTitle { get; set; } = "Delete Confirmation";

        [Parameter]
        public string ConfirmMessage { get; set; } = "Are you sure you want to delete";

        [Parameter]
        public EventCallback<bool> OnConfirmChanges { get; set; }

        protected async Task EH_ConfirmationChanges(bool BValue)
        {
            IsShowConfirmation = false;
            await OnConfirmChanges.InvokeAsync(BValue);
        }
    }
}
