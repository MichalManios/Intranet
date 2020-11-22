using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASdatabase
{
    public interface IZarzadzenieRepository : IRepository<Zarzadzenie>
    {

        void UpdateZarzadzenie(int IdZarzadzenie, Zarzadzenie zarzadzenie);
        void Delete(Zarzadzenie zarzadzenie);
        Zarzadzenie FindZarzadzenieById(int ZarzadzenieId);

        Task<bool> SaveMany(List<Zarzadzenie> zarzadzenies);
    }
}