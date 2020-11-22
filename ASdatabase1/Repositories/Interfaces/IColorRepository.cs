using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASdatabase
{
    public interface IColorRepository : IRepository<Color>
    {
        void UpdateColor(Color color);
        void Delete(Color color);
        Color FindColorByName(string colorName);
        Color FindColorById(int ID);
    }
}