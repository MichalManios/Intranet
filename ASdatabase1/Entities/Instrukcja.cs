namespace ASdatabase
{
    public class Instrukcja
    {
        public int Id { get; set; }
        public string URLToFile { get; set; }
        public bool InstructionOrOther { get; set; }
        public string ContentOfInstruction { get; set; }
    }
}