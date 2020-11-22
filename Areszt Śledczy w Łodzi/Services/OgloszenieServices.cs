using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class OgloszenieServices 
    {
        private readonly IOgloszenieRepository mOgloszenieRepository;
        
        private readonly ASMapper mASMapper;

        public OgloszenieServices(IOgloszenieRepository ogloszenieRepository,
                                ASMapper aSMapper)
        {
            mOgloszenieRepository = ogloszenieRepository;
            mASMapper = aSMapper;
        }

        public List<OgloszenieViewModel> GetAllOgloszenia()
        {
            var ogloszeniaEntity = mOgloszenieRepository.GetAll().ToList();
            var ogloszeniaViewModels= mASMapper.Map(ogloszeniaEntity);
            return ogloszeniaViewModels;
        }

        public void DeleteOgloszenie(int OgloszenieId)
        {
            var entity = mOgloszenieRepository.FindOgloszenieById(OgloszenieId);
            mOgloszenieRepository.DeleteOgloszenie(entity);
        }

        public void SaveUpdateOgloszenie(int OgloszenieID, OgloszenieViewModel ogloszenieViewModel)
        {
            var ogloszenieEntity = mOgloszenieRepository.FindOgloszenieById(OgloszenieID);
            if (ogloszenieEntity != null)
            {
                mOgloszenieRepository.UpdateOgloszenie(mASMapper.Map(ogloszenieViewModel));
            }
            else
            {
                var ogloszenieEntity2 = mASMapper.Map(ogloszenieViewModel);
                mOgloszenieRepository.AddNewAsync(ogloszenieEntity2);
            }
        }

        public Ogloszenie FindOgloszenieById(int ID)
        {
            var ogloszenieEntity = mOgloszenieRepository.FindOgloszenieById(ID);
            return ogloszenieEntity;
        }
    }
}
