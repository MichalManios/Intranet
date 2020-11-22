using System.Collections.Generic;

namespace ASdatabase
{
    public interface IInstrukcjaRepository : IRepository<Instrukcja>
    {
        void UpdateInstrukcja(int IdInstrukcja, Instrukcja instrukcja);
        void Delete(Instrukcja instrukcja);
        Instrukcja FindInstrukcjaById(int InstrukcjaId);
    }
}