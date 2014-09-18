using GIS_Chaser.Models;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Mindscape.LightSpeed.Logging;
using GIS_Chaser.Plumbing.Interfaces;


namespace GIS_Chaser.Plumbing
{
    public class Repository<T> : IRepository<T> where T : Entity<int>
    {
        private readonly LightSpeedContext<Points_LightSpeedModelUnitOfWork> _context = new LightSpeedContext<Points_LightSpeedModelUnitOfWork>();
        private readonly Points_LightSpeedModelUnitOfWork _unitOfWork = new Points_LightSpeedModelUnitOfWork();

        public Repository(IConfiguration configuration)
        {
            _context = new LightSpeedContext<Points_LightSpeedModelUnitOfWork>
            {
                ConnectionString = configuration.ConnectionString,
                IdentityMethod = IdentityMethod.IdentityColumn,
                QuoteIdentifiers = true,
                Logger = new TraceLogger()
            };
            _unitOfWork = _context.CreateUnitOfWork();
        }

        public IList<T> Get(Expression<Func<T, bool>> predicate)
        {
            using (var unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Query<T>().Where(predicate).ToList();
            }
        }

        public IList<T> GetAll()
        {
            using (var unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.Find<T>();
            }
        }

        public void Add(T entity)
        {
            if (entity.Id > 0)
                _unitOfWork.Attach(entity);
            else
                _unitOfWork.Add(entity);
        }

        public void DeleteAll()
        {
            foreach (var entity in GetAll())
            {
                Delete(entity);
            }
        }

        public void Delete(T entity)
        {
            using (var unitOfWork = _context.CreateUnitOfWork())
            {
                unitOfWork.Remove(entity);
            }
        }

        public T FindById(int id)
        {
            using (var unitOfWork = _context.CreateUnitOfWork())
            {
                return unitOfWork.FindById<T>(id);
            }
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
            Dispose();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}