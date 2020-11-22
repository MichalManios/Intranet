
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASdatabase
{
    public class OgloszenieRepository : BaseRepository<Ogloszenie>, IOgloszenieRepository
    {
        protected override DbSet<Ogloszenie> DBSet => dbContext.Ogloszenia;

        public OgloszenieRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {

        }
       

        
        public void Delete(Ogloszenie ogloszenie)
        {
            var foundEntity = DBSet.Where(x => x.Id == ogloszenie.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public void UpdateOgloszenie(Ogloszenie ogloszenie)
        {
            var foundOgloszenie = DBSet.Where(x => x.Id == ogloszenie.Id).FirstOrDefault();
            if (foundOgloszenie != null)
            {
                foundOgloszenie.ColorId = ogloszenie.ColorId;
                foundOgloszenie.Advertisement = ogloszenie.Advertisement;
                foundOgloszenie.SizeFontId = ogloszenie.SizeFontId;
                foundOgloszenie.AdvertisementURL = ogloszenie.AdvertisementURL;
                foundOgloszenie.URL = ogloszenie.URL;
                SaveChangesAsync();
                return;
            }
        }
        public void DeleteOgloszenie(Ogloszenie ogloszenie)
        {
            var foundEntity = DBSet.Where(x => x.Id == ogloszenie.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public Ogloszenie FindOgloszenieById(int ID)
        {
            var foundEntity = DBSet.Where(x => x.Id == ID).FirstOrDefault();
            return foundEntity;
        }

    }
}
