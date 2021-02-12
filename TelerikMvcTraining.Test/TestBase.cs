using AutoMapper;
using TelerikMvcTraining.AutoMapper;

namespace TelerikMvcTraining.Test
{
    public abstract class TestBase
    {
        public IMapper Mapper { get; set; }

        public TestBase()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ProductProfile());
                cfg.AddProfile(new CategoryProfile());
            });

            Mapper = mapperConfiguration.CreateMapper();
        }
    }
}