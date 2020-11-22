using ASdatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Areszt_Śledczy_w_Łodzi.Models
{
    public class OgloszenieViewModel
    {
        
        public int Id { get; set; }
        public string Advertisement { get; set; }
        public string AdvertisementURL { get; set; }
        public string URL { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public int SizeFontId { get; set; }
        public virtual SizeFont SizeFont { get; set; }
    }
}
