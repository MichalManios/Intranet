using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class ColorServices 
    {
        private readonly IColorRepository mColorRepository;

        private readonly ASMapper mASMapper;

        public ColorServices(IColorRepository colorRepository, ASMapper aSMapper)
        {
            mColorRepository = colorRepository;
            mASMapper = aSMapper;
        }

        public List<ColorViewModel> GetAllColorsViewModel()
        {
            var colorsEntity = mColorRepository.GetAll().ToList();

            return mASMapper.Map(colorsEntity);
        }

        public ColorViewModel GetColorByColorValue(string ColorValue)
        {
            var colorEntity = mColorRepository.GetAll().Where(x => x.ColorValue == ColorValue).FirstOrDefault();

            if (colorEntity != null) return mASMapper.Map(colorEntity);
            else return null;
        }

        public void AddNewColor(ColorViewModel colorViewModel)
        {
            var colorViewModelEntity = colorViewModel;
            var colorEntity = mASMapper.Map(colorViewModelEntity);
            var result = mColorRepository.GetAll().Where(x => x.ColorValue == colorEntity.ColorValue).FirstOrDefault();
            if(result==null) mColorRepository.AddNew(colorEntity);
        }

        public List<Color> GetAllColors()
        {
            var colorsEntities = mColorRepository.GetAll();

            return colorsEntities;
        }

        public Color FindColorByName(string colorName)
        {
            var colorEntity = mColorRepository.FindColorByName(colorName);
            return colorEntity;
        }

        public Color FindColorById(int Id)
        {
            var colorEntity = mColorRepository.FindColorById(Id);
            return colorEntity;
        }
    }
}
