using DistribuidoraDePicole.Domain.Interfaces.Repositories;
using DistribuidoraDePicole.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribuidoraDePicole.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DistribuidoraDePicoleContext db;

        public RepositoryBase(DistribuidoraDePicoleContext context)
        {
            db = context;
        }
        public void Add(TEntity obj)
        {
            try
            {
                db.Set<TEntity>().Add(obj);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao persistir os dados: {e.Message}");
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return db.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }
        public void Dispose()
        {

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            try
            {
                return await db.Set<TEntity>().ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao consultar os dados: {e.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            try
            {
                await db.Set<TEntity>().AddAsync(obj);
                db.SaveChanges();
                return obj;
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao persistir os dados: {e.Message}");
            }
        }
    }
}
