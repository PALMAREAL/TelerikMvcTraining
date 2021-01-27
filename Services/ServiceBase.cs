using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Data.Repositories;

namespace TelerikMvcTraining.Services
{
    public abstract class ServiceBase
    {
        public IProductRepository ProductRepository { get; set; }

        public ServiceBase(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
    }
}