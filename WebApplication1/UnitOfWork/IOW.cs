namespace WebApplication1.UnitOfWork
{
    public interface IOW
    {
        void Commit();
        void Rollback();
    }
}
