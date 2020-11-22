using System.ComponentModel.DataAnnotations.Schema;

namespace ASdatabase
{
    public class Ogloszenie
    {
        public int Id { get; set; }
        public string Advertisement { get; set; }

        public string AdvertisementURL { get; set; }
        public string URL { get; set; }


        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        [ForeignKey("SizeFont")]
        public int SizeFontId { get; set; }
        public virtual SizeFont SizeFont { get; set; }

    }
}