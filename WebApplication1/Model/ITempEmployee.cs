using WebApplication1.Validation;

namespace WebApplication1.Model
{
    public abstract class TempEmployee: EmployeeBase
    {
        public TempEmployee(IValidation<EmployeeBase> validation) : base(validation)
        {
        }


    }
}
