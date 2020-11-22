using Areszt_Śledczy_w_Łodzi.Models;
using ASdatabase;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi
{
    public class ASMapper
    {
        private IMapper mMapper;
        public ASMapper()
        {
            mMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Color, ColorViewModel>()
                .ReverseMap();
                config.CreateMap<Instrukcja, InstrukcjaViewModel>()
               .ReverseMap();
                config.CreateMap<Ogloszenie, OgloszenieViewModel>()
               .ReverseMap();
                config.CreateMap<SizeFont, SizeFontViewModel>()
                .ReverseMap();
                config.CreateMap<Zarzadzenie, ZarzadzenieViewModel>()
                .ReverseMap();
                config.CreateMap<ActualizationContent, ActualizationViewModel>()
                .ReverseMap();
            }).CreateMapper();
        }

        #region Color Maps
        public ColorViewModel Map(Color color) => mMapper.Map<ColorViewModel>(color);
        public List<ColorViewModel> Map(List<Color> colors) => mMapper.Map<List<ColorViewModel>>(colors);
        public IEnumerable<ColorViewModel> Map(IEnumerable<Color> colors) => mMapper.Map<IEnumerable<ColorViewModel>>(colors);
        public Color Map(ColorViewModel color) => mMapper.Map<Color>(color);
        public List<Color> Map(List<ColorViewModel> color) => mMapper.Map<List<Color>>(color);
        public IEnumerable<Color> Map(IEnumerable<ColorViewModel> color) => mMapper.Map<IEnumerable<Color>>(color);
        #endregion

        #region Instrukcja Maps
        public InstrukcjaViewModel Map(Instrukcja instrukcja) => mMapper.Map<InstrukcjaViewModel>(instrukcja);
        public List<InstrukcjaViewModel> Map(List<Instrukcja> instrukcjas) => mMapper.Map<List<InstrukcjaViewModel>>(instrukcjas);
        public IEnumerable<InstrukcjaViewModel> Map(IEnumerable<Instrukcja> instrukcjas) => mMapper.Map<IEnumerable<InstrukcjaViewModel>>(instrukcjas);
        public Instrukcja Map(InstrukcjaViewModel instrukcja) => mMapper.Map<Instrukcja>(instrukcja);
        public List<Instrukcja> Map(List<InstrukcjaViewModel> instrukcjas) => mMapper.Map<List<Instrukcja>>(instrukcjas);
        public IEnumerable<Instrukcja> Map(IEnumerable<InstrukcjaViewModel> instrukcjas) => mMapper.Map<IEnumerable<Instrukcja>>(instrukcjas);
        #endregion

        #region Ogloszenie Maps
        public OgloszenieViewModel Map(Ogloszenie ogloszenie) => mMapper.Map<OgloszenieViewModel>(ogloszenie);
        public List<OgloszenieViewModel> Map(List<Ogloszenie> ogloszenies) => mMapper.Map<List<OgloszenieViewModel>>(ogloszenies);
        public IEnumerable<OgloszenieViewModel> Map(IEnumerable<Ogloszenie> ogloszenies) => mMapper.Map<IEnumerable<OgloszenieViewModel>>(ogloszenies);
        public Ogloszenie Map(OgloszenieViewModel ogloszenie) => mMapper.Map<Ogloszenie>(ogloszenie);
        public List<Ogloszenie> Map(List<OgloszenieViewModel> ogloszenies) => mMapper.Map<List<Ogloszenie>>(ogloszenies);
        public IEnumerable<Ogloszenie> Map(IEnumerable<OgloszenieViewModel> ogloszenies) => mMapper.Map<IEnumerable<Ogloszenie>>(ogloszenies);
        #endregion

        #region SizeFont Maps
        public SizeFontViewModel Map(SizeFont sizeFont) => mMapper.Map<SizeFontViewModel>(sizeFont);
        public List<SizeFontViewModel> Map(List<SizeFont> sizeFonts) => mMapper.Map<List<SizeFontViewModel>>(sizeFonts);
        public IEnumerable<SizeFontViewModel> Map(IEnumerable<SizeFont> sizeFonts) => mMapper.Map<IEnumerable<SizeFontViewModel>>(sizeFonts);
        public SizeFont Map(SizeFontViewModel sizeFont) => mMapper.Map<SizeFont>(sizeFont);
        public List<SizeFont> Map(List<SizeFontViewModel> sizeFonts) => mMapper.Map<List<SizeFont>>(sizeFonts);
        public IEnumerable<SizeFont> Map(IEnumerable<SizeFontViewModel> sizeFonts) => mMapper.Map<IEnumerable<SizeFont>>(sizeFonts);
        #endregion

        #region Zarzadzenie Maps
        public ZarzadzenieViewModel Map(Zarzadzenie zarzadzenie) => mMapper.Map<ZarzadzenieViewModel>(zarzadzenie);
        public List<ZarzadzenieViewModel> Map(List<Zarzadzenie> zarzadzenies) => mMapper.Map<List<ZarzadzenieViewModel>>(zarzadzenies);
        public IEnumerable<ZarzadzenieViewModel> Map(IEnumerable<Zarzadzenie> zarzadzenies) => mMapper.Map<IEnumerable<ZarzadzenieViewModel>>(zarzadzenies);
        public Zarzadzenie Map(ZarzadzenieViewModel zarzadzenie) => mMapper.Map<Zarzadzenie>(zarzadzenie);
        public List<Zarzadzenie> Map(List<ZarzadzenieViewModel> zarzadzenies) => mMapper.Map<List<Zarzadzenie>>(zarzadzenies);
        public IEnumerable<Zarzadzenie> Map(IEnumerable<ZarzadzenieViewModel> zarzadzenies) => mMapper.Map<IEnumerable<Zarzadzenie>>(zarzadzenies);
        #endregion

        #region ActualizationContent Maps
        public ActualizationViewModel Map(ActualizationContent actualizationContent) => mMapper.Map<ActualizationViewModel>(actualizationContent);
        public List<ActualizationViewModel> Map(List<ActualizationContent> actualizationContents) => mMapper.Map<List<ActualizationViewModel>>(actualizationContents);
        public IEnumerable<ActualizationViewModel> Map(IEnumerable<ActualizationContent> actualizationContents) => mMapper.Map<IEnumerable<ActualizationViewModel>>(actualizationContents);
        public ActualizationContent Map(ActualizationViewModel actualizationContent) => mMapper.Map<ActualizationContent>(actualizationContent);
        public List<ActualizationContent> Map(List<ActualizationViewModel> actualizationContents) => mMapper.Map<List<ActualizationContent>>(actualizationContents);
        public IEnumerable<ActualizationContent> Map(IEnumerable<ActualizationViewModel> actualizationContents) => mMapper.Map<IEnumerable<ActualizationContent>>(actualizationContents);
        #endregion

    }
}
