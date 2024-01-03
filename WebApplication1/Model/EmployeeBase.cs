using WebApplication1.Validation;

namespace WebApplication1.Model
{
    public  class EmployeeBase: IEmployeeBase
    {
        IValidation<EmployeeBase> _validation = null;
        public EmployeeBase(IValidation<EmployeeBase> validation) {
            _validation = validation;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public int? WagePerHour { get; set; }

        public int? Salary { get; set; }

        public virtual void Validate()
        {
            _validation.Validate(this);
        }
    }
    public class CorporateTempEmployee : TempEmployee
    {
        public CorporateTempEmployee(IValidation<EmployeeBase>  validation):base(validation) { }
    }

    public class NonCorporateTempEmployee : TempEmployee
    {
        public NonCorporateTempEmployee(IValidation<EmployeeBase> validation) : base(validation) { }
    }
    public class CorporatePermEmployee: PermEmployee
    {
        public CorporatePermEmployee(IValidation<EmployeeBase> validation) : base(validation) { }


    }

    public class NonCorporatePermEmployee : PermEmployee
    {
        public NonCorporatePermEmployee(IValidation<EmployeeBase> validation) : base(validation) { }


    }
}
