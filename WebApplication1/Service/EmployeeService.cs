using AutoMapper;
using WebApplication1.Database;
using WebApplication1.Factories;
using WebApplication1.Model;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IDAL<Employee> _employee;
        public EmployeeService(IDAL<Employee> dAL) { 
        
        this._employee = dAL;
        }
        public void AddEmployee()
        {
            var eb = CorpFactory.GetEmployee("Temp"); ;
            eb.FirstName = "Megha";
            eb.LastName = "Dawagni";
            eb.Gender = "Female";
            eb.WagePerHour = 10;
            eb.Validate();
            //Employee employee = new Employee();
            //employee.Gender = "Female";
            //employee.Salary = 12;
            //employee.FirstName = "Test";
            //employee.LastName = "Test";
            //employee.EmployeeType = "Perm";
            //this._employee.Add(employee);

            //Employee employee1 = new Employee();
            //employee1.Gender = "Female";
            //employee1.Salary = 12;
            //employee1.FirstName = "bk";
            //employee1.LastName = "Test";
            //employee.EmployeeType = "Temp";
           var mapper= Automapper.Automapper.InitializeAutomapper();
              this._employee.Add(mapper.Map<Employee>(eb));
            
            this._employee.setUOW(null);
        }
    }
}
