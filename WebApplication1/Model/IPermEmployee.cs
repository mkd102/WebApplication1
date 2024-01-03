using WebApplication1.Validation;

namespace WebApplication1.Model
{
    public abstract class PermEmployee: EmployeeBase
    {
        public PermEmployee(IValidation<EmployeeBase> validation) : base(validation)
        {
        }


    }
}
