using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASdatabase
{
    public abstract class BaseRepository<Entity> : IRepository<Entity> where Entity : class
    {
        protected readonly ASDbContextDatabase dbContext;
        protected abstract DbSet<Entity> DBSet { get; }

        public BaseRepository(ASDbContextDatabase aSDbContext)
        {
            dbContext = aSDbContext;
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public List<Entity> GetAll()
        {
            var list = new List<Entity>();
            var entities = DBSet;
            foreach (var entity in entities)
            {
                list.Add(entity);
            }
            return list;
        }

        public void AddNew(Entity entity)
        {
            DBSet.Add(entity);
            SaveChanges();
        }

        public void SaveChangesAsync()
        {
            dbContext.SaveChangesAsync();
        }

        public void AddNewAsync(Entity entity)
        {
            DBSet.AddAsync(entity);
            SaveChangesAsync();
        }

    }
}
