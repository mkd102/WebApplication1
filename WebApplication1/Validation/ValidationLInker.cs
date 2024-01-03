using WebApplication1.Model;

namespace WebApplication1.Validation
{
    public class ValidationLInker : IValidation<EmployeeBase>
    {
        IValidation<EmployeeBase> _nextLinker=null;
        public ValidationLInker(IValidation<EmployeeBase> nextLinker) {
        this._nextLinker = nextLinker;
        }
        public virtual void Validate(EmployeeBase obj)
        {
            this._nextLinker.Validate(obj);
        }
    }
}
