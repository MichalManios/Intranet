using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public interface ILoadOldZarzadzenia
    {
        Task<bool> Load(string NameOfFile, bool bActual);
        Task<bool> SaveAllToDatabase();
        void SaveToFileAllNoZarzadzenia(List<string> NoZarzadzenia);
        bool CheckNumber(string number);
        bool CheckYear(string Year);
    }
}
