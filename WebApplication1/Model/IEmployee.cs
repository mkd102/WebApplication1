namespace WebApplication1.Model
{
    public abstract class IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public abstract void Validate();
    }
}
