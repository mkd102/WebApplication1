using Microsoft.AspNetCore.Identity;
using Unity;
using Unity.Injection;
using WebApplication1.Model;
using WebApplication1.Validation;

namespace WebApplication1.Factories
{
    public static class CorpFactory
    {
        public static IEmployeeBase GetEmployee(string EmployeeType)
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IValidation<EmployeeBase>, EmployeeBaseValidation>();

          //  IValidation<EmployeeBase> empValidation = new TempEmployeeValidation(new EmployeeBaseValidation());
            container.RegisterType<EmployeeBase, CorporateTempEmployee>("Temp", new InjectionConstructor(new TempEmployeeValidation(new EmployeeBaseValidation())));
           // empValidation = new PermEmployeeValidation(new EmployeeBaseValidation());
            container.RegisterType<EmployeeBase, CorporatePermEmployee>("Perm", new InjectionConstructor(new PermEmployeeValidation(new EmployeeBaseValidation())));

            return container.Resolve<EmployeeBase>(EmployeeType);
        }
    }

    public static class NonCorpFactory
    {
        public static IEmployeeBase GetEmployee(string EmployeeType)
        {
            IUnityContainer container = new UnityContainer();
          //  IValidation<EmployeeBase> empValidation = new TempEmployeeValidation(new EmployeeBaseValidation());

            container.RegisterType<EmployeeBase, NonCorporateTempEmployee>("Temp", new InjectionConstructor(new TempEmployeeValidation(new EmployeeBaseValidation())));
          //  empValidation = new PermEmployeeValidation(new EmployeeBaseValidation());

            container.RegisterType<EmployeeBase, NonCorporatePermEmployee>("Perm", new InjectionConstructor(new PermEmployeeValidation(new EmployeeBaseValidation())));
            return container.Resolve<EmployeeBase>();
        }
    }

   
}
