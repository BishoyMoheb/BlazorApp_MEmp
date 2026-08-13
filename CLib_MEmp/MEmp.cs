using CLib_MEmp.CustomizeValidation;//To use Validate_EmailDomain
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//To use Key
using System.ComponentModel.DataAnnotations.Schema;//To use ForeignKey
using System.Text;

namespace CLib_MEmp
{
    ///* The starting point */
    //public class MEmp
    //{
    //    public int EmpID { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string Email { get; set; }
    //    public DateTime DOBirth { get; set; }
    //    public Gender GenderSex { get; set; }
    //    public MDep Dept { get; set; }
    //    public string PhotoPath { get; set; }
    //}

    ///* Using validation attributes */
    //public class MEmp
    //{
    //    [Key]
    //    public int EmpID { get; set; }

    //    [Required]
    //    [MinLength(2)]
    //    public string FirstName { get; set; }

    //    [Required]
    //    public string LastName { get; set; }

    //    public string Email { get; set; }

    //    public DateTime DOBirth { get; set; }

    //    public Gender GenderSex { get; set; }

    //    public int DeptID { get; set; }

    //    public string PhotoPath { get; set; }
    //}

    ///* Using Navigation Property */
    //public class MEmp
    //{
    //    [Key]
    //    public int EmpID { get; set; }

    //    [Required]
    //    [MinLength(2)]
    //    public string FirstName { get; set; }

    //    [Required]
    //    public string LastName { get; set; }

    //    public string Email { get; set; }

    //    public DateTime DOBirth { get; set; }

    //    public EGender GenderSex { get; set; }

    //    [ForeignKey("Dep_Nav")]
    //    public int DeptID { get; set; }

    //    public string PhotoPath { get; set; }

    //    public virtual MDep Dep_Nav { get; set; }
    //}

    ///* Adding more validation attributes */
    //public class MEmp
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
    //    public string Email { get; set; }

    //    public DateTime DOBirth { get; set; }

    //    public EGender GenderSex { get; set; }

    //    [ForeignKey("Dep_Nav")]
    //    public int DeptID { get; set; }

    //    public string PhotoPath { get; set; }

    //    public virtual MDep Dep_Nav { get; set; }
    //}

    ///* Using custom validation attributes */
    //public class MEmp
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
    //    [Validate_EmailDomain]
    //    public string Email { get; set; }

    //    public DateTime DOBirth { get; set; }

    //    public EGender GenderSex { get; set; }

    //    [ForeignKey("Dep_Nav")]
    //    public int DeptID { get; set; }

    //    public string PhotoPath { get; set; }

    //    public virtual MDep Dep_Nav { get; set; }
    //}

    /* Modifying the custom validation attributes for reusable DOMAIN case */
    public class MEmp
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

        public DateTime DOBirth { get; set; }

        public EGender GenderSex { get; set; }

        [ForeignKey("Dep_Nav")]
        public int DeptID { get; set; }

        public string PhotoPath { get; set; }

        public virtual MDep Dep_Nav { get; set; }
    }
}
