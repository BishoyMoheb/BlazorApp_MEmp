using Microsoft.AspNetCore.Components;//To use ComponentBase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    public class DBinding_OneWayBase : ComponentBase
    {
        protected String DB_Name { get; set; } = "Parthy";
        protected string DB_Gender { get; set; } = "Female";
        protected string DB_Colour { get; set; } = "background-color: White";
    }
}
