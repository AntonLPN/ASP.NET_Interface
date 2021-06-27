using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2.Controllers;
using Lab2.Models;
using Ninject.Modules;

namespace Lab2.Utils
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IInformationPerson>().To<MyClassPerssonInfo>().WhenInjectedExactlyInto<HomeController>();
            Bind<ILibrary>().To<Library>();
        }
    }
}