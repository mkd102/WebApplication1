namespace WebApplication1.Validation
{
    public interface IValidation<T>
       
    {
        void Validate(T obj);
    }
}
