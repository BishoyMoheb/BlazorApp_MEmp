using CLib_MEmp;//To use MEmp, MDep
using Microsoft.EntityFrameworkCore;//To use DbContext
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RAPI_EmpManage.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> DbCOptions_AppDbCon)
            :base(DbCOptions_AppDbCon)
        {
        }

        public DbSet<MEmp> DbS_MEmp { get; set; }
        public DbSet<MDep> DbS_MDep { get; set; }

        protected override void OnModelCreating(ModelBuilder MBuilder)
        {
            base.OnModelCreating(MBuilder);
            // Seed the MDep Table
            MBuilder.Entity<MDep>().HasData(new MDep { DepID = 1, DepName = "IT" });
            MBuilder.Entity<MDep>().HasData(new MDep { DepID = 2, DepName = "PayRoll" });
            MBuilder.Entity<MDep>().HasData(new MDep { DepID = 3, DepName = "HR" });
            // Seed the MEmp Table
            MBuilder.Entity<MEmp>().HasData(new MEmp
            {
                EmpID = 1,
                FirstName = "Samy",
                LastName = "Hanna",
                Email = "Samy.Hanna@PBTech.com",
                GenderSex = EGender.Male,
                DOBirth = new DateTime(1977, 05, 24),
                DeptID = 1,
                PhotoPath = "Images/Emp_Samy.png"
            });
            MBuilder.Entity<MEmp>().HasData(new MEmp
            {
                EmpID = 2,
                FirstName = "Etve",
                LastName = "Samy",
                Email = "Etve.Samy@PBTech.com",
                GenderSex = EGender.Female,
                DOBirth = new DateTime(1987, 08, 14),
                DeptID = 2,
                PhotoPath = "Images/Emp_Etve.png"

            });
            MBuilder.Entity<MEmp>().HasData(new MEmp
            {
                EmpID = 3,
                FirstName = "Parthy",
                LastName = "Pisho",
                Email = "Parthy.Pisho@PBTech.com",
                GenderSex = EGender.Female,
                DOBirth = new DateTime(1997, 10, 07),
                DeptID = 3,
                PhotoPath = "Images/Emp_Parthy.png"

            });
        }
    }
}

