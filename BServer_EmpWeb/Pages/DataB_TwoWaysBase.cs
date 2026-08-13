using Microsoft.AspNetCore.Components;//To use ComponentBase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.Pages
{
    public class DataB_TwoWaysBase : ComponentBase
    {
        public string DB_Description { get; set; } = string.Empty;
    }
}
