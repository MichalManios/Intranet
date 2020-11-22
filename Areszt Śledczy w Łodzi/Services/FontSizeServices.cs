using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Services
{
    public class FontSizeServices 
    {
        private readonly ISizeFontRepository mSizeFontRepository;
        private readonly ASMapper mASMapper;

        public FontSizeServices(ISizeFontRepository sizeFontRepository, ASMapper aSMapper)
        {
            mSizeFontRepository = sizeFontRepository;
            mASMapper = aSMapper;
        }

        public List<SizeFontViewModel> GetAllFontSize()
        {
            var fontEntity = mSizeFontRepository.GetAll().ToList();

            return mASMapper.Map(fontEntity);
        }

        public SizeFontViewModel GetFontBySize(int SizeFont)
        {
            var fontEntity = mSizeFontRepository.GetAll().Where(x => x.FontSize == SizeFont).FirstOrDefault();

            if (fontEntity != null) return mASMapper.Map(fontEntity);
            else return null;
        }

        public void AddNewFontSize(SizeFontViewModel sizeFontViewModel)
        {
            var sizeFontViewModelEntity = sizeFontViewModel;
            var sizeFontEntity = mASMapper.Map(sizeFontViewModelEntity);
            var result = mSizeFontRepository.GetAll().Where(x => x.FontSize == sizeFontEntity.FontSize).FirstOrDefault();
            if (result == null) mSizeFontRepository.AddNew(sizeFontEntity);
        }

        public SizeFont FindFontSizeBySize(string size)
        {
            var fontEntity = mSizeFontRepository.FindFontBySize(size);
            return fontEntity;
        }

        public SizeFont FindFontSizeById(int Id)
        {
            var fontEntity = mSizeFontRepository.FindFontByID(Id);
            return fontEntity;
        }
    }
}
