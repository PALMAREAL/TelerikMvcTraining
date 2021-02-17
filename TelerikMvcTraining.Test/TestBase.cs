using AutoMapper;
using System;
using TelerikMvcTraining.AutoMapper;
using TelerikMvcTraining.Models;
using TelerikMvcTraining.ViewModels;

namespace TelerikMvcTraining.Test
{
    public abstract class TestBase
    {
        public IMapper Mapper { get; set; }

        public TestBase()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new OrderProfile());
                cfg.AddProfile(new AddressProfile());
                cfg.AddProfile(new EmployeeProfile());
            });

            Mapper = config.CreateMapper();
        }
    }
}