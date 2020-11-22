

using System.ComponentModel.DataAnnotations.Schema;

namespace ASdatabase
{
    public class ActualizationContent
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Year { get; set; }
        public string Content { get; set; }

        [ForeignKey("Zarzadzenia")]
        public int ZarzadzenieId { get; set; }
        public virtual Zarzadzenie Zarzadzenia { get; set; }
    }
}
