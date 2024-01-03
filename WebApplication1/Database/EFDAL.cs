using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using WebApplication1.Models;
using WebApplication1.UnitOfWork;

namespace WebApplication1.Database
{
    public partial class EFDAL<T> : TemplateEF, IDAL<T> where T : class
    {
        private IConfiguration _connectionstring;
        public EFDAL(IConfiguration configuration):base(configuration){
            this._connectionstring= configuration;
            }

        public virtual void Add(T obj)
        {
            Set<T>().Add(obj);      }

        public virtual void Delete(T obj)
        {
            Set<T>().Remove(obj);
        }

        public virtual void Save()
        {
            SaveChanges();
        }

        public virtual void Update(T obj)
        {
            Set<T>().Update(obj);
        }

        public void setUOW(IOW oW)
        {
            try
            {
                oW = new EntityUOW(this._connectionstring);
                SaveChanges();
                oW.Commit();

            }
            catch(Exception e)
            {
                oW.Rollback();
            }
        }
    }
}
