using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASdatabase
{
    public interface ISizeFontRepository : IRepository<SizeFont>
    {

        void UpdateFonts(SizeFont sizeFont);
        void Delete(SizeFont sizeFont);
        SizeFont FindFontBySize(string size);
        SizeFont FindFontByID(int Id);
    }
}