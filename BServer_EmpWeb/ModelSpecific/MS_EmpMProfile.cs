using AutoMapper;
using CLib_MEmp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BServer_EmpWeb.ModelSpecific
{
    ///* Starting Point */
    //public class MS_EmpMProfile : Profile
    //{
    //    public MS_EmpMProfile()
    //    {
    //        CreateMap<MEmp, MS_EditEmp>();
    //        CreateMap<MS_EditEmp, MEmp>();
    //    }
    //}

    /* Customize Mapper Profile class to map unmatching properties between 
     * the source and destination */
    public class MS_EmpMProfile : Profile
    {
        public MS_EmpMProfile()
        {
            CreateMap<MEmp, MS_EditEmp>()
                     .ForMember(dest => dest.ConfirmEmail,
                                MOptions => MOptions.MapFrom(src => src.Email));
            CreateMap<MS_EditEmp, MEmp>();
        }
    }
}
