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
            });

            Mapper = config.CreateMapper();
        }
    }
}