using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class InstrukcjaServices
    {
        private readonly IInstrukcjaRepository mInstrukcjaRepository;

        private readonly ASMapper mASMapper;

        public InstrukcjaServices(IInstrukcjaRepository instrukcjaRepository,
                                ASMapper aSMapper)
        {
            mInstrukcjaRepository = instrukcjaRepository;
            mASMapper = aSMapper;
        }

        public List<InstrukcjaViewModel> GetAllInstrukcjas()
        {
            var instrukcjasEntity = mInstrukcjaRepository.GetAll().ToList();
            var instrukcjasViewModels = mASMapper.Map(instrukcjasEntity);
            return instrukcjasViewModels;
        }

        public void DeleteInstrukcja(int InstrukcjaId)
        {
            var entity = mInstrukcjaRepository.FindInstrukcjaById(InstrukcjaId);
            mInstrukcjaRepository.Delete(entity);
        }

        public void SaveUpdateInstrukcja(int InstrukcjaID, InstrukcjaViewModel instrukcjaViewModel)
        {
            var instrukcjaEntity = mInstrukcjaRepository.FindInstrukcjaById(InstrukcjaID);
            if (instrukcjaEntity != null)
            {
                mInstrukcjaRepository.UpdateInstrukcja(InstrukcjaID, mASMapper.Map(instrukcjaViewModel));
            }
            else
            {
                var instrukcjaEntity2 = mASMapper.Map(instrukcjaViewModel);
                mInstrukcjaRepository.AddNewAsync(instrukcjaEntity2);
            }
        }

        public InstrukcjaViewModel GetInstrukcjaById(int IdInstrukcja)
        {
            var instrukcjaEntity = mInstrukcjaRepository.FindInstrukcjaById(IdInstrukcja);
            return mASMapper.Map(instrukcjaEntity);
        }
    }
}
