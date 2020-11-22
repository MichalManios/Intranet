using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASdatabase
{
    public class SizeFontRepository : BaseRepository<SizeFont>, ISizeFontRepository
    {
        protected override DbSet<SizeFont> DBSet => dbContext.SizeFont;

        public SizeFontRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {

        } 

        

        public void UpdateFonts(SizeFont sizeFont)
        {
            var foundFont = DBSet.Where(x => x.FontSize == sizeFont.FontSize).FirstOrDefault();
            if(foundFont==null)
            {
                DBSet.AddAsync(foundFont);
                SaveChangesAsync();
                return;
            }
            else
            {
                foundFont.FontSize = sizeFont.FontSize;
                SaveChangesAsync();
                return;
            }
        }

        public void Delete(SizeFont sizeFont)
        {
            var foundEntity = DBSet.Where(x => x.Id == sizeFont.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public SizeFont FindFontBySize(string size)
        {
            var foundEntity = DBSet.Where(x => (x.FontSize.ToString() + "px") == size).FirstOrDefault();
            return foundEntity;
        }

        public SizeFont FindFontByID(int Id)
        {
            var foundEntity = DBSet.Where(x => x.Id ==Id).FirstOrDefault();
            return foundEntity;
        }
    }
}
