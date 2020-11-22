using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASdatabase
{
    public interface IRepository<Entity>
    {
        void SaveChanges();
        List<Entity> GetAll();
        void AddNew(Entity entity);
        void SaveChangesAsync();
        void AddNewAsync(Entity entity);
    }
}