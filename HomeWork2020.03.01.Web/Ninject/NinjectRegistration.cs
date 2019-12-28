using HomeWork2020._03._01.AbstractModels;
using HomeWork2020._03._01.Services;
using Ninject.Modules;

namespace HomeWork2020._03._01.Web.Ninject
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            this.Bind(typeof(IRepository<>)).To(typeof(FileRepository<>)).WithConstructorArgument("filePath", @"S:\VisualStudio\ASP\HomeWork2020.03.01\HomeWork2020.03.01.Web\moneyBox.txt");
        }
    }
}