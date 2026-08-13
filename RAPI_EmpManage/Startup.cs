using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;//To use UseSqlServer
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RAPI_EmpManage.Models;//To use AppDBContext

namespace RAPI_EmpManage
{
    public class Startup
    {
        public Startup(IConfiguration config_i)
        {
            ConfigI = config_i;
        }

        public IConfiguration ConfigI { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection SerCollectionI)
        {
            SerCollectionI.AddControllers();
            SerCollectionI.AddDbContext<AppDBContext>
                (DbCOBuilder => DbCOBuilder.UseSqlServer(ConfigI.GetConnectionString("DBConn")));
            // Tieing together the repository interface with the implementation class
            SerCollectionI.AddScoped<IDepRepository, Dept_Repository>();
            SerCollectionI.AddScoped<IEmpRepository, EmpCrudRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder AppBuiderI, IWebHostEnvironment WHEnvI)
        {
            if (WHEnvI.IsDevelopment())
            {
                AppBuiderI.UseDeveloperExceptionPage();
            }

            AppBuiderI.UseRouting();

            AppBuiderI.UseAuthorization();

            AppBuiderI.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

