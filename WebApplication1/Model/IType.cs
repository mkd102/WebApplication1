namespace WebApplication1.Model
{
    public interface IType
    {
        bool isCorporate { get; set; }

        public EmployeeBase CreateEmployee(string type);

    }
}
