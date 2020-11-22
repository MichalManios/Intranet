using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class ActualizationContentServices
    {
        private readonly IActualizationContentRepository mActualizationContentRepository;

        private readonly ASMapper mASMapper;

        public ActualizationContentServices(IActualizationContentRepository actualizationContentRepository, ASMapper aSMapper)
        {
            mActualizationContentRepository = actualizationContentRepository;
            mASMapper = aSMapper;
        }

        public List<ActualizationViewModel> GetAll()
        {
            var actualizationEntity = mActualizationContentRepository.GetAll().ToList();

            return mASMapper.Map(actualizationEntity);
        }

        public ActualizationViewModel GetActualizationContentByZarzadzenieId(int IdZarzadzenie)
        {
            var actualizationEntity = mActualizationContentRepository.GetAll().Where(x => x.ZarzadzenieId == IdZarzadzenie).FirstOrDefault();

            if (actualizationEntity != null) return mASMapper.Map(actualizationEntity);
            else return null;
        }

        public void AddNewActualization(ActualizationViewModel actualizationViewModel)
        {
            var actualizationViewModelEntity = actualizationViewModel;
            var actualizationEntity = mASMapper.Map(actualizationViewModelEntity);
            var result = mActualizationContentRepository.GetAll().Where(x => x.Id == actualizationViewModel.Id).FirstOrDefault();
            if (result == null) mActualizationContentRepository.AddNew(actualizationEntity);
        }

        public ActualizationViewModel FindActualizationContentByZarzadzenieId(int IdZarzadzenie)
        {
            var actualizationEntity = mActualizationContentRepository.FindActualizationContentByZarzadzenieId(IdZarzadzenie);
            return mASMapper.Map(actualizationEntity);
        }

        public ActualizationViewModel FindActualizationContentById(int IdActualization)
        {
            var actualizationEntity = mActualizationContentRepository.FindActualizationContentById(IdActualization);
            return mASMapper.Map(actualizationEntity);
        }

        public void SaveUpdateActualizationContent(int ZarzadzenieID, ActualizationViewModel actualizationViewModel)
        {
            var actualizationEntity = mActualizationContentRepository.FindActualizationContentByZarzadzenieId(ZarzadzenieID);
            if (actualizationEntity != null)
            {
                mActualizationContentRepository.UpdateActualizationContent(ZarzadzenieID, mASMapper.Map(actualizationViewModel));
            }
            else
            {
                var instrukcjaEntity2 = mASMapper.Map(actualizationViewModel);
                mActualizationContentRepository.AddNewAsync(instrukcjaEntity2);
            }
        }

        public void DeleteActualization(int IdZarzadzenie)
        {
            var entity = mActualizationContentRepository.FindActualizationContentByZarzadzenieId(IdZarzadzenie);
            mActualizationContentRepository.Delete(entity);
        }
    }
}
