using WebApplication1.Model;

namespace WebApplication1.Validation
{
    public class TempEmployeeValidation : ValidationLInker
    {
        public TempEmployeeValidation(IValidation<EmployeeBase> nextLinker) : base(nextLinker)
        {
        }

        public override void Validate(EmployeeBase obj)
        {
            base.Validate(obj);
            if (obj.WagePerHour == null)
            {
                throw new System.Exception("Wage is required");
            }
        }
    }
}
