using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASdatabase
{
    public class InstrukcjaRepository : BaseRepository<Instrukcja>, IInstrukcjaRepository
    {
        protected override DbSet<Instrukcja> DBSet => dbContext.Instrukcja;

        public InstrukcjaRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {

        }
        

        public void UpdateInstrukcja(int IdInstrukcja, Instrukcja instrukcja)
        {
            var foundInstrukcja = DBSet.Where(x => x.Id == IdInstrukcja).FirstOrDefault();
            if(foundInstrukcja==null)
            {
                DBSet.AddAsync(instrukcja);
                SaveChangesAsync();
                return;
            }
            else
            {
                foundInstrukcja.ContentOfInstruction = instrukcja.ContentOfInstruction;
                foundInstrukcja.URLToFile = instrukcja.URLToFile;
                foundInstrukcja.InstructionOrOther= foundInstrukcja.InstructionOrOther;
                SaveChangesAsync();
                return;
            }
        }

        public void Delete(Instrukcja instrukcja)
        {
            var foundEntity = DBSet.Where(x => x.Id == instrukcja.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public Instrukcja FindInstrukcjaById(int InstrukcjaId)
        {
            var entity = DBSet.Where(x => x.Id == InstrukcjaId).FirstOrDefault();
            return entity;
        }
    }
}
