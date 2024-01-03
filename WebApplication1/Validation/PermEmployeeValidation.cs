using WebApplication1.Model;

namespace WebApplication1.Validation
{
    public class PermEmployeeValidation : ValidationLInker
    {
        public PermEmployeeValidation(IValidation<EmployeeBase> nextLinker) : base(nextLinker)
        {
        }

        public override void Validate(EmployeeBase obj)
        {
            base.Validate(obj);
            if(obj.Salary==null)
            {
                throw new System.Exception("Salary is required");
            }
        }
    }
}
