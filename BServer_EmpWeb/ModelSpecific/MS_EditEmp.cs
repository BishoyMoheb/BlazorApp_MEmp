using CLib_MEmp;//To use EGender
using CLib_MEmp.CustomizeValidation;//To use Validate_EmailDomain
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//To use Required, MinLength, Display, EmailAddress
using System.ComponentModel.DataAnnotations.Schema;//To use ForeignKey
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.ModelSpecific
{
    ///* Starting Point */
    //public class MS_EditEmp
    //{
    //    [Key]
    //    public int EmpID { get; set; }

    //    [Required]
    //    [MinLength(2)]
    //    [Display(Name = "First Name")]
    //    public string FirstName { get; set; }

    //    [Required]
    //    [Display(Name = "Last Name")]
    //    public string LastName { get; set; }

    //    [Required]
    //    [EmailAddress]
    //    [Validate_EmailDomain(AllowedDOMAIN = "ParthyBTech.com")]
    //    public string Email { get; set; }

    //    [Display(Name = "Confirm Email")]
    //    [CompareProperty("Email", ErrorMessage ="Email and Confirm Email must match")]
    //    public string ConfirmEmail { get; set; }

    //    public DateTime DOBirth { get; set; }

    //    public EGender GenderSex { get; set; }

    //    [ForeignKey("Dep_Nav")]
    //    [Required]
    //    public int DeptID { get; set; }

    //    public string PhotoPath { get; set; }

    //    public virtual MDep Dep_Nav { get; set; }
    //}

    /* Initializing the Complex Type MDep with new instance of the MDep class 
     * to avoid null reference exception on its property with Required validation */
    public class MS_EditEmp
    {
        [Key]
        public int EmpID { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Validate_EmailDomain(AllowedDOMAIN = "PBTech.com")]
        public string Email { get; set; }

        [Display(Name = "Confirm Email")]
        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        public DateTime DOBirth { get; set; }

        public EGender GenderSex { get; set; }

        [ForeignKey("Dep_Nav")]
        [Required]
        public int DeptID { get; set; }

        public string PhotoPath { get; set; }

        [ValidateComplexType]
        public virtual MDep Dep_Nav { get; set; } = new MDep();
    }
}
