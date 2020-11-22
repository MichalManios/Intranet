using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class ZarzadzenieServices
    {
        private readonly IZarzadzenieRepository mZarzadzenieRepository;

        private readonly ASMapper mASMapper;

        public ZarzadzenieServices(IZarzadzenieRepository zarzadzenieRepository,
                                ASMapper aSMapper)
        {
            mZarzadzenieRepository = zarzadzenieRepository;
            mASMapper = aSMapper;
        }

        public List<ZarzadzenieViewModel> GetAllZarzadzenia()
        {
            var zarzadzeniaEntity = mZarzadzenieRepository.GetAll().ToList();
            var zarzadzeniaViewModels = mASMapper.Map(zarzadzeniaEntity);
            return zarzadzeniaViewModels;
        }

        public void DeleteZarzadzenie(int ZarzadzenieId)
        {
            var entity = mZarzadzenieRepository.FindZarzadzenieById(ZarzadzenieId);
            mZarzadzenieRepository.Delete(entity);
        }

        public void SaveUpdateZarzadzenie(int ZarzadzenieID, ZarzadzenieViewModel zarzadzenieViewModel)
        {
            var zarzadzenieEntity = mZarzadzenieRepository.FindZarzadzenieById(ZarzadzenieID);
            if (zarzadzenieEntity != null)
            {
                mZarzadzenieRepository.UpdateZarzadzenie(ZarzadzenieID, mASMapper.Map(zarzadzenieViewModel));
            }
            else
            {
                var zarzadzenieEntity2 = mASMapper.Map(zarzadzenieViewModel);
                mZarzadzenieRepository.AddNewAsync(zarzadzenieEntity2);
            }
        }

        public ZarzadzenieViewModel GetZarzadzenieById(int IdZarzadzenie)
        {
            var zarzadzenieEntity = mZarzadzenieRepository.FindZarzadzenieById(IdZarzadzenie);
            return mASMapper.Map(zarzadzenieEntity);
        }
    }
}
