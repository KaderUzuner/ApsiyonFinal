using Apsiyon.Domain.Interface;
using Apsiyon.Domain.Model;
using Apsiyon.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Apsiyon.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ApsiyonContext _context;
        private DbSet<TEntity> _entity;
        public Repository(ApsiyonContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }


        public async Task Add(TEntity entity)
        {
            await _entity.AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            _entity.Remove(entity);   
        }

        public async Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _entity.Where(filter).ToListAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }

        public void Update(TEntity entity)
        {
            _entity.Update(entity);
        }
    }
}
