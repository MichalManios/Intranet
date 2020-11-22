using ASdatabase;

namespace Areszt_Śledczy_w_Łodzi.Models
{
    public class ActualizationViewModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public string Content { get; set; }
        public int ZarzadzenieId { get; set; }
        public virtual Zarzadzenie Zarzadzenie { get; set; }
    }
}
