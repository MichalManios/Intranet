using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASdatabase
{
    public class ColorRepository : BaseRepository<Color>, IColorRepository
    {
        protected override DbSet<Color> DBSet => dbContext.Color;

        public ColorRepository(ASDbContextDatabase dbContext) : base(dbContext)
        {
            
        }

        public void UpdateColor(Color color)
        {
            var foundColor = DBSet.Where(x => x.ColorName == color.ColorName).FirstOrDefault();
            if (foundColor == null)
            {
                DBSet.AddAsync(color);
                SaveChangesAsync();
                return;
            }
            else
            {
                foundColor.ColorName = color.ColorName;
                foundColor.ColorValue = color.ColorValue;
                SaveChangesAsync();
                return;
            }
        }

        public void Delete(Color color)
        {
            var foundEntity = DBSet.Where(x => x.Id == color.Id).FirstOrDefault();

            if (foundEntity != null)
            {
                DBSet.Remove(foundEntity);

                SaveChangesAsync();
            }
        }

        public Color FindColorByName(string colorName)
        {
            var foundEntity = DBSet.Where(x => x.ColorName.ToUpper() == colorName.ToUpper()).FirstOrDefault();
            return foundEntity;
        }

        public Color FindColorById(int ID)
        {
            var foundEntity = DBSet.Where(x => x.Id == ID).FirstOrDefault();
            return foundEntity;
        }
    }
}
