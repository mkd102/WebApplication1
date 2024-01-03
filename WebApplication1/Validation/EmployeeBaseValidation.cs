using System;
using WebApplication1.Model;

namespace WebApplication1.Validation
{
    public class EmployeeBaseValidation : IValidation<EmployeeBase>
    {
        public EmployeeBaseValidation() { } 
        public void Validate(EmployeeBase obj)
        {
            //if (obj.Id == 0)
            //{
            //    throw new System.Exception("Id is required");
            //}

            if (String.IsNullOrEmpty(obj.FirstName))
            {
                throw new System.Exception("FirstName is required");
            }
            if (String.IsNullOrEmpty(obj.LastName))
            {
                throw new System.Exception("LastName is required");
            }
            if (String.IsNullOrEmpty(obj.Gender))
            {
                throw new System.Exception("Gender is required");
            }
        }

    }
}

