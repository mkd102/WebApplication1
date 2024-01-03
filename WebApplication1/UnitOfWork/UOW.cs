using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Net.Http.Headers;
using WebApplication1.Database;

namespace WebApplication1.UnitOfWork
{
    public class EntityUOW :TemplateEF, IOW
    {
        public IDbContextTransaction transaction1 { get; set; }
        public EntityUOW(IConfiguration configuration ):base (configuration)
        {
            transaction1 = Database.BeginTransaction();
        }
        public void Commit()
        {
            transaction1.Commit();
        }

        public void Rollback()
        {
            transaction1.Rollback();
        }
    }
}
