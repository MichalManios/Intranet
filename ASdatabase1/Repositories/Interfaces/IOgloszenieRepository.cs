using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASdatabase
{
    public interface IOgloszenieRepository : IRepository<Ogloszenie>
    {

        void UpdateOgloszenie(Ogloszenie ogloszenie);
        void Delete(Ogloszenie ogloszenie);
        void DeleteOgloszenie(Ogloszenie ogloszenie);
        Ogloszenie FindOgloszenieById(int ID);
    }
}