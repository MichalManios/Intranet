

using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASdatabase
{
    public class ActualizationContentRepository : BaseRepository<ActualizationContent>, IActualizationContentRepository
    {
        protected override DbSet<ActualizationContent> DBSet => dbContext.ActualizationContent;

        public ActualizationContentRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {

        }

        public void UpdateActualizationContent(int IdZarzadzenie, ActualizationContent actualizationContent)
        {
            var foundEntity = DBSet.Where(x => x.ZarzadzenieId == IdZarzadzenie).FirstOrDefault();
            if (foundEntity == null)
            {
                DBSet.AddAsync(actualizationContent);
                SaveChangesAsync();
                return;
            }
            else
            {
                foundEntity.Content = actualizationContent.Content;
                foundEntity.Number = actualizationContent.Number;
                foundEntity.Year = actualizationContent.Year;
                foundEntity.ZarzadzenieId = actualizationContent.ZarzadzenieId;
                SaveChangesAsync();
                return;
            }
        }

        public void Delete(ActualizationContent actualizationContent)
        {
            var foundEntity = DBSet.Where(x => x.Id == actualizationContent.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public ActualizationContent FindActualizationContentByZarzadzenieId(int IdZarzadzenie)
        {
            var foundEntity = DBSet.Where(x => x.ZarzadzenieId == IdZarzadzenie).FirstOrDefault();
            return foundEntity;
        }

        public ActualizationContent FindActualizationContentById(int IdActualizationContent)
        {
            var foundEntity = DBSet.Where(x => x.Id == IdActualizationContent).FirstOrDefault();
            return foundEntity;
        }

        public void Delete(int IdZarzadzenie)
        {
            var foundEntity = DBSet.Where(x => x.ZarzadzenieId == IdZarzadzenie).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }
    }
}
