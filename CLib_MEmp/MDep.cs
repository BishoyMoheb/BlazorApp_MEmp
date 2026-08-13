using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//To use Key
using System.Text;

namespace CLib_MEmp
{
    ///* Starting Point */
    //public class MDep
    //{
    //    [Key]
    //    public int DepID { get; set; }
    //    public string DepName { get; set; }
    //}

    /* Adding Required Validation */
    public class MDep
    {
        [Key]
        public int DepID { get; set; }

        [Required(ErrorMessage = "The Department Name field is required")]
        public string DepName { get; set; }
    }
}
