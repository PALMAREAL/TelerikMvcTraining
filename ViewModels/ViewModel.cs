using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TelerikMvcTraining.Models;

namespace TelerikMvcTraining.ViewModels
{
    public abstract class ViewModel<TEntity> where TEntity : Entity
    {
    }
}