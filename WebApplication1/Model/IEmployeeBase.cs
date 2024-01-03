namespace WebApplication1.Model
{
    public interface IEmployeeBase
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public int? WagePerHour { get; set; }

        public int? Salary { get; set; }

        public void Validate();
    }
}