using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASdatabase
{
    public class ZarzadzenieRepository : BaseRepository<Zarzadzenie>, IZarzadzenieRepository
    {
        protected override DbSet<Zarzadzenie> DBSet => dbContext.Zarzadzenia;

        public ZarzadzenieRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {

        }

        

        public void UpdateZarzadzenie(int IdZarzadzenie, Zarzadzenie zarzadzenie)
        {
            var foundZarzadzenie = DBSet.Where(x => x.Id==IdZarzadzenie).FirstOrDefault();
            if(foundZarzadzenie==null)
            {
                DBSet.AddAsync(zarzadzenie);
                SaveChangesAsync();
                return;
            }
            else
            {
                foundZarzadzenie.ContentOfDirective = zarzadzenie.ContentOfDirective;
                foundZarzadzenie.Number = zarzadzenie.Number;
                foundZarzadzenie.Year = zarzadzenie.Year;
                foundZarzadzenie.Actual = zarzadzenie.Actual;
                SaveChangesAsync();
                return;
            }
        }

        public void Delete(Zarzadzenie zarzadzenie)
        {
            var foundEntity = DBSet.Where(x => x.Id == zarzadzenie.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public Zarzadzenie FindZarzadzenieById(int ZarzadzenieId)
        {
            var entity = DBSet.Where(x => x.Id == ZarzadzenieId).FirstOrDefault();
            return entity;
        }

        public async Task<bool> SaveMany(List<Zarzadzenie> zarzadzenies)
        {
            foreach (var item in zarzadzenies)
            {
                await DBSet.AddAsync(item);
            }
            SaveChangesAsync();
            return true;
        }
    }
}
