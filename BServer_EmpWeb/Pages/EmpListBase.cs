using BServer_EmpWeb.RAPIServices;//To use IServeEmp
using CLib_MEmp;//To use MEmp
using Microsoft.AspNetCore.Components;//To use ComponentBase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    public class EmpListBase : ComponentBase
    {
        public IEnumerable<MEmp> E_MEmpI { get; set; }

        public IEnumerable<MDep> E_MDepI { get; set; }

        ///* Starting point */
        //private void LoadEmps()
        //{
        //    MEmp emp1 = new MEmp
        //    {
        //        EmpID = 1,
        //        FirstName = "Samy",
        //        LastName = "Hanna",
        //        Email = "Samy.Hanna@PBTech.com",
        //        GenderSex = Gender.Male,
        //        DOBirth = new DateTime(1977, 05, 24),
        //        Dept = new MDep { DepID = 1, DepName = "IT" },
        //        PhotoPath = "Images/Emp_Samy.png"
        //    };

        //    MEmp emp2 = new MEmp
        //    {
        //        EmpID = 2,
        //        FirstName = "Etve",
        //        LastName = "Samy",
        //        Email = "Etve.Samy@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1987, 08, 14),
        //        Dept = new MDep { DepID = 2, DepName = "PayRoll" },
        //        PhotoPath = "Images/Emp_Etve.png"
        //    };

        //    MEmp emp3 = new MEmp
        //    {
        //        EmpID = 3,
        //        FirstName = "Parthy",
        //        LastName = "Pisho",
        //        Email = "Parthy.Pisho@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1997, 10, 07),
        //        Dept = new MDep { DepID = 2, DepName = "PayRoll" },
        //        PhotoPath = "Images/Emp_Parthy.png"
        //    };

        //    Enum_MEmpI = new List<MEmp> { emp1, emp2, emp3 };

        //}

        //protected override Task OnInitializedAsync()
        //{
        //    LoadEmps();
        //    return base.OnInitializedAsync();
        //}


        ///* Loading spin */
        //private void LoadEmps()
        //{
        //    // Introducing a delay to resemble the real world
        //    System.Threading.Thread.Sleep(3000);
        //    MEmp emp1 = new MEmp
        //    {
        //        EmpID = 1,
        //        FirstName = "Samy",
        //        LastName = "Hanna",
        //        Email = "Samy.Hanna@PBTech.com",
        //        GenderSex = Gender.Male,
        //        DOBirth = new DateTime(1977, 05, 24),
        //        Dept = new MDep { DepID = 1, DepName = "IT" },
        //        PhotoPath = "Images/Emp_Samy.png"
        //    };

        //    MEmp emp2 = new MEmp
        //    {
        //        EmpID = 2,
        //        FirstName = "Etve",
        //        LastName = "Samy",
        //        Email = "Etve.Samy@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1987, 08, 14),
        //        Dept = new MDep { DepID = 2, DepName = "PayRoll" },
        //        PhotoPath = "Images/Emp_Etve.png"
        //    };

        //    MEmp emp3 = new MEmp
        //    {
        //        EmpID = 3,
        //        FirstName = "Parthy",
        //        LastName = "Pisho",
        //        Email = "Parthy.Pisho@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1997, 10, 07),
        //        Dept = new MDep { DepID = 2, DepName = "PayRoll" },
        //        PhotoPath = "Images/Emp_Parthy.png"
        //    };

        //    Enum_MEmpI = new List<MEmp> { emp1, emp2, emp3 };

        //}


        ///* Changing the type and the name of Dept to be DeptID */
        //private void LoadEmps()
        //{
        //    // Introducing a delay to resemble the real world
        //    System.Threading.Thread.Sleep(3000);
        //    MEmp emp1 = new MEmp
        //    {
        //        EmpID = 1,
        //        FirstName = "Samy",
        //        LastName = "Hanna",
        //        Email = "Samy.Hanna@PBTech.com",
        //        GenderSex = Gender.Male,
        //        DOBirth = new DateTime(1977, 05, 24),
        //        DeptID = 1,
        //        PhotoPath = "Images/Emp_Samy.png"
        //    };

        //    MEmp emp2 = new MEmp
        //    {
        //        EmpID = 2,
        //        FirstName = "Etve",
        //        LastName = "Samy",
        //        Email = "Etve.Samy@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1987, 08, 14),
        //        DeptID = 2,
        //        PhotoPath = "Images/Emp_Etve.png"
        //    };

        //    MEmp emp3 = new MEmp
        //    {
        //        EmpID = 3,
        //        FirstName = "Parthy",
        //        LastName = "Pisho",
        //        Email = "Parthy.Pisho@PBTech.com",
        //        GenderSex = Gender.Female,
        //        DOBirth = new DateTime(1997, 10, 07),
        //        DeptID = 2,
        //        PhotoPath = "Images/Emp_Parthy.png"
        //    };

        //    E_MEmpI = new List<MEmp> { emp1, emp2, emp3 };

        //}

        //protected override async Task OnInitializedAsync()
        //{
        //    // Adding await keyword as the method become async
        //    await Task.Run(LoadEmps);
        //}

        ///* Injecting the service that will load the Rest API data in Blazor Web Server*/
        //[Inject]
        //public IServeEmp SEmpI { get; set; }

        //protected override async Task OnInitializedAsync()
        //{
        //    E_MEmpI = (await SEmpI.S_Get_AllEmps()).ToList();
        //}

        ///* Show or hide footer */
        //[Inject]
        //public IServeEmp SEmpI { get; set; }

        //public bool Is_Footer_Visible { get; set; } = true;

        //public string Lbl_Value { get; set; } = string.Empty;

        //protected override async Task OnInitializedAsync()
        //{
        //    E_MEmpI = (await SEmpI.S_Get_AllEmps()).ToList();
        //}

        ///* Communicating Child component to Parent component using EventCallback */
        //[Inject]
        //public IServeEmp SEmpI { get; set; }

        //public bool Is_Footer_Visible { get; set; } = true;

        //public string Lbl_Value { get; set; } = string.Empty;

        //protected override async Task OnInitializedAsync()
        //{
        //    E_MEmpI = (await SEmpI.S_Get_AllEmps()).ToList();
        //}

        //protected int Emp_SelectionNum { get; set; } = 0;

        //protected void EH_EmpSelectionChange(bool IsSelected)
        //{
        //    if (IsSelected)
        //        Emp_SelectionNum++;
        //    else
        //        Emp_SelectionNum--;
        //}

        /* Communicating the Deleting in Child component to Parent component 
         * using EventCallback */
        [Inject]
        public IServeEmp SEmpI { get; set; }

        public bool Is_Footer_Visible { get; set; } = true;

        public string Lbl_Value { get; set; } = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            E_MEmpI = (await SEmpI.S_Get_AllEmps()).ToList();
        }

        protected async Task EH_EmpDeletedAsync()
        {
            E_MEmpI = (await SEmpI.S_Get_AllEmps()).ToList();
        }

        protected int Emp_SelectionNum { get; set; } = 0;

        protected void EH_EmpSelectionChange(bool IsSelected)
        {
            if (IsSelected)
                Emp_SelectionNum++;
            else
                Emp_SelectionNum--;
        }
    }
}
